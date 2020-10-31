namespace ChatBotProject
{
    partial class CrystalReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrystalReportForm));
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.LoanD_Btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel4 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClientBalanceBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ComboBoxTrans = new Bunifu.Framework.UI.BunifuDropdown();
            this.TransBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SDtxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.EDtxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Location = new System.Drawing.Point(8, 44);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(825, 509);
            this.crystalReportViewer.TabIndex = 9;
            // 
            // LoanD_Btn
            // 
            this.LoanD_Btn.ActiveBorderThickness = 1;
            this.LoanD_Btn.ActiveCornerRadius = 20;
            this.LoanD_Btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LoanD_Btn.ActiveForecolor = System.Drawing.Color.White;
            this.LoanD_Btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LoanD_Btn.BackColor = System.Drawing.SystemColors.Control;
            this.LoanD_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoanD_Btn.BackgroundImage")));
            this.LoanD_Btn.ButtonText = "Loan Details";
            this.LoanD_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoanD_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanD_Btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LoanD_Btn.IdleBorderThickness = 1;
            this.LoanD_Btn.IdleCornerRadius = 20;
            this.LoanD_Btn.IdleFillColor = System.Drawing.Color.White;
            this.LoanD_Btn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LoanD_Btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LoanD_Btn.Location = new System.Drawing.Point(872, 492);
            this.LoanD_Btn.Margin = new System.Windows.Forms.Padding(5);
            this.LoanD_Btn.Name = "LoanD_Btn";
            this.LoanD_Btn.Size = new System.Drawing.Size(181, 41);
            this.LoanD_Btn.TabIndex = 16;
            this.LoanD_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoanD_Btn.Click += new System.EventHandler(this.LoanD_Btn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.close);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(0, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1082, 40);
            this.panel4.TabIndex = 15;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            // 
            // close
            // 
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(1054, 11);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 16);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Crystal Report";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ChatBotProject.Properties.Resources.Diversity_Avatars_Avatars_Robot_02;
            this.pictureBox1.Location = new System.Drawing.Point(8, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ClientBalanceBtn
            // 
            this.ClientBalanceBtn.ActiveBorderThickness = 1;
            this.ClientBalanceBtn.ActiveCornerRadius = 20;
            this.ClientBalanceBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientBalanceBtn.ActiveForecolor = System.Drawing.Color.White;
            this.ClientBalanceBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientBalanceBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ClientBalanceBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClientBalanceBtn.BackgroundImage")));
            this.ClientBalanceBtn.ButtonText = "Client Total Balance";
            this.ClientBalanceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientBalanceBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientBalanceBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ClientBalanceBtn.IdleBorderThickness = 1;
            this.ClientBalanceBtn.IdleCornerRadius = 20;
            this.ClientBalanceBtn.IdleFillColor = System.Drawing.Color.White;
            this.ClientBalanceBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientBalanceBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientBalanceBtn.Location = new System.Drawing.Point(868, 90);
            this.ClientBalanceBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ClientBalanceBtn.Name = "ClientBalanceBtn";
            this.ClientBalanceBtn.Size = new System.Drawing.Size(181, 41);
            this.ClientBalanceBtn.TabIndex = 6;
            this.ClientBalanceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClientBalanceBtn.Click += new System.EventHandler(this.ClientBalanceBtn_Click);
            // 
            // ComboBoxTrans
            // 
            this.ComboBoxTrans.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxTrans.BorderRadius = 3;
            this.ComboBoxTrans.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ComboBoxTrans.Items = new string[0];
            this.ComboBoxTrans.Location = new System.Drawing.Point(907, 231);
            this.ComboBoxTrans.Name = "ComboBoxTrans";
            this.ComboBoxTrans.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ComboBoxTrans.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ComboBoxTrans.selectedIndex = -1;
            this.ComboBoxTrans.Size = new System.Drawing.Size(146, 21);
            this.ComboBoxTrans.TabIndex = 20;
            // 
            // TransBtn
            // 
            this.TransBtn.ActiveBorderThickness = 1;
            this.TransBtn.ActiveCornerRadius = 20;
            this.TransBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TransBtn.ActiveForecolor = System.Drawing.Color.White;
            this.TransBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TransBtn.BackColor = System.Drawing.SystemColors.Control;
            this.TransBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TransBtn.BackgroundImage")));
            this.TransBtn.ButtonText = "Transaction Per Month";
            this.TransBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.TransBtn.IdleBorderThickness = 1;
            this.TransBtn.IdleCornerRadius = 20;
            this.TransBtn.IdleFillColor = System.Drawing.Color.White;
            this.TransBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TransBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TransBtn.Location = new System.Drawing.Point(860, 387);
            this.TransBtn.Margin = new System.Windows.Forms.Padding(5);
            this.TransBtn.Name = "TransBtn";
            this.TransBtn.Size = new System.Drawing.Size(201, 41);
            this.TransBtn.TabIndex = 19;
            this.TransBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TransBtn.Click += new System.EventHandler(this.TransBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(843, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Client Crystal Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(843, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Transaction Crystal Report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(843, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Loan Crystal Report";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(843, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Choose Process";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(844, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Start Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(844, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "End Date";
            // 
            // SDtxt
            // 
            this.SDtxt.BorderColorFocused = System.Drawing.Color.DarkSlateBlue;
            this.SDtxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SDtxt.BorderColorMouseHover = System.Drawing.Color.DarkSlateBlue;
            this.SDtxt.BorderThickness = 3;
            this.SDtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SDtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SDtxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.SDtxt.isPassword = false;
            this.SDtxt.Location = new System.Drawing.Point(913, 294);
            this.SDtxt.Margin = new System.Windows.Forms.Padding(4);
            this.SDtxt.Name = "SDtxt";
            this.SDtxt.Size = new System.Drawing.Size(136, 25);
            this.SDtxt.TabIndex = 29;
            this.SDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EDtxt
            // 
            this.EDtxt.BorderColorFocused = System.Drawing.Color.DarkSlateGray;
            this.EDtxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EDtxt.BorderColorMouseHover = System.Drawing.Color.DarkSlateBlue;
            this.EDtxt.BorderThickness = 3;
            this.EDtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EDtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EDtxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.EDtxt.isPassword = false;
            this.EDtxt.Location = new System.Drawing.Point(913, 353);
            this.EDtxt.Margin = new System.Windows.Forms.Padding(4);
            this.EDtxt.Name = "EDtxt";
            this.EDtxt.Size = new System.Drawing.Size(136, 25);
            this.EDtxt.TabIndex = 30;
            this.EDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(966, 132);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(886, 132);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 33;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(932, 261);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 32;
            // 
            // CrystalReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 565);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.EDtxt);
            this.Controls.Add(this.SDtxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoanD_Btn);
            this.Controls.Add(this.ComboBoxTrans);
            this.Controls.Add(this.TransBtn);
            this.Controls.Add(this.ClientBalanceBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.crystalReportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrystalReportForm";
            this.Text = "CrystalReportForm";
            this.Load += new System.EventHandler(this.CrystalReportForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 LoanD_Btn;
        private Bunifu.Framework.UI.BunifuThinButton2 ClientBalanceBtn;
        private Bunifu.Framework.UI.BunifuDropdown ComboBoxTrans;
        private Bunifu.Framework.UI.BunifuThinButton2 TransBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox SDtxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox EDtxt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}