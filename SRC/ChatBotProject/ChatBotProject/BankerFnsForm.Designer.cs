namespace ChatBotProject
{
    partial class BankerFnsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankerFnsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ActorName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.rdo_cards = new System.Windows.Forms.RadioButton();
            this.rdo_accounts = new System.Windows.Forms.RadioButton();
            this.rdo_Clients = new System.Windows.Forms.RadioButton();
            this.loadInformation = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.search = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UpdateBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Request_loan_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.installment_txtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loan_amount_txtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CardNo_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.rdb_bankerInfo = new System.Windows.Forms.RadioButton();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(29, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 33);
            this.label2.TabIndex = 20;
            this.label2.Text = "Client National ID";
            // 
            // txt_ActorName
            // 
            this.txt_ActorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ActorName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_ActorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ActorName.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ActorName.HintText = "";
            this.txt_ActorName.isPassword = false;
            this.txt_ActorName.LineFocusedColor = System.Drawing.Color.DarkSlateGray;
            this.txt_ActorName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_ActorName.LineMouseHoverColor = System.Drawing.Color.DarkSlateGray;
            this.txt_ActorName.LineThickness = 3;
            this.txt_ActorName.Location = new System.Drawing.Point(223, 87);
            this.txt_ActorName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ActorName.Name = "txt_ActorName";
            this.txt_ActorName.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.txt_ActorName.Size = new System.Drawing.Size(223, 45);
            this.txt_ActorName.TabIndex = 21;
            this.txt_ActorName.Text = "National ID";
            this.txt_ActorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ActorName.Enter += new System.EventHandler(this.txt_ActorName_Enter);
            this.txt_ActorName.Leave += new System.EventHandler(this.txt_ActorName_Leave);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuCards1.Controls.Add(this.rdb_bankerInfo);
            this.bunifuCards1.Controls.Add(this.rdo_cards);
            this.bunifuCards1.Controls.Add(this.rdo_accounts);
            this.bunifuCards1.Controls.Add(this.rdo_Clients);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(484, 53);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(200, 127);
            this.bunifuCards1.TabIndex = 22;
            // 
            // rdo_cards
            // 
            this.rdo_cards.AutoSize = true;
            this.rdo_cards.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdo_cards.Location = new System.Drawing.Point(33, 67);
            this.rdo_cards.Name = "rdo_cards";
            this.rdo_cards.Size = new System.Drawing.Size(131, 21);
            this.rdo_cards.TabIndex = 23;
            this.rdo_cards.Text = "Cards Information";
            this.rdo_cards.UseVisualStyleBackColor = true;
            // 
            // rdo_accounts
            // 
            this.rdo_accounts.AutoSize = true;
            this.rdo_accounts.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdo_accounts.Location = new System.Drawing.Point(18, 41);
            this.rdo_accounts.Name = "rdo_accounts";
            this.rdo_accounts.Size = new System.Drawing.Size(154, 21);
            this.rdo_accounts.TabIndex = 23;
            this.rdo_accounts.Text = "Accounts Information";
            this.rdo_accounts.UseVisualStyleBackColor = true;
            // 
            // rdo_Clients
            // 
            this.rdo_Clients.AutoSize = true;
            this.rdo_Clients.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdo_Clients.Location = new System.Drawing.Point(30, 14);
            this.rdo_Clients.Name = "rdo_Clients";
            this.rdo_Clients.Size = new System.Drawing.Size(137, 21);
            this.rdo_Clients.TabIndex = 1;
            this.rdo_Clients.Text = "Clients Information";
            this.rdo_Clients.UseVisualStyleBackColor = true;
            // 
            // loadInformation
            // 
            this.loadInformation.ActiveBorderThickness = 1;
            this.loadInformation.ActiveCornerRadius = 20;
            this.loadInformation.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loadInformation.ActiveForecolor = System.Drawing.Color.White;
            this.loadInformation.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.loadInformation.BackColor = System.Drawing.SystemColors.Control;
            this.loadInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadInformation.BackgroundImage")));
            this.loadInformation.ButtonText = "Load Information";
            this.loadInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadInformation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loadInformation.IdleBorderThickness = 1;
            this.loadInformation.IdleCornerRadius = 20;
            this.loadInformation.IdleFillColor = System.Drawing.Color.White;
            this.loadInformation.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.loadInformation.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loadInformation.Location = new System.Drawing.Point(491, 184);
            this.loadInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadInformation.Name = "loadInformation";
            this.loadInformation.Size = new System.Drawing.Size(176, 37);
            this.loadInformation.TabIndex = 25;
            this.loadInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loadInformation.Click += new System.EventHandler(this.loadInformation_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(11, 229);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(698, 228);
            this.dataGridView1.TabIndex = 28;
            // 
            // search
            // 
            this.search.ActiveBorderThickness = 1;
            this.search.ActiveCornerRadius = 20;
            this.search.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.search.ActiveForecolor = System.Drawing.Color.White;
            this.search.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.search.BackColor = System.Drawing.SystemColors.Control;
            this.search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search.BackgroundImage")));
            this.search.ButtonText = "Search";
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.search.IdleBorderThickness = 1;
            this.search.IdleCornerRadius = 20;
            this.search.IdleFillColor = System.Drawing.Color.White;
            this.search.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.search.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.search.Location = new System.Drawing.Point(156, 159);
            this.search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(146, 35);
            this.search.TabIndex = 32;
            this.search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.ActiveBorderThickness = 1;
            this.UpdateBtn.ActiveCornerRadius = 20;
            this.UpdateBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UpdateBtn.ActiveForecolor = System.Drawing.Color.White;
            this.UpdateBtn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.UpdateBtn.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.BackgroundImage")));
            this.UpdateBtn.ButtonText = "Save Modification";
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UpdateBtn.IdleBorderThickness = 1;
            this.UpdateBtn.IdleCornerRadius = 20;
            this.UpdateBtn.IdleFillColor = System.Drawing.Color.White;
            this.UpdateBtn.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.UpdateBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UpdateBtn.Location = new System.Drawing.Point(142, 465);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(174, 37);
            this.UpdateBtn.TabIndex = 33;
            this.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateBtn.Click += new System.EventHandler(this.save_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.ActiveBorderThickness = 1;
            this.DeleteBtn.ActiveCornerRadius = 20;
            this.DeleteBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteBtn.ActiveForecolor = System.Drawing.Color.White;
            this.DeleteBtn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.ButtonText = "Delete";
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteBtn.IdleBorderThickness = 1;
            this.DeleteBtn.IdleCornerRadius = 20;
            this.DeleteBtn.IdleFillColor = System.Drawing.Color.White;
            this.DeleteBtn.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.DeleteBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteBtn.Location = new System.Drawing.Point(392, 465);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(160, 37);
            this.DeleteBtn.TabIndex = 34;
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBtn.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 40);
            this.panel1.TabIndex = 35;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // close
            // 
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(956, 11);
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
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Banker Functionalities";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Request_loan_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.installment_txtbox);
            this.panel2.Controls.Add(this.loan_amount_txtbox);
            this.panel2.Controls.Add(this.CardNo_txt);
            this.panel2.Location = new System.Drawing.Point(719, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 436);
            this.panel2.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(74, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 28);
            this.label6.TabIndex = 71;
            this.label6.Text = "Loan Section";
            // 
            // Request_loan_btn
            // 
            this.Request_loan_btn.ActiveBorderThickness = 1;
            this.Request_loan_btn.ActiveCornerRadius = 20;
            this.Request_loan_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Request_loan_btn.ActiveForecolor = System.Drawing.Color.White;
            this.Request_loan_btn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.Request_loan_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Request_loan_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Request_loan_btn.BackgroundImage")));
            this.Request_loan_btn.ButtonText = "Request Loan";
            this.Request_loan_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Request_loan_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Request_loan_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Request_loan_btn.IdleBorderThickness = 1;
            this.Request_loan_btn.IdleCornerRadius = 20;
            this.Request_loan_btn.IdleFillColor = System.Drawing.Color.White;
            this.Request_loan_btn.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.Request_loan_btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Request_loan_btn.Location = new System.Drawing.Point(43, 376);
            this.Request_loan_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Request_loan_btn.Name = "Request_loan_btn";
            this.Request_loan_btn.Size = new System.Drawing.Size(176, 37);
            this.Request_loan_btn.TabIndex = 70;
            this.Request_loan_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Request_loan_btn.Click += new System.EventHandler(this.Request_loan_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(15, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 64;
            this.label1.Text = "Installment Months";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(14, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 26);
            this.label4.TabIndex = 66;
            this.label4.Text = "Loan Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(14, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 68;
            this.label5.Text = "CardNo";
            // 
            // installment_txtbox
            // 
            this.installment_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.installment_txtbox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.installment_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.installment_txtbox.HintForeColor = System.Drawing.Color.Empty;
            this.installment_txtbox.HintText = "";
            this.installment_txtbox.isPassword = false;
            this.installment_txtbox.LineFocusedColor = System.Drawing.Color.DarkSlateGray;
            this.installment_txtbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.installment_txtbox.LineMouseHoverColor = System.Drawing.Color.DarkSlateGray;
            this.installment_txtbox.LineThickness = 3;
            this.installment_txtbox.Location = new System.Drawing.Point(20, 295);
            this.installment_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.installment_txtbox.Name = "installment_txtbox";
            this.installment_txtbox.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.installment_txtbox.Size = new System.Drawing.Size(223, 33);
            this.installment_txtbox.TabIndex = 69;
            this.installment_txtbox.Text = "Installment Months.";
            this.installment_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.installment_txtbox.Enter += new System.EventHandler(this.installment_txtbox_Enter);
            this.installment_txtbox.Leave += new System.EventHandler(this.installment_txtbox_Leave);
            // 
            // loan_amount_txtbox
            // 
            this.loan_amount_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loan_amount_txtbox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.loan_amount_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loan_amount_txtbox.HintForeColor = System.Drawing.Color.Empty;
            this.loan_amount_txtbox.HintText = "";
            this.loan_amount_txtbox.isPassword = false;
            this.loan_amount_txtbox.LineFocusedColor = System.Drawing.Color.DarkSlateGray;
            this.loan_amount_txtbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loan_amount_txtbox.LineMouseHoverColor = System.Drawing.Color.DarkSlateGray;
            this.loan_amount_txtbox.LineThickness = 3;
            this.loan_amount_txtbox.Location = new System.Drawing.Point(20, 200);
            this.loan_amount_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.loan_amount_txtbox.Name = "loan_amount_txtbox";
            this.loan_amount_txtbox.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.loan_amount_txtbox.Size = new System.Drawing.Size(223, 33);
            this.loan_amount_txtbox.TabIndex = 67;
            this.loan_amount_txtbox.Text = "Loan Amount.";
            this.loan_amount_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loan_amount_txtbox.Enter += new System.EventHandler(this.loan_amount_txtbox_Enter);
            this.loan_amount_txtbox.Leave += new System.EventHandler(this.loan_amount_txtbox_Leave);
            // 
            // CardNo_txt
            // 
            this.CardNo_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CardNo_txt.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.CardNo_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CardNo_txt.HintForeColor = System.Drawing.Color.Empty;
            this.CardNo_txt.HintText = "";
            this.CardNo_txt.isPassword = false;
            this.CardNo_txt.LineFocusedColor = System.Drawing.Color.DarkSlateGray;
            this.CardNo_txt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CardNo_txt.LineMouseHoverColor = System.Drawing.Color.DarkSlateGray;
            this.CardNo_txt.LineThickness = 3;
            this.CardNo_txt.Location = new System.Drawing.Point(20, 105);
            this.CardNo_txt.Margin = new System.Windows.Forms.Padding(4);
            this.CardNo_txt.Name = "CardNo_txt";
            this.CardNo_txt.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.CardNo_txt.Size = new System.Drawing.Size(223, 33);
            this.CardNo_txt.TabIndex = 65;
            this.CardNo_txt.Text = "CardNo.";
            this.CardNo_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CardNo_txt.Enter += new System.EventHandler(this.CardNo_txt_Enter);
            this.CardNo_txt.Leave += new System.EventHandler(this.CardNo_txt_Leave);
            // 
            // rdb_bankerInfo
            // 
            this.rdb_bankerInfo.AutoSize = true;
            this.rdb_bankerInfo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdb_bankerInfo.Location = new System.Drawing.Point(32, 94);
            this.rdb_bankerInfo.Name = "rdb_bankerInfo";
            this.rdb_bankerInfo.Size = new System.Drawing.Size(137, 21);
            this.rdb_bankerInfo.TabIndex = 60;
            this.rdb_bankerInfo.Text = "Banker information";
            this.rdb_bankerInfo.UseVisualStyleBackColor = true;
            // 
            // BankerFnsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(985, 507);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loadInformation);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.txt_ActorName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BankerFnsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankerFnForm";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ActorName;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.RadioButton rdo_cards;
        private System.Windows.Forms.RadioButton rdo_accounts;
        private System.Windows.Forms.RadioButton rdo_Clients;
        private Bunifu.Framework.UI.BunifuThinButton2 loadInformation;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 search;
        private Bunifu.Framework.UI.BunifuThinButton2 UpdateBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 Request_loan_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox installment_txtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox loan_amount_txtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CardNo_txt;
        private System.Windows.Forms.RadioButton rdb_bankerInfo;
    }
}