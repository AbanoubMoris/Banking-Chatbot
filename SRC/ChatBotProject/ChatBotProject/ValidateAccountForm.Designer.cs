namespace ChatBotProject
{
    partial class ValidateAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidateAccountForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cardno_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pin_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ValidateBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(33, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 33);
            this.label1.TabIndex = 35;
            this.label1.Text = "Card PIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(28, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 33);
            this.label2.TabIndex = 36;
            this.label2.Text = "Card Number";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 40);
            this.panel1.TabIndex = 37;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // close
            // 
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(552, 12);
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
            this.label3.Location = new System.Drawing.Point(43, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Validate Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ChatBotProject.Properties.Resources.Diversity_Avatars_Avatars_Robot_02;
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(153, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 33);
            this.label4.TabIndex = 38;
            this.label4.Text = "Welcome ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(105, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(367, 33);
            this.label5.TabIndex = 39;
            this.label5.Text = "You Have To Validate Account First.";
            // 
            // cardno_txtbox
            // 
            this.cardno_txtbox.BorderColorFocused = System.Drawing.Color.DarkSlateGray;
            this.cardno_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cardno_txtbox.BorderColorMouseHover = System.Drawing.Color.DarkSlateGray;
            this.cardno_txtbox.BorderThickness = 3;
            this.cardno_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cardno_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cardno_txtbox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cardno_txtbox.isPassword = false;
            this.cardno_txtbox.Location = new System.Drawing.Point(183, 183);
            this.cardno_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.cardno_txtbox.Name = "cardno_txtbox";
            this.cardno_txtbox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cardno_txtbox.Size = new System.Drawing.Size(346, 44);
            this.cardno_txtbox.TabIndex = 40;
            this.cardno_txtbox.Text = "Enter Your Card No.";
            this.cardno_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cardno_txtbox.Enter += new System.EventHandler(this.cardno_txtbox_Enter);
            this.cardno_txtbox.Leave += new System.EventHandler(this.cardno_txtbox_Leave);
            // 
            // pin_txtbox
            // 
            this.pin_txtbox.BorderColorFocused = System.Drawing.Color.DarkSlateGray;
            this.pin_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pin_txtbox.BorderColorMouseHover = System.Drawing.Color.DarkSlateGray;
            this.pin_txtbox.BorderThickness = 3;
            this.pin_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pin_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pin_txtbox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.pin_txtbox.isPassword = false;
            this.pin_txtbox.Location = new System.Drawing.Point(183, 258);
            this.pin_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.pin_txtbox.Name = "pin_txtbox";
            this.pin_txtbox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pin_txtbox.Size = new System.Drawing.Size(346, 44);
            this.pin_txtbox.TabIndex = 41;
            this.pin_txtbox.Text = "Enter Your PIN.";
            this.pin_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pin_txtbox.OnValueChanged += new System.EventHandler(this.pin_txtbox_OnValueChanged);
            this.pin_txtbox.Enter += new System.EventHandler(this.pin_txtbox_Enter);
            this.pin_txtbox.Leave += new System.EventHandler(this.pin_txtbox_Leave);
            // 
            // ValidateBtn
            // 
            this.ValidateBtn.ActiveBorderThickness = 1;
            this.ValidateBtn.ActiveCornerRadius = 20;
            this.ValidateBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ValidateBtn.ActiveForecolor = System.Drawing.Color.White;
            this.ValidateBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ValidateBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ValidateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ValidateBtn.BackgroundImage")));
            this.ValidateBtn.ButtonText = "Validate";
            this.ValidateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ValidateBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidateBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ValidateBtn.IdleBorderThickness = 1;
            this.ValidateBtn.IdleCornerRadius = 20;
            this.ValidateBtn.IdleFillColor = System.Drawing.Color.White;
            this.ValidateBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ValidateBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ValidateBtn.Location = new System.Drawing.Point(198, 365);
            this.ValidateBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ValidateBtn.Name = "ValidateBtn";
            this.ValidateBtn.Size = new System.Drawing.Size(181, 41);
            this.ValidateBtn.TabIndex = 42;
            this.ValidateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ValidateBtn.Click += new System.EventHandler(this.ValidateBtn_Click);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(538, 271);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 43;
            this.bunifuCheckbox1.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // ValidateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 471);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.ValidateBtn);
            this.Controls.Add(this.pin_txtbox);
            this.Controls.Add(this.cardno_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ValidateAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ValidateClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ValidateClient_FormClosing);
            this.Load += new System.EventHandler(this.ValidateClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox cardno_txtbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox pin_txtbox;
        private Bunifu.Framework.UI.BunifuThinButton2 ValidateBtn;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
    }
}