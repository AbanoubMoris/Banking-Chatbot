namespace ChatBotProject
{
    partial class ClientInfoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientInfoForm));
            this.DataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.view_client_data_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.view_trans_month_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.view_card_data_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.view_account_data_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.DoubleBuffered = true;
            this.DataGridView.EnableHeadersVisualStyles = false;
            this.DataGridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridView.Location = new System.Drawing.Point(205, 61);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView.Size = new System.Drawing.Size(601, 304);
            this.DataGridView.TabIndex = 53;
            // 
            // view_client_data_btn
            // 
            this.view_client_data_btn.ActiveBorderThickness = 1;
            this.view_client_data_btn.ActiveCornerRadius = 20;
            this.view_client_data_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.view_client_data_btn.ActiveForecolor = System.Drawing.Color.White;
            this.view_client_data_btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.view_client_data_btn.BackColor = System.Drawing.SystemColors.Control;
            this.view_client_data_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("view_client_data_btn.BackgroundImage")));
            this.view_client_data_btn.ButtonText = "View Client Data";
            this.view_client_data_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_client_data_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_client_data_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.view_client_data_btn.IdleBorderThickness = 1;
            this.view_client_data_btn.IdleCornerRadius = 20;
            this.view_client_data_btn.IdleFillColor = System.Drawing.Color.White;
            this.view_client_data_btn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.view_client_data_btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.view_client_data_btn.Location = new System.Drawing.Point(12, 64);
            this.view_client_data_btn.Margin = new System.Windows.Forms.Padding(5);
            this.view_client_data_btn.Name = "view_client_data_btn";
            this.view_client_data_btn.Size = new System.Drawing.Size(178, 43);
            this.view_client_data_btn.TabIndex = 54;
            this.view_client_data_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.view_client_data_btn.Click += new System.EventHandler(this.view_client_data_btn_Click);
            // 
            // view_trans_month_btn
            // 
            this.view_trans_month_btn.ActiveBorderThickness = 1;
            this.view_trans_month_btn.ActiveCornerRadius = 20;
            this.view_trans_month_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.view_trans_month_btn.ActiveForecolor = System.Drawing.Color.White;
            this.view_trans_month_btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.view_trans_month_btn.BackColor = System.Drawing.SystemColors.Control;
            this.view_trans_month_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("view_trans_month_btn.BackgroundImage")));
            this.view_trans_month_btn.ButtonText = "View Transaction Per Month";
            this.view_trans_month_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_trans_month_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_trans_month_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.view_trans_month_btn.IdleBorderThickness = 1;
            this.view_trans_month_btn.IdleCornerRadius = 20;
            this.view_trans_month_btn.IdleFillColor = System.Drawing.Color.White;
            this.view_trans_month_btn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.view_trans_month_btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.view_trans_month_btn.Location = new System.Drawing.Point(12, 297);
            this.view_trans_month_btn.Margin = new System.Windows.Forms.Padding(5);
            this.view_trans_month_btn.Name = "view_trans_month_btn";
            this.view_trans_month_btn.Size = new System.Drawing.Size(182, 52);
            this.view_trans_month_btn.TabIndex = 55;
            this.view_trans_month_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.view_trans_month_btn.Click += new System.EventHandler(this.view_trans_month_btn_Click);
            // 
            // view_card_data_btn
            // 
            this.view_card_data_btn.ActiveBorderThickness = 1;
            this.view_card_data_btn.ActiveCornerRadius = 20;
            this.view_card_data_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.view_card_data_btn.ActiveForecolor = System.Drawing.Color.White;
            this.view_card_data_btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.view_card_data_btn.BackColor = System.Drawing.SystemColors.Control;
            this.view_card_data_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("view_card_data_btn.BackgroundImage")));
            this.view_card_data_btn.ButtonText = "View Card Data";
            this.view_card_data_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_card_data_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_card_data_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.view_card_data_btn.IdleBorderThickness = 1;
            this.view_card_data_btn.IdleCornerRadius = 20;
            this.view_card_data_btn.IdleFillColor = System.Drawing.Color.White;
            this.view_card_data_btn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.view_card_data_btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.view_card_data_btn.Location = new System.Drawing.Point(13, 219);
            this.view_card_data_btn.Margin = new System.Windows.Forms.Padding(5);
            this.view_card_data_btn.Name = "view_card_data_btn";
            this.view_card_data_btn.Size = new System.Drawing.Size(181, 41);
            this.view_card_data_btn.TabIndex = 56;
            this.view_card_data_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.view_card_data_btn.Click += new System.EventHandler(this.view_card_data_btn_Click);
            // 
            // view_account_data_btn
            // 
            this.view_account_data_btn.ActiveBorderThickness = 1;
            this.view_account_data_btn.ActiveCornerRadius = 20;
            this.view_account_data_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.view_account_data_btn.ActiveForecolor = System.Drawing.Color.White;
            this.view_account_data_btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.view_account_data_btn.BackColor = System.Drawing.SystemColors.Control;
            this.view_account_data_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("view_account_data_btn.BackgroundImage")));
            this.view_account_data_btn.ButtonText = "View Account Data";
            this.view_account_data_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_account_data_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_account_data_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.view_account_data_btn.IdleBorderThickness = 1;
            this.view_account_data_btn.IdleCornerRadius = 20;
            this.view_account_data_btn.IdleFillColor = System.Drawing.Color.White;
            this.view_account_data_btn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.view_account_data_btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.view_account_data_btn.Location = new System.Drawing.Point(12, 142);
            this.view_account_data_btn.Margin = new System.Windows.Forms.Padding(5);
            this.view_account_data_btn.Name = "view_account_data_btn";
            this.view_account_data_btn.Size = new System.Drawing.Size(178, 41);
            this.view_account_data_btn.TabIndex = 57;
            this.view_account_data_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.view_account_data_btn.Click += new System.EventHandler(this.view_account_data_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 40);
            this.panel1.TabIndex = 58;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // close
            // 
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(787, 12);
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
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Showing Information";
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
            // ClientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.view_account_data_btn);
            this.Controls.Add(this.view_card_data_btn);
            this.Controls.Add(this.view_trans_month_btn);
            this.Controls.Add(this.view_client_data_btn);
            this.Controls.Add(this.DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientInfoForm";
            this.Text = "ClientInfo";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridView;
        private Bunifu.Framework.UI.BunifuThinButton2 view_client_data_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 view_trans_month_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 view_card_data_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 view_account_data_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}