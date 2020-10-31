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
    public partial class BankerRegisterForm : Form
    {
        string ordb = DBConnection.ordb;
        OracleConnection conn;
        public static bool wasCalledFrombankerForm = false;

        public BankerRegisterForm(bool regForm = false)
        {
            InitializeComponent();
            wasCalledFrombankerForm = regForm;
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void register_button_Click(object sender, EventArgs e)
        {

            if (checkInformation())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select banker_id.nextval from dual";
                long lnNextVal = Convert.ToInt64(cmd.ExecuteScalar());

                cmd.CommandText = "insertBanker";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("fname", fname_txtbox.Text).OracleDbType = OracleDbType.Varchar2;
                cmd.Parameters.Add("lname", lname_txtbox.Text).OracleDbType = OracleDbType.Varchar2;
                cmd.Parameters.Add("nationalid", nationalid_txtbox.Text).OracleDbType = OracleDbType.Decimal;
                cmd.Parameters.Add("phonenumber", phonenumber_txtbox.Text).OracleDbType = OracleDbType.Decimal;
                cmd.Parameters.Add("address", address_txtbox.Text).OracleDbType = OracleDbType.Varchar2;
                cmd.Parameters.Add("gender", gender_combobox.selectedValue.ToString()).OracleDbType = OracleDbType.Char;
                cmd.Parameters.Add("password", password_txtbox.Text).OracleDbType = OracleDbType.Varchar2;



                cmd.BindByName = true;
                try
                {
                    cmd.ExecuteNonQuery();
                    if (wasCalledFrombankerForm)
                    {
                        MessageBox.Show("Registered Successfully!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Registered Successfully!");
                        emptyTextboxes();
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Went Wrong .... :  " + ex.ToString());
                }
            }
        }
        private bool checkInformation()
        {
            int countFname = fname_txtbox.Text.Length;
            int countLname = lname_txtbox.Text.Length;
            int countNational = nationalid_txtbox.Text.Length;
            int countAddress = address_txtbox.Text.Length;
            int countPhone = phonenumber_txtbox.Text.Length;
            int countPassword = password_txtbox.Text.Length;
            int countConfirmPass = confirmpassword_txtbox.Text.Length;
            bool national, phone, pass, confirmPass;

            national = (countNational == 14) ? true : false;
            phone = (countPhone == 11) ? true : false;
            pass = (countPassword > 6) ? true : false;
            confirmPass = (password_txtbox.Text.Equals(confirmpassword_txtbox.Text)) ? true : false;

            if (countFname == 0)
            {
                MessageBox.Show("First Name Can't Be Empty!");
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
            if ((countPassword == 0 || countConfirmPass == 0))
            {
                MessageBox.Show("Password Can't Be Empty!");
                return false;
            }
            if (national && phone && pass)
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
        private void emptyTextboxes()
        {
            fname_txtbox.Text = "";
            lname_txtbox.Text = "";
            nationalid_txtbox.Text = "";
            address_txtbox.Text = "";
            phonenumber_txtbox.Text = "";
            password_txtbox.Text = "";
            confirmpassword_txtbox.Text = "";
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

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fname_txtbox_Enter(object sender, EventArgs e)
        {
            if (fname_txtbox.Text == "Enter First Name")
            {
                fname_txtbox.Text = "";
            }
        }
        private void fname_txtbox_Leave(object sender, EventArgs e)
        {
            if (fname_txtbox.Text == "")
            {
                fname_txtbox.Text = "Enter First Name";
            }
        }

        private void lname_txtbox_Enter(object sender, EventArgs e)
        {
            if (lname_txtbox.Text == "Enter Last Name")
            {
                lname_txtbox.Text = "";
            }
        }

        private void lname_txtbox_Leave(object sender, EventArgs e)
        {
            if (lname_txtbox.Text == "")
            {
                lname_txtbox.Text = "Enter Last Name";
            }
        }

        private void nationalid_txtbox_Enter(object sender, EventArgs e)
        {
            if (nationalid_txtbox.Text == "Enter National ID")
            {
                nationalid_txtbox.Text = "";
            }

        }

        private void address_txtbox_Enter(object sender, EventArgs e)
        {
            if (address_txtbox.Text == "Enter Address")
            {
                address_txtbox.Text = "";
            }
        }

        private void password_txtbox_Enter(object sender, EventArgs e)
        {
            if (password_txtbox.Text == "Enter Password")
            {
                password_txtbox.Text = "";
            }
        }

        private void confirmpassword_txtbox_Enter(object sender, EventArgs e)
        {
            if (confirmpassword_txtbox.Text == "Enter Confirmed Password")
            {
                confirmpassword_txtbox.Text = "";
            }
        }

        private void phonenumber_txtbox_Enter(object sender, EventArgs e)
        {
            if (phonenumber_txtbox.Text == "Enter Phone No.")
            {
                phonenumber_txtbox.Text = "";
            }
        }

        private void nationalid_txtbox_Leave(object sender, EventArgs e)
        {
            if (nationalid_txtbox.Text == "")
            {
                nationalid_txtbox.Text = "Enter National ID";
            }
        }

        private void address_txtbox_Leave(object sender, EventArgs e)
        {

            if (address_txtbox.Text == "")
            {
                address_txtbox.Text = "Enter Address";
            }
        }

        private void password_txtbox_Leave(object sender, EventArgs e)
        {
            if (password_txtbox.Text == "")
            {
                password_txtbox.Text = "Enter Password";
            }
        }

        private void confirmpassword_txtbox_Leave(object sender, EventArgs e)
        {
            if (confirmpassword_txtbox.Text == "")
            {
                confirmpassword_txtbox.Text = "Enter Confirmed Password";
            }
        }

        private void phonenumber_txtbox_Leave(object sender, EventArgs e)
        {
            if (phonenumber_txtbox.Text == "")
            {
                phonenumber_txtbox.Text = "Enter Phone No.";
            }
        }

        private void password_txtbox_OnValueChanged(object sender, EventArgs e)
        {
            password_txtbox.isPassword = true;
        }

        private void confirmpassword_txtbox_OnValueChanged(object sender, EventArgs e)
        {
            confirmpassword_txtbox.isPassword = true;
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if(bunifuCheckbox1.Checked == true)
            {
                password_txtbox.isPassword = false;
                confirmpassword_txtbox.isPassword = false;
            }
            else
            {
                password_txtbox.isPassword = true;
                confirmpassword_txtbox.isPassword = true;
            }
        }
    }
}
