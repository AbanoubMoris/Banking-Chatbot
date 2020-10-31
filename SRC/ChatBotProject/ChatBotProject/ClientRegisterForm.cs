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
    public partial class ClientRegisterForm : Form
    {
        string ordb = DBConnection.ordb;
        OracleConnection conn;
        string cmdstr = "";
        int aid, iid;
        int bankerid;
        long NID;
        public ClientRegisterForm(long nid)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            InitializeComponent();
            NID = nid;
        }
        private void registerClient()
        {
            if (checkInformation())
            {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insertClient";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("fname", fname_txtbox.Text);
                cmd.Parameters.Add("lname", lname_txtbox.Text);
                cmd.Parameters.Add("phonenumber", phonenumber_txtbox.Text);
                cmd.Parameters.Add("gender", gender_combobox.selectedValue.ToString());
                cmd.Parameters.Add("address", address_txtbox.Text);
                cmd.Parameters.Add("nationalid", nationalid_txtbox.Text);



                try
                {
                    cmd.ExecuteNonQuery();
                    showRestInfo();
                    Register_button.Visible = false;
                    secondbutton.Visible = true;
                    registerFinal_button.Visible = false;
                    DisableInfo();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Went Wrong... " + ex.Message);
                }
            }


        }
        private void registerFinal_button_Click(object sender, EventArgs e)
        {
            Reg();

        }
        private void continueReg()
        {
            if (checkInformation2())
            {
                String Mssg = checkAccountType();
                if (Mssg.Length == 0)
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    int cid = getClientID();
                    int bid = getBankerID();
                    cmdstr = @"INSERT INTO REGISTRATION (CLIENTID,BANKERID) VALUES(:CID , :BID)";
                    OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, conn);
                    adapter.SelectCommand.Parameters.Add("CID", cid);
                    adapter.SelectCommand.Parameters.Add("BID", bid);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    cmd.CommandText = "insertaccount";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("accountbalance", accountbalance_txtbox.Text).OracleDbType = OracleDbType.Decimal;
                    cmd.Parameters.Add("pass", pass_txtbox.Text).OracleDbType = OracleDbType.Varchar2;
                    cmd.Parameters.Add("email", email_txtbox.Text).OracleDbType = OracleDbType.Varchar2;
                    cmd.Parameters.Add("c_id", (cid));
                    cmd.Parameters.Add("accounttype", accounttype_combobox.selectedValue.ToString());

                    try
                    {
                        cmd.ExecuteNonQuery();
                        iid = getAccountID(cid);
                        showRestFinalInfo();
                        secondbutton.Visible = false;
                        registerFinal_button.Visible = true;
                        DisableRestInfo();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something Went Wrong... " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show(Mssg);
                }
            }
        }

        private string checkAccountType()
        {
            if (accounttype_combobox.selectedIndex == 0 && Convert.ToInt32(accountbalance_txtbox.Text.ToString()) > 20000)
                return "Student Account Can't Have More than 20000!";
            else if (accounttype_combobox.selectedIndex == 1 && Convert.ToInt32(accountbalance_txtbox.Text.ToString()) > 1000000)
                return "Business Account Can't Have More than 1000000!";
            else if (accounttype_combobox.selectedIndex == 2 && Convert.ToInt32(accountbalance_txtbox.Text.ToString()) > 500000)
                return "PrePaid Account Can't Have More than 500000!";

            return "";
        }
        private void Reg()
        {

            if (pin_txtbox.Text.Length == 4)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insertcard";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("cardenddate", enddate_picker.Value).OracleDbType = OracleDbType.Date;
                if (cardammount_txtbox.Text.Length == 0)
                    cardammount_txtbox.Text = "0";
                cmd.Parameters.Add("cardamount", cardammount_txtbox.Text).OracleDbType = OracleDbType.Decimal;
                cmd.Parameters.Add("account_id", iid).OracleDbType = OracleDbType.Decimal;
                cmd.Parameters.Add("pin", pin_txtbox.Text).OracleDbType = OracleDbType.Decimal;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registered successfully");
                    
                    clearTxtBoxes();
                    enableInfo();
                    this.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Went Wrong... " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("PIN Code Must Be 4 Numbers!");
            }
        }

        private int getAccountID(int cid)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getaccountid";
            cmd.BindByName = true;
            cmd.Parameters.Add("CID", cid).OracleDbType = OracleDbType.Decimal;
            cmd.Parameters.Add("id", OracleDbType.Decimal).Direction = ParameterDirection.Output;

            try
            {
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(cmd.Parameters["id"].Value.ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Retrieving Data .. \n " + ex.Message);
            }
            return 0;
        }

        private int getClientID()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getclientid";
            cmd.BindByName = true;
            cmd.Parameters.Add("NID", nationalid_txtbox.Text).OracleDbType = OracleDbType.Decimal;
            cmd.Parameters.Add("id", OracleDbType.Decimal).Direction = ParameterDirection.Output;

            try
            {
                cmd.ExecuteNonQuery();
                aid = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                return aid;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Retrieving Data .. " + ex.Message);
            }
            return aid;
        }

        private int getBankerID()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getBankerID";
            cmd.BindByName = true;
            cmd.Parameters.Add("NID", NID).OracleDbType = OracleDbType.Decimal;
            cmd.Parameters.Add("BID", OracleDbType.Decimal).Direction = ParameterDirection.Output;

            try
            {
                cmd.ExecuteNonQuery();
                bankerid = Convert.ToInt32(cmd.Parameters["BID"].Value.ToString());
                return bankerid;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Retrieving Data .. " + ex.Message);
            }
            return bankerid;
        }

        private void showRestInfo()
        {
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            accountbalance_txtbox.Visible = true;
            email_txtbox.Visible = true;
            pass_txtbox.Visible = true;
            confirmpass_txtbox.Visible = true;
            accounttype_combobox.Visible = true;
            accountbalance_txtbox.Visible = true;
            bunifuCheckbox1.Visible = true;
        }
        private void DisableInfo()
        {
            fname_txtbox.Enabled = false;
            lname_txtbox.Enabled = false;
            phonenumber_txtbox.Enabled = false;
            address_txtbox.Enabled = false;
            nationalid_txtbox.Enabled = false;
        }
        private void enableInfo()
        {
            fname_txtbox.Enabled = true;
            lname_txtbox.Enabled = true;
            phonenumber_txtbox.Enabled = true;
            address_txtbox.Enabled = true;
            nationalid_txtbox.Enabled = true;
            accountbalance_txtbox.Enabled = true;
            email_txtbox.Enabled = true;
            pass_txtbox.Enabled = true;
            confirmpass_txtbox.Enabled = true;
            accountbalance_txtbox.Enabled = true;
        }
        private void DisableRestInfo()
        {
            accountbalance_txtbox.Enabled = false;
            email_txtbox.Enabled = false;
            pass_txtbox.Enabled = false;
            confirmpass_txtbox.Enabled = false;
            accountbalance_txtbox.Enabled = false;
            bunifuCheckbox1.Enabled = false;
        }


        private void showRestFinalInfo()
        {
            label12.Visible = true;
            label13.Visible = true;
            pintxt.Visible = true;
            cardammount_txtbox.Visible = true;
            enddate_picker.Visible = true;
            pin_txtbox.Visible = true;
        }

        private void clearTxtBoxes()
        {
            fname_txtbox.Text = "";
            lname_txtbox.Text = "";
            phonenumber_txtbox.Text = "";
            address_txtbox.Text = "";
            nationalid_txtbox.Text = "";
            pass_txtbox.Text = "";
            confirmpass_txtbox.Text = "";
            accountbalance_txtbox.Text = "";
            gender_combobox.selectedIndex = -1;
            accounttype_combobox.selectedIndex = -1;
            enddate_picker.Text = "";
            cardammount_txtbox.Text = "";
            pin_txtbox.Text = "";
            email_txtbox.Text = "";

        }

        private void secondbutton_Click(object sender, EventArgs e)
        {
            continueReg();
        }

        private bool checkInformation()
        {
            int countFname = fname_txtbox.Text.Length;
            int countLname = lname_txtbox.Text.Length;
            int countNational = nationalid_txtbox.Text.Length;
            int countAddress = address_txtbox.Text.Length;
            int countPhone = phonenumber_txtbox.Text.Length;
            int countGender = gender_combobox.Items.Count();
            bool national, phone;

            national = (countNational == 14) ? true : false;
            phone = (countPhone == 11) ? true : false;

            if (countFname == 0)
            {
                MessageBox.Show("First Name Can't Be Empty!");
                return false;
            }
            if (countGender == 0)
            {
                MessageBox.Show("Gender Can't Be Empty!");
                return false;
            }
            if (countLname == 0)
            {
                MessageBox.Show("Last Name Can't Be Empty!");
                return false;
            }
            if (countNational == 0)
            {
                MessageBox.Show("NationalId Can't Be Empty!");
                return false;
            }
            if (countPhone == 0)
            {
                MessageBox.Show("PhoneNumber Can't Be Empty!");
                return false;
            }
            if (countAddress == 0)
            {
                MessageBox.Show("Address Can't Be Empty!");
                return false;
            }

            if (national && phone)
                return true;
            if (!national)
            {
                MessageBox.Show("Wrong NationalID!");
                return false;
            }
            if (!phone)
            {
                MessageBox.Show("Wrong PhoneNumber!");
                return false;
            }

            return true;
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            registerClient();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool checkInformation2()
        {
            int countPassword = pass_txtbox.Text.Length;
            int countConfirmPass = confirmpass_txtbox.Text.Length;
            int coundAccountType = accounttype_combobox.Items.Count();
            int countEmail = email_txtbox.Text.Length;
            int accountBalance = accountbalance_txtbox.Text.Length;


            bool confirmPass, pass;

            pass = (countPassword > 6) ? true : false;
            confirmPass = (pass_txtbox.Text.Equals(confirmpass_txtbox.Text)) ? true : false;


            if ((countPassword == 0 || countConfirmPass == 0))
            {
                MessageBox.Show("Password Can't Be Empty!");
                return false;
            }
            if (coundAccountType == 0)
            {
                MessageBox.Show("AccountType Can't Be Empty!");
                return false;
            }
            if (countEmail == 0)
            {
                MessageBox.Show("Email Can't Be Empty!");
                return false;
            }
            if (accountBalance == 0)
            {
                MessageBox.Show("Account Balance Can't Be Empty!");
                return false;
            }
            if (pass)
                return true;

            if (!confirmPass)
            {
                MessageBox.Show("Password Must Match Confirm Password!");
                return false;
            }
            if (!pass)
            {
                MessageBox.Show("Weak Password!");
                return false;
            }
            return true;
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

        private void fname_txtbox_Enter(object sender, EventArgs e)
        {
            if (fname_txtbox.Text == "Enter First Name")
                fname_txtbox.Text = "";
        }

        private void fname_txtbox_Leave(object sender, EventArgs e)
        {
            if (fname_txtbox.Text == "")
                fname_txtbox.Text = "Enter First Name";
        }

        private void lname_txtbox_Enter(object sender, EventArgs e)
        {
            if (lname_txtbox.Text == "Enter Last Name")
                lname_txtbox.Text = "";
        }

        private void lname_txtbox_Leave(object sender, EventArgs e)
        {
            if (lname_txtbox.Text == "")
                lname_txtbox.Text = "Enter Last Name";
        }

        private void phonenumber_txtbox_Enter(object sender, EventArgs e)
        {
            if (phonenumber_txtbox.Text == "Enter Phone Number")
                phonenumber_txtbox.Text = "";
        }

        private void phonenumber_txtbox_Leave(object sender, EventArgs e)
        {
            if (phonenumber_txtbox.Text == "")
                phonenumber_txtbox.Text = "Enter Phone Number";
        }

        private void address_txtbox_Enter(object sender, EventArgs e)
        {
            if (address_txtbox.Text == "Enter Address")
                address_txtbox.Text = "";
        }

        private void address_txtbox_Leave(object sender, EventArgs e)
        {
            if (address_txtbox.Text == "")
                address_txtbox.Text = "Enter Address";
        }

        private void nationalid_txtbox_Enter(object sender, EventArgs e)
        {
            if (nationalid_txtbox.Text == "Enter National ID")
                nationalid_txtbox.Text = "";
        }

       

        private void accountbalance_txtbox_Enter(object sender, EventArgs e)
        {
            if (accountbalance_txtbox.Text == "Enter Account Balance")
                accountbalance_txtbox.Text = "";

        }

        private void accountbalance_txtbox_Leave(object sender, EventArgs e)
        {
            if (accountbalance_txtbox.Text == "")
                accountbalance_txtbox.Text = "Enter Account Balance";
        }

        private void email_txtbox_Enter(object sender, EventArgs e)
        {
            if (email_txtbox.Text == "Enter Email")
                email_txtbox.Text = "";
        }

        private void email_txtbox_Leave(object sender, EventArgs e)
        {
            if (email_txtbox.Text == "")
                email_txtbox.Text = "Enter Email";
        }

        private void pass_txtbox_Enter(object sender, EventArgs e)
        {
            if (pass_txtbox.Text == "Enter Password")
                pass_txtbox.Text = "";
        }

        private void pass_txtbox_Leave(object sender, EventArgs e)
        {
            if (pass_txtbox.Text == "")
                pass_txtbox.Text = "Enter Password";

        }
        private void confirmpass_txtbox_Enter(object sender, EventArgs e)
        {
            if (confirmpass_txtbox.Text == "Enter Confirmed Password")
                confirmpass_txtbox.Text = "";
        }

        private void confirmpass_txtbox_Leave(object sender, EventArgs e)
        {
            if (confirmpass_txtbox.Text == "")
                confirmpass_txtbox.Text = "Enter Confirmed Password";
        }

        private void cardammount_txtbox_Enter(object sender, EventArgs e)
        {
            if (cardammount_txtbox.Text == "Enter Card Amount")
                cardammount_txtbox.Text = "";
        }

        private void cardammount_txtbox_Leave(object sender, EventArgs e)
        {
            if (cardammount_txtbox.Text == "")
                cardammount_txtbox.Text = "Enter Card Amount";
        }

        private void pin_txtbox_Enter(object sender, EventArgs e)
        {
            if (pin_txtbox.Text == "Enter PIN Code")
                pin_txtbox.Text = "";
        }

        private void nationalid_txtbox_Leave(object sender, EventArgs e)
        {
            if (nationalid_txtbox.Text == "")
                nationalid_txtbox.Text = "Enter National ID";
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if(bunifuCheckbox1.Checked == true)
            {
                pass_txtbox.isPassword = false;
                confirmpass_txtbox.isPassword = false;
            }
            else
            {
                pass_txtbox.isPassword = true;
                confirmpass_txtbox.isPassword = true;
            }
        }

        private void pass_txtbox_OnValueChanged(object sender, EventArgs e)
        {
            pass_txtbox.isPassword = true;
        }

        private void confirmpass_txtbox_OnValueChanged(object sender, EventArgs e)
        {
            confirmpass_txtbox.isPassword = true;
        }

        private void pin_txtbox_Leave(object sender, EventArgs e)
        {
            if (pin_txtbox.Text == "")
                pin_txtbox.Text = "Enter PIN Code";
        }
    }
}
