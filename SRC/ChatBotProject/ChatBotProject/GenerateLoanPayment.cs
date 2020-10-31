using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace ChatBotProject
{
    class GenerateLoanPayment
    {
        struct Loan
        {
            public int loanNumber;
            public int loanAmount;
            public int accountID;
            public int installmentMonths;
            public DateTime loanStartDate;
            public DateTime lastPaymentDate;
        }

        public static void Generate_Loan_Payment()
        {
            string ordb = DBConnection.ordb;
            OracleConnection conn;
            conn = new OracleConnection(ordb);
            conn.Open();
            // Getting Today's Date
            DateTime today = DateTime.Now;

            // Getting Loan Data
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * from loan";
            cmd.CommandType = CommandType.Text;

            // Storing Loan Data
            List<Loan> loans = new List<Loan>();

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Loan newLoan = new Loan();
                newLoan.loanNumber = int.Parse(dr[0].ToString());
                newLoan.loanAmount = int.Parse(dr[1].ToString());
                newLoan.accountID = int.Parse(dr[2].ToString());
                newLoan.installmentMonths = int.Parse(dr[3].ToString());
                newLoan.loanStartDate = (DateTime)dr[4];
                newLoan.lastPaymentDate = (DateTime)dr[5];
                loans.Add(newLoan);
            }
            dr.Close();

            // Detecting if it is time to pay installment
            for (int i = 0; i < loans.Count; i++)
            {
                DateTime loanEndDate = loans[i].loanStartDate.AddMonths(loans[i].installmentMonths);

                // Loan is payed
                if (DateTime.Compare(loans[i].lastPaymentDate, loanEndDate) >= 0)
                {
                    continue;
                }

                // Loan isn't payed
                DateTime newPayment = loans[i].lastPaymentDate.AddMonths(1);
                while (DateTime.Compare(newPayment, today) <= 0)
                {

                    // Updating lastPaymentDate
                    OracleCommand c = new OracleCommand();
                    c.Connection = conn;
                    c.CommandText = "update loan set lastpaymentdate=:newPayment where loanno =:loanNumber";
                    c.Parameters.Add("newPayment", newPayment);
                    c.Parameters.Add("loanNumber", loans[i].loanNumber);
                    c.ExecuteNonQuery();

                    // Getting Account Balance
                    int newBalance = 0;
                    OracleCommand c2 = new OracleCommand();
                    c2.Connection = conn;
                    c2.CommandText = "SELECT accountbalance from account where accountid =:id";
                    c2.CommandType = CommandType.Text;
                    c2.Parameters.Add("id", loans[i].accountID);
                    OracleDataReader dr2 = c2.ExecuteReader();
                    if (dr2.Read())
                    {
                        newBalance = int.Parse(dr2[0].ToString());
                    }
                    dr2.Close();

                    // Calculating monthly payment with interest and new balance

                    double paymentAmount = (loans[i].loanAmount / loans[i].installmentMonths) * (1 + (0.01 * loans[i].installmentMonths));
                    int paymentAm = Convert.ToInt32(paymentAmount);
                    newBalance -= paymentAm;

                    // Inserting new Payment
                    OracleCommand c3 = new OracleCommand();
                    c3.Connection = conn;
                    c3.CommandText = "insert into payment values (payment_no.nextval, :PAmmount, :PDate, :LoanNo)";
                    c3.Parameters.Add("PAmmount", paymentAmount);
                    c3.Parameters.Add("PDate", newPayment);
                    c3.Parameters.Add("LoanNo", loans[i].loanNumber);
                    c3.ExecuteNonQuery();

                    // Updating Account Balance
                    OracleCommand c4 = new OracleCommand();
                    c4.Connection = conn;
                    c4.CommandText = "update Account set accountbalance=:balance where accountid =:id";
                    c4.Parameters.Add("balance", newBalance);
                    c4.Parameters.Add("id", loans[i].accountID);
                    c4.ExecuteNonQuery();

                    // Loan is payed
                    if (DateTime.Compare(newPayment, loanEndDate) >= 0)
                    {
                        break;
                    }

                    // Increment
                    newPayment = newPayment.AddMonths(1);
                }
            }
            conn.Dispose();
        }
    }
}
