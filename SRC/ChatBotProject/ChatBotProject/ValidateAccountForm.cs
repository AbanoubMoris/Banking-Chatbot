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
using System.Threading;
namespace ChatBotProject
{
    public partial class ValidateAccountForm : Form
    {
        string ordb = DBConnection.ordb;
        OracleConnection conn;
        Thread th;
        string ClientName;
        long Client_nID;
        public static long cardNum;
        public bool IschatOpen = false;
        public ValidateAccountForm(string name, long Id,bool IschatOpen)
        {
            this.IschatOpen = IschatOpen;
            conn = new OracleConnection(ordb);
            conn.Open();
            InitializeComponent();
            ClientName = name;
            Client_nID = Id;
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "checkCardNumPin";
            cmd.BindByName = true;
            cmd.Parameters.Add("cardnum", cardno_txtbox.Text).OracleDbType = OracleDbType.Decimal;
            cmd.Parameters.Add("pinin", pin_txtbox.Text).OracleDbType = OracleDbType.Varchar2;
            cmd.Parameters.Add("cardnumout", OracleDbType.Decimal).Direction = ParameterDirection.Output;
            try
            {
                cmd.ExecuteNonQuery();
                cardNum = Int64.Parse(cmd.Parameters["cardnumout"].Value.ToString());
                if (Int64.Parse(cardno_txtbox.Text) == cardNum)
                {
                    //MessageBox.Show("Hello  " + ClientName);
                    this.Close();
                    th = new Thread(openChatBotForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Retrieving Data .. " + ex.Message);
            }

        }
        private void openChatBotForm()
        {
            if (!IschatOpen)
                Application.Run(new ChatBotForm(Client_nID,cardNum, ClientName));
        }

        private void ValidateClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
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

        private void ValidateClient_Load(object sender, EventArgs e)
        {
            label4.Text += "Mr/Ms " + ClientName ;
        }

        private void pin_txtbox_OnValueChanged(object sender, EventArgs e)
        {
            pin_txtbox.isPassword = true;
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                pin_txtbox.isPassword = false;
            }
            else
            {
                pin_txtbox.isPassword = true;
            }
        }

        private void cardno_txtbox_Enter(object sender, EventArgs e)
        {
            if(cardno_txtbox.Text == "Enter Your Card No.")
            {
                cardno_txtbox.Text = "";
            }
        }

        private void cardno_txtbox_Leave(object sender, EventArgs e)
        {
            if (cardno_txtbox.Text == "")
            {
                cardno_txtbox.Text = "Enter Your Card No.";
            }
        }

        private void pin_txtbox_Enter(object sender, EventArgs e)
        {
            if (pin_txtbox.Text == "Enter Your PIN.")
            {
                pin_txtbox.Text = "";
            }
        }

        private void pin_txtbox_Leave(object sender, EventArgs e)
        {
            if (pin_txtbox.Text == "")
            {
                pin_txtbox.Text = "Enter Your PIN.";
            }
        }
    }
}
