using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBotProject
{
    public partial class CrystalReportForm : Form
    {
        ClientTotalBalance CB;
        TransactionsPerMonth CR;
        Loan LD;
        public CrystalReportForm()
        {
            InitializeComponent();
        }

        private void CrystalReportForm_Load(object sender, EventArgs e)
        {
            CB = new ClientTotalBalance();
            LD = new Loan();
            CR = new TransactionsPerMonth();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value.ToString());
        }


        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ClientBalanceBtn_Click(object sender, EventArgs e)
        {
            crystalReportViewer.ReportSource = CB;
        }

        private void TransBtn_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, comboBox1.Text);
            CR.SetParameterValue(1, textBox1.Text);
            CR.SetParameterValue(2, textBox2.Text);
            crystalReportViewer.ReportSource = CR;
        }

        private void LoanD_Btn_Click(object sender, EventArgs e)
        {
            crystalReportViewer.ReportSource = LD;
        }
    }
}
