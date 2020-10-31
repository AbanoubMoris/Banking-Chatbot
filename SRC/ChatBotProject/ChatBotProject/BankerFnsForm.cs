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
    public partial class BankerFnsForm : Form
    {
        string Ordb = DBConnection.ordb;
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public BankerFnsForm()
        {
            conn = new OracleConnection(Ordb);
            conn.Open();
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string constr = DBConnection.ordb;
            string cmdstr = "";
            //200043892843839
            if (rdo_Clients.Checked)
                cmdstr = @"select t.clientfname, t.clientlname, t.clientphonenumber,
                        t.clientgender, t.clientaddress, t.clientnationalid 
                        from client t
                        where t.clientnationalid = :n";
            else if (rdo_accounts.Checked)
                cmdstr = @"select a.accounttypename, a.accountbalance, a.accountemailaddress,
                            a.accountpassword from client t, account a
                        where t.clientnationalid =  :n and a.clientid = t.clientid";
            else if (rdo_cards.Checked)
                cmdstr = @"select c.cardamount, c.cardno, c.cardenddate, 
                             c.cardpin, c.cardssn 
                            from client t, card c, account a
                            where t.clientnationalid =  :n  and a.clientid = t.clientid 
                            and c.accountid = a.accountid";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("n", txt_ActorName.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void loadInformation_Click(object sender, EventArgs e)
        {
            string constr = DBConnection.ordb;

            string cmdstr = "";

            if (rdo_Clients.Checked)
                cmdstr = "select * from client";
            else if (rdo_accounts.Checked)
                cmdstr = "select * from account";
            else if (rdo_cards.Checked)
                cmdstr = "select * from card";
            else if (rdb_bankerInfo.Checked)
                cmdstr = "select * from banker";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void save_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void txt_ActorName_Enter(object sender, EventArgs e)
        {
            if (txt_ActorName.Text == "National ID")
                txt_ActorName.Text = "";
        }

        private void txt_ActorName_Leave(object sender, EventArgs e)
        {
            if (txt_ActorName.Text == "")
                txt_ActorName.Text = "National ID";
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Request_loan_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select MAX(accountbalance), count(transactiontype) from account inner join transaction on account.accountid = transaction.accountid inner join card on card.accountid = account.accountid where card.cardno = :num and transactiontype like 'D%'";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("num", CardNo_txt.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            bool rule1 = false;
            bool rule2 = false;
            if (dr.Read())
            {
                int clientmoney = Convert.ToInt32(dr[0].ToString());
                int loanamount = Convert.ToInt32(loan_amount_txtbox.Text);
                int num_deposite = Convert.ToInt32(dr[1].ToString());
                int installment = Convert.ToInt32(installment_txtbox.Text);
                if (clientmoney * 2 > loanamount)
                {
                    rule1 = true;
                    if (num_deposite >= 5)
                    {
                        rule2 = true;
                    }
                    else
                    {
                        MessageBox.Show("you should make many deposite with money");
                    }
                    if (rule1 && rule2)
                    {
                        OracleCommand d = new OracleCommand();
                        d.Connection = conn;
                        d.CommandText = "reqloan";
                        d.Parameters.Add("cardnum", CardNo_txt.Text);
                        d.Parameters.Add("loanamount", loanamount);
                        d.Parameters.Add("installment", installment);
                        d.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            d.ExecuteNonQuery();
                            MessageBox.Show("your request for this loan is accepted");
                            CardNo_txt.Text = "";
                            installment_txtbox.Text = "";
                            loan_amount_txtbox.Text = "";
                        }
                        catch
                        {
                            MessageBox.Show("your request for this loan is rejected");
                        }
                        


                    }
                }
                else
                {
                    MessageBox.Show("you cann't take this loan");
                }


            }
            dr.Close();
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

        private void CardNo_txt_Enter(object sender, EventArgs e)
        {
            if (CardNo_txt.Text == "CardNo.")
            {
                CardNo_txt.Text = "";
            }
        }

        private void CardNo_txt_Leave(object sender, EventArgs e)
        {
            if (CardNo_txt.Text == "")
            {
                CardNo_txt.Text = "CardNo.";
            }
        }

        private void loan_amount_txtbox_Enter(object sender, EventArgs e)
        {
            if (loan_amount_txtbox.Text == "Loan Amount.")
            {
                loan_amount_txtbox.Text = "";
            }
        }

        private void loan_amount_txtbox_Leave(object sender, EventArgs e)
        {
            if (loan_amount_txtbox.Text == "")
            {
                loan_amount_txtbox.Text = "Loan Amount.";
            }
        }

        private void installment_txtbox_Enter(object sender, EventArgs e)
        {
            if (installment_txtbox.Text == "Installment Months.")
            {
                installment_txtbox.Text = "";
            }
        }

        private void installment_txtbox_Leave(object sender, EventArgs e)
        {
            if (installment_txtbox.Text == "")
            {
                installment_txtbox.Text = "Installment Months.";
            }
        }
    }
}
