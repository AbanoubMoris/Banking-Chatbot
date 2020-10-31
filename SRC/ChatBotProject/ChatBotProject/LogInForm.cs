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
    public partial class LogInForm : Form
    {
        string ordb = DBConnection.ordb;
        OracleConnection conn;
        bool isBanker = true;
        Thread th;
        long NID;
        string fName;
        public LogInForm()
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            InitializeComponent();
        }
        private bool getData()
        {
            int counter = 0;
            try
            {
                isBanker = true;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                User: cmd.CommandText = "checkUserData";
                if (isBanker)
                    cmd.CommandText = "checkData";
                cmd.BindByName = true;
                cmd.Parameters.Add("nationalid", nationalId_txtbox.Text.ToString()).OracleDbType = OracleDbType.Decimal;
                cmd.Parameters.Add("pass", password_txtbox.Text.ToString()).OracleDbType = OracleDbType.Varchar2;
                cmd.Parameters.Add("national_id", OracleDbType.Decimal).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("passw", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("fName", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                counter++;
                string nid = cmd.Parameters["national_id"].Value.ToString();
                string pass = cmd.Parameters["passw"].Value.ToString();

                fName = cmd.Parameters["fName"].Value.ToString();
                if (nid.Equals(nationalId_txtbox.Text.ToString()) && pass.Equals(password_txtbox.Text.ToString()))
                {
                    NID = Convert.ToInt64(nationalId_txtbox.Text.ToString());
                   // MessageBox.Show("Welcome " + fName + "!");
                    if (isBanker)
                    {
                        th = new Thread(openBankerForm);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                        isBanker = true;
                        this.Close();
                    }
                    else
                    {
                        th = new Thread(openValidateForm);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                        this.Close();
                    }
                    cmd.Parameters.Clear();
                }
                else
                {
                    
                    cmd.Parameters.Clear();
                    isBanker = false;
                    if(counter < 2)
                    {
                        goto User;
                    }
                    else
                    {
                        MessageBox.Show("Some Data Entered Wrong! Recheck Please .. ");
                    }
                       
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong!" + ex.Message);
            }


            return true;
        }
        
        private void openValidateForm()
        {
            Application.Run(new ValidateAccountForm(fName, NID, false));
        }
        private void openBankerForm()
        {
            Application.Run(new ChatBotForm(NID, 0, fName));
        }
        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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

        private void LoginButtons_Click(object sender, EventArgs e)
        {
            if (nationalId_txtbox.Text == "" || password_txtbox.Text == "")
            {
                MessageBox.Show("Some Feilds Are Empty ..  Please Enter Data");
            }
            else
            {
                getData();
            }
        }


        private void password_txtbox_OnValueChanged(object sender, EventArgs e)
        {
            password_txtbox.isPassword = true;
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if(bunifuCheckbox1.Checked == true)
            {
                password_txtbox.isPassword = false;
            }
            else
            {
                password_txtbox.isPassword = true;
            }
        }

        private void nationalId_txtbox_Enter(object sender, EventArgs e)
        {
            if(nationalId_txtbox.Text == "Enter Your National ID")
            {
                nationalId_txtbox.Text = "";
            }
        }

        private void nationalId_txtbox_Leave(object sender, EventArgs e)
        {
            if (nationalId_txtbox.Text == "")
            {
                nationalId_txtbox.Text = "Enter Your National ID";
            }
        }

        private void password_txtbox_Enter(object sender, EventArgs e)
        {
            if (password_txtbox.Text == "Enter Your Password")
            {
                password_txtbox.Text = "";
            }
        }

        private void password_txtbox_Leave(object sender, EventArgs e)
        {
            if (password_txtbox.Text == "")
            {
                password_txtbox.Text = "Enter Your Password";
            }
        }
    }
}
