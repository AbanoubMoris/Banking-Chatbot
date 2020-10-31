using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ChatBotProject
{
    public partial class ClientInfoForm : Form
    {
        string Ordb = DBConnection.ordb;
        OracleConnection conn;
        long Client_CardNo;
        public ClientInfoForm(long no)
        {
            conn = new OracleConnection(Ordb);
            conn.Open();
            InitializeComponent();
            Client_CardNo = no;
        }

        private void view_client_data_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select clientfname , clientlname , clientphonenumber , clientaddress , clientgender , clientnationalid from client inner join account using(clientid) inner join card on card.cardno = :num and card.accountid =account.accountid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("num", Client_CardNo);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
               // dt.Columns[0].ColumnName = "Client First Name";
                DataGridView.DataSource = dt;
            }
            dr.Close();
        }

        private void view_account_data_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select accountbalance ,  accountemailaddress , accounttypename , accountpassword , clientid from account inner join card on card.cardno = :num and card.accountid = account.accountid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("num", Client_CardNo);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                DataGridView.DataSource = dt;
            }
            dr.Close();
           
        }

        private void view_card_data_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select cardno , cardamount , cardenddate , cardssn from card inner join account on card.cardno = :num and card.accountid = account.accountid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("num", Client_CardNo);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                DataGridView.DataSource = dt;
            }
            dr.Close();
           
        }

        private void view_trans_month_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getlasttrans";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("cardnum", Client_CardNo);
            cmd.Parameters.Add("output", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                DataGridView.DataSource = dt;
            }
            dr.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        //private void Request_loan_btn_Click(object sender, EventArgs e)
        //{
        //    OracleCommand cmd = new OracleCommand();
        //    cmd.Connection = conn;
        //    cmd.CommandText = "select MAX(accountbalance), count(transactiontype) from account inner join transaction on account.accountid = transaction.accountid inner join card on card.accountid = account.accountid where card.cardno = :num and transactiontype like 'D%'";
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("num", Client_CardNo);
        //    OracleDataReader dr = cmd.ExecuteReader();
        //    bool rule1 = false;
        //    bool rule2 = false;
        //    if (dr.Read())
        //    {
        //        int clientmoney = Convert.ToInt32(dr[0].ToString());
        //        int loanamount = Convert.ToInt32(loan_amount_txtbox.Text);
        //        int num_deposite = Convert.ToInt32(dr[1].ToString());
        //        // int installment = Convert.ToInt32(installment_txtbox.Text);
        //        if (clientmoney * 2 > loanamount)
        //        {
        //            rule1 = true;
        //            if (num_deposite >= 5)
        //            {
        //                rule2 = true;
        //            }
        //            else
        //            {
        //                MessageBox.Show("you should make many deposite with money");
        //            }
        //            if (rule1 && rule2)
        //            {
        //                OracleCommand d = new OracleCommand();
        //                d.Connection = conn;
        //                d.CommandText = "reqloan";
        //                d.Parameters.Add("cardnum", Client_CardNo);
        //                d.Parameters.Add("loanamount", Convert.ToInt32(loan_amount_txtbox.Text.ToString()));
        //                d.Parameters.Add("installment", Convert.ToInt32(installment_txtbox.Text.ToString()) );
        //                int r = d.ExecuteNonQuery();
        //                if (r != -1)
        //                {
        //                    MessageBox.Show("your request for this loan is accepted");
        //                }

        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("you cann't take this loan");
        //        }
        //    }
        //    dr.Close();

        //}
    }
}
