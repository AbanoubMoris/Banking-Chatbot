namespace ChatBotProject
{
    partial class ChatBotForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatBotForm));
            this.txtTyping = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InputTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bubble1 = new ChatBotProject.BubbleUC();
            this.menuButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleVoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewBankerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankerFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crystalReportViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.UserNameLBL = new System.Windows.Forms.Label();
            this.AccountTypelbl = new System.Windows.Forms.Label();
            this.CardNoLbl = new System.Windows.Forms.Label();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTyping
            // 
            this.txtTyping.AutoSize = true;
            this.txtTyping.Location = new System.Drawing.Point(4, 451);
            this.txtTyping.Name = "txtTyping";
            this.txtTyping.Size = new System.Drawing.Size(73, 13);
            this.txtTyping.TabIndex = 3;
            this.txtTyping.Text = "Bot is typing...";
            this.txtTyping.Visible = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 40);
            this.panel1.TabIndex = 4;
            // 
            // close
            // 
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(553, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 16);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ChatBot";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ChatBotProject.Properties.Resources.Diversity_Avatars_Avatars_Robot_02;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // InputTxt
            // 
            this.InputTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.InputTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InputTxt.HintForeColor = System.Drawing.Color.Empty;
            this.InputTxt.HintText = "";
            this.InputTxt.isPassword = false;
            this.InputTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InputTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.InputTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InputTxt.LineThickness = 3;
            this.InputTxt.Location = new System.Drawing.Point(51, 403);
            this.InputTxt.Margin = new System.Windows.Forms.Padding(4);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.Size = new System.Drawing.Size(473, 44);
            this.InputTxt.TabIndex = 5;
            this.InputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InputTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTxt_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageActive = null;
            this.button1.Location = new System.Drawing.Point(531, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 44);
            this.button1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.button1.Zoom = 10;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.bubble1);
            this.panel2.Location = new System.Drawing.Point(7, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 318);
            this.panel2.TabIndex = 7;
            // 
            // bubble1
            // 
            this.bubble1.AutoSize = true;
            this.bubble1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bubble1.BackColor = System.Drawing.Color.Silver;
            this.bubble1.Location = new System.Drawing.Point(9, 10);
            this.bubble1.Name = "bubble1";
            this.bubble1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bubble1.Size = new System.Drawing.Size(479, 94);
            this.bubble1.TabIndex = 3;
            this.bubble1.Visible = false;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImageActive = null;
            this.menuButton.Location = new System.Drawing.Point(7, 405);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(37, 44);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 8;
            this.menuButton.TabStop = false;
            this.menuButton.Zoom = 10;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearChatToolStripMenuItem,
            this.toggleVoiceToolStripMenuItem,
            this.registerNewBankerToolStripMenuItem,
            this.registerNewClientToolStripMenuItem,
            this.bankerInformationToolStripMenuItem,
            this.bankerFunctionsToolStripMenuItem,
            this.crystalReportViewToolStripMenuItem,
            this.clientInformationToolStripMenuItem,
            this.switchAccountsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 202);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // clearChatToolStripMenuItem
            // 
            this.clearChatToolStripMenuItem.Name = "clearChatToolStripMenuItem";
            this.clearChatToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.clearChatToolStripMenuItem.Text = "Clear Chat";
            this.clearChatToolStripMenuItem.Click += new System.EventHandler(this.clearChatToolStripMenuItem_Click);
            // 
            // toggleVoiceToolStripMenuItem
            // 
            this.toggleVoiceToolStripMenuItem.CheckOnClick = true;
            this.toggleVoiceToolStripMenuItem.Name = "toggleVoiceToolStripMenuItem";
            this.toggleVoiceToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.toggleVoiceToolStripMenuItem.Text = "Bot Voice";
            this.toggleVoiceToolStripMenuItem.Click += new System.EventHandler(this.toggleVoiceToolStripMenuItem_Click);
            // 
            // registerNewBankerToolStripMenuItem
            // 
            this.registerNewBankerToolStripMenuItem.Name = "registerNewBankerToolStripMenuItem";
            this.registerNewBankerToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.registerNewBankerToolStripMenuItem.Text = "Register New Banker";
            this.registerNewBankerToolStripMenuItem.Click += new System.EventHandler(this.registerNewBankerToolStripMenuItem_Click);
            // 
            // registerNewClientToolStripMenuItem
            // 
            this.registerNewClientToolStripMenuItem.Name = "registerNewClientToolStripMenuItem";
            this.registerNewClientToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.registerNewClientToolStripMenuItem.Text = "Register New Client";
            this.registerNewClientToolStripMenuItem.Click += new System.EventHandler(this.registerNewClientToolStripMenuItem_Click);
            // 
            // bankerInformationToolStripMenuItem
            // 
            this.bankerInformationToolStripMenuItem.Name = "bankerInformationToolStripMenuItem";
            this.bankerInformationToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.bankerInformationToolStripMenuItem.Text = "Banker Information";
            this.bankerInformationToolStripMenuItem.Click += new System.EventHandler(this.bankerInformationToolStripMenuItem_Click);
            // 
            // bankerFunctionsToolStripMenuItem
            // 
            this.bankerFunctionsToolStripMenuItem.Name = "bankerFunctionsToolStripMenuItem";
            this.bankerFunctionsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.bankerFunctionsToolStripMenuItem.Text = "Banker Functions";
            this.bankerFunctionsToolStripMenuItem.Click += new System.EventHandler(this.bankerFunctionsToolStripMenuItem_Click);
            // 
            // crystalReportViewToolStripMenuItem
            // 
            this.crystalReportViewToolStripMenuItem.Name = "crystalReportViewToolStripMenuItem";
            this.crystalReportViewToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.crystalReportViewToolStripMenuItem.Text = "Crystal Report Viewer";
            this.crystalReportViewToolStripMenuItem.Click += new System.EventHandler(this.crystalReportViewToolStripMenuItem_Click);
            // 
            // clientInformationToolStripMenuItem
            // 
            this.clientInformationToolStripMenuItem.Name = "clientInformationToolStripMenuItem";
            this.clientInformationToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.clientInformationToolStripMenuItem.Text = "Account Information";
            this.clientInformationToolStripMenuItem.Click += new System.EventHandler(this.clientInformationToolStripMenuItem_Click);
            // 
            // switchAccountsToolStripMenuItem
            // 
            this.switchAccountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.switchAccountsToolStripMenuItem.Name = "switchAccountsToolStripMenuItem";
            this.switchAccountsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.switchAccountsToolStripMenuItem.Text = "Switch Accounts";
            this.switchAccountsToolStripMenuItem.Click += new System.EventHandler(this.switchAccountsToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // UserNameLBL
            // 
            this.UserNameLBL.AutoSize = true;
            this.UserNameLBL.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLBL.Location = new System.Drawing.Point(12, 53);
            this.UserNameLBL.Name = "UserNameLBL";
            this.UserNameLBL.Size = new System.Drawing.Size(48, 19);
            this.UserNameLBL.TabIndex = 9;
            this.UserNameLBL.Text = "Name :";
            // 
            // AccountTypelbl
            // 
            this.AccountTypelbl.AutoSize = true;
            this.AccountTypelbl.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTypelbl.Location = new System.Drawing.Point(198, 53);
            this.AccountTypelbl.Name = "AccountTypelbl";
            this.AccountTypelbl.Size = new System.Drawing.Size(89, 19);
            this.AccountTypelbl.TabIndex = 10;
            this.AccountTypelbl.Text = "AccountType :";
            // 
            // CardNoLbl
            // 
            this.CardNoLbl.AutoSize = true;
            this.CardNoLbl.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNoLbl.Location = new System.Drawing.Point(411, 53);
            this.CardNoLbl.Name = "CardNoLbl";
            this.CardNoLbl.Size = new System.Drawing.Size(62, 19);
            this.CardNoLbl.TabIndex = 13;
            this.CardNoLbl.Text = "Card No :";
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(117, 46);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(229, 26);
            this.welcomeLbl.TabIndex = 14;
            this.welcomeLbl.Text = "Welcome Banker Account :  ";
            this.welcomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChatBotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 471);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.CardNoLbl);
            this.Controls.Add(this.AccountTypelbl);
            this.Controls.Add(this.UserNameLBL);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTyping);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChatBotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatBot";
            this.Load += new System.EventHandler(this.ChatBotForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtTyping;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox InputTxt;
        private Bunifu.Framework.UI.BunifuImageButton button1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private BubbleUC bubble1;
        private Bunifu.Framework.UI.BunifuImageButton menuButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleVoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerNewBankerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankerFunctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Label CardNoLbl;
        private System.Windows.Forms.Label AccountTypelbl;
        private System.Windows.Forms.Label UserNameLBL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.ToolStripMenuItem crystalReportViewToolStripMenuItem;
    }
}

