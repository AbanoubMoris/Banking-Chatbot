using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
using System.Windows.Forms;
namespace ChatBotProject
{
    class TransactionsDB
    {
        string ordb = DBConnection.ordb;

        OracleConnection conn;
        public TransactionsDB()
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            //GetClientAccounts(5); // suppose is 3
        }
        public int getCardFromAccountID(int acc)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetCardFromAccountID";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("AccountID", acc);
            cmd.Parameters.Add("CardID", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                return Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            return 0;
        }
        int getClientIDFromCardID(int CardNo)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETCLIENTACCOUNTS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("cardno", CardNo);
            cmd.Parameters.Add("CID", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();

            int CID = Convert.ToInt32(cmd.Parameters["CID"].Value.ToString());
            return CID;

        }

       public Dictionary<int, List<string>> AccountDetials;

        public Dictionary<int, string> GetClientAccounts(int cardNo)
        {
            Dictionary<int, string> accounts = new Dictionary<int, string>();
            int ClientID = getClientIDFromCardID(cardNo);
            AccountDetials = new Dictionary<int, List<string>>();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETCLIENTACCOUNTSFROMCLIENT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("clientId", ClientID);
            cmd.Parameters.Add("accounts", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
           
            while (dr.Read())
            {
                List<string> details = new List<string>();
                accounts.Add(Convert.ToInt32(dr[0]),dr[3].ToString());
                details.Add(dr[1].ToString()); //Account Balance
                details.Add(dr[2].ToString()); //AccountEmailAddress
                details.Add(dr[3].ToString()); //AccountTypeName 
                AccountDetials.Add(Convert.ToInt32(dr[0]), details);
            }
            dr.Close();
            return accounts;
        }


        int CardNo, pin;

        public bool GetCardInfo(int CardNo, int pin)
        {
            this.CardNo = CardNo;
            this.pin = pin;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetCardNo";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("CardNo", CardNo);
            cmd.Parameters.Add("Cards", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            int pinNo = -1;
            while (dr.Read())
            {
                pinNo = Convert.ToInt32(dr[4].ToString());
            }
            dr.Close();
            return (pin == pinNo);
        }


        public int GetAccountFROMCARDNo(int CardNo)
        {
            OracleCommand C = new OracleCommand();
            C.Connection = conn;
            C.CommandText = "GETACCOUNTFROMCARDNO";
            C.CommandType = CommandType.StoredProcedure;
            C.Parameters.Add("CardNo", CardNo);
            C.Parameters.Add("ACCOUNTID", OracleDbType.Int32, ParameterDirection.Output);
            C.ExecuteNonQuery();
            int Key = Convert.ToInt32(C.Parameters["ACCOUNTID"].Value.ToString());
            return Key ;
        }
        public int makeTransaction(string TransType, int amount)
        {

            int Key = GetAccountFROMCARDNo(CardNo);

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "MAKETRANSACTION";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("TRANSACTIONTYPE", TransType);
            cmd.Parameters.Add("TRANSACTIONAMOUNT", amount);
            cmd.Parameters.Add("ACCOUNTID", Key);

           // cmd.Parameters.Add("CardNo", CardNo);


            int NewBalance = 0;
            try
            {
                NewBalance = Convert.ToInt32(AccountDetials[Key][0]);

                if (TransType == "Deposit")
                    NewBalance += amount;
                else
                    NewBalance -= amount;

                if (NewBalance < 0) return -1;
                cmd.Parameters.Add("ACCOUNTCURRUNTBALANCE", NewBalance);

                cmd.ExecuteNonQuery();
                //UPDATEACCOUTBALANCE

                OracleCommand CC = new OracleCommand();
                CC.Connection = conn;
                CC.CommandText = "UPDATEACCOUTBALANCE";
                CC.CommandType = CommandType.StoredProcedure;
                CC.Parameters.Add("accountID", Key);
                CC.Parameters.Add("NewBalance", NewBalance);
                CC.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("please select account first");
            }
            return NewBalance;

        }
    }
}
