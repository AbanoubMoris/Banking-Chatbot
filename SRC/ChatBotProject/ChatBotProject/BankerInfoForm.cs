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
    public partial class BankerInfoForm : Form
    {
        string ordb = DBConnection.ordb;
        OracleConnection conn;
        long NID;
      
        public BankerInfoForm(long nid)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            InitializeComponent();
            NID = nid;
            getData();
        }
        private void getData()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getData";
            cmd.BindByName = true;
            cmd.Parameters.Add("NID", NID).OracleDbType = OracleDbType.Decimal;
            cmd.Parameters.Add("fName", OracleDbType.Varchar2, 24).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("lName", OracleDbType.Varchar2, 24).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("nationalid", OracleDbType.Decimal).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("phoneNumber", OracleDbType.Decimal).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("address", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("gender", OracleDbType.Varchar2, 1).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("pass", OracleDbType.Varchar2, 24).Direction = ParameterDirection.Output;


            try
            {
                cmd.ExecuteNonQuery();
                string fName = cmd.Parameters["fName"].Value.ToString();
                string lName = cmd.Parameters["lName"].Value.ToString();
                string nid = cmd.Parameters["nationalid"].Value.ToString();
                string phoneNumber = cmd.Parameters["phoneNumber"].Value.ToString();
                string address = cmd.Parameters["address"].Value.ToString();
                string gender = cmd.Parameters["gender"].Value.ToString();
                string pass = cmd.Parameters["pass"].Value.ToString();
                fName_txtbox.Text = fName;
                lName_txtbox.Text = lName;
                nationalID_txtbox.Text = nid;
                phoneNumber_txtbox.Text = "0" + phoneNumber;
                address_txtbox.Text = address;
                gender_txtbox.Text = gender;
                password_txtbox.Text = pass;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Retrieving Data .. " + ex.Message);
            }
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            fName_txtbox.Enabled = true;
            lName_txtbox.Enabled = true;
            phoneNumber_txtbox.Enabled = true;
            address_txtbox.Enabled = true;
            password_txtbox.Enabled = true;
        }

        private void confirmEdit_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updateBankerdata";
            cmd.BindByName = true;
            cmd.Parameters.Add("nationalid", NID).OracleDbType = OracleDbType.Decimal;
            cmd.Parameters.Add("fname", fName_txtbox.Text.ToString()).OracleDbType = OracleDbType.Varchar2;
            cmd.Parameters.Add("lname", lName_txtbox.Text.ToString()).OracleDbType = OracleDbType.Varchar2;
            cmd.Parameters.Add("phoneNumber", phoneNumber_txtbox.Text).OracleDbType = OracleDbType.Decimal;
            cmd.Parameters.Add("address", address_txtbox.Text.ToString()).OracleDbType = OracleDbType.Varchar2;
            cmd.Parameters.Add("pass", password_txtbox.Text.ToString()).OracleDbType = OracleDbType.Varchar2;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating Data .. " + ex.Message);
            }
        }

      
        private void showPass_checkbox_OnChange(object sender, EventArgs e)
        {
            if (showPass_checkbox.Checked ==true)
                password_txtbox.isPassword = false;
            else
                password_txtbox.isPassword = true;
        }

        private void password_txtbox_OnValueChanged(object sender, EventArgs e)
        {
            password_txtbox.isPassword = true;
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

      
       
    }
}
