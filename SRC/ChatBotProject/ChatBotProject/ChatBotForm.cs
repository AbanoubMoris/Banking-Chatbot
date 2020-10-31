using System;
using System.Windows.Forms;
using System.Media;
using System.IO; // needed for filing
using System.Speech.Synthesis;
using System.Collections.Generic;

namespace ChatBotProject
{

    public partial class ChatBotForm : Form
    {
        long User_NId;
        string User_name;

        TransactionsDB trans;
        Dictionary<string, int> accountType = new Dictionary<string, int>();

        Dictionary<int, int> accounts;
        int CurrentAcc;
        
        public ChatBotForm(long id,long CardNo , string name)
        {
            this.User_name = name;
            InitializeComponent();
            accounts = new Dictionary<int, int>();
            trans = new TransactionsDB();
            User_NId = id;
            this.CardNo = Convert.ToInt32(CardNo);
            welcomeLbl.Text += User_name;
            welcomeLbl.Visible = true;
            crystalReportViewToolStripMenuItem.Visible = true;
            UserNameLBL.Visible = false;
            AccountTypelbl.Visible = false;
            CardNoLbl.Visible = false;
            switchAccountsToolStripMenuItem.Visible = false;
            clientInformationToolStripMenuItem.Visible = false;
            if (this.CardNo != 0)
            {
                foreach (var acc1 in trans.GetClientAccounts(this.CardNo))
                {
                    try
                    {
                        accountType.Add(acc1.Value, acc1.Key);

                    }
                    catch (Exception)
                    {
                    }
                    accounts.Add(acc1.Key, 0);
                    toolStripComboBox1.Items.Add(acc1.Value);
                }
                Initialization(this.CardNo);
            }

        }
        private void Initialization(int CardNo)
        {
            this.CardNo = CardNo;
            CurrentAcc = trans.GetAccountFROMCARDNo(CardNo);
            accounts[trans.GetAccountFROMCARDNo(CardNo)] = 1; //current opened account is validated
           // toolStripComboBox1.Items.Add(CurrentAcc);
            trans.GetClientAccounts(CardNo);

            updateChatIFNO(User_name, trans.AccountDetials[CurrentAcc][2]
                ,Convert.ToString(this.CardNo));

        }
        private void updateChatIFNO(string userName,string AccountType,string CardNo)
        {
            UserNameLBL.Visible = true;
            AccountTypelbl.Visible = true;
            CardNoLbl.Visible = true;
            welcomeLbl.Visible = false;
            UserNameLBL.Text = "Name : ";
            AccountTypelbl.Text = "Type : ";
            CardNoLbl.Text = "CardNo : ";

            UserNameLBL.Text += userName;
            AccountTypelbl.Text += AccountType;
            CardNoLbl.Text += CardNo;

            switchAccountsToolStripMenuItem.Visible = true;
            clientInformationToolStripMenuItem.Visible = true;
            registerNewBankerToolStripMenuItem.Visible = false;
            registerNewClientToolStripMenuItem.Visible = false;
            bankerFunctionsToolStripMenuItem.Visible = false;
            bankerInformationToolStripMenuItem.Visible = false;
            crystalReportViewToolStripMenuItem.Visible = false;
            
        }

        static ChatBot bot;
        SpeechSynthesizer reader = new SpeechSynthesizer();
        bool textToSpeech = false;

        int processNo = 0;
        int pin, CardNo;

        string outtt = "";
        string type = "";

        private void ChatBotForm_Load(object sender, EventArgs e)
        {
            bot = new ChatBot();

            // Sets Position for the first bubble on the top
            bbl_old.Top = 0 - bbl_old.Height;

            // Load Chat from the log file
            if (File.Exists("chat.log"))
            {
                using (StreamReader sr = File.OpenText("chat.log"))
                {
                    int i = 0; // to count lines
                    while (sr.Peek() >= 0) // loop till the file ends
                    {
                        if (i % 2 == 0) // check if line is even
                        {
                            addInMessage(sr.ReadLine());
                        }
                        else
                        {
                            addOutMessage(sr.ReadLine());
                        }
                        i++;
                    }
                    // scroll to the bottom once finished loading.
                    panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;
                    panel2.PerformLayout();
                }
            }
        }
        char banker = 'x';
        char checkIfRegistered() //values 'x' if client yet 'y' if banker
        {
            if (this.CardNo == 0) return banker = 'y';
            return 'x';
        }
        void TransactionProcess()
        {
            if (processNo == 0) outtt = bot.getOutput(InputTxt.Text);

            else if (processNo == 1) { CardNo = Convert.ToInt32(InputTxt.Text); trans.GetClientAccounts(CardNo); processNo = 2; outtt = bot.getOutput("PinNo"); }
            else if (processNo == 2)
            { //enter account id
                pin = Convert.ToInt32(InputTxt.Text);
                if (trans.GetCardInfo(CardNo, pin))
                {
                    outtt = bot.getOutput("TransType");
                    processNo = 3;
                }
                else
                {
                    outtt = "Wrong Account ID or Pin !";
                    //   outtt = "IsRegistered.";
                    processNo = 0;
                }
            }
            else if (processNo == 3)
            {
                outtt = bot.getOutput(InputTxt.Text);
                if (outtt == "D.") type = "Deposit";
                else type = "Withdraw";

                outtt = bot.getOutput("DoTrans " + outtt[0]);
                processNo = 4;
            }
            else if (processNo == 4)
            {
                int amount = Convert.ToInt32(InputTxt.Text);
                int ret = trans.makeTransaction(type, amount);
                if (ret == -1) outtt = "you can't withdraw more than your balance !";
                else
                {
                    outtt = "Transaction Done ! your new balance is : " + Convert.ToString(ret);
                    processNo = 0;
                }
            }
            // Store the Bot's Output by giving it our input.
            // string  = "HELLO";
            if (outtt == "IsRegistered.")
            {
                checkIfRegistered();
                outtt = bot.getOutput("BankerIs " + banker);
                if (banker != 'x')
                    processNo = 1;

            }
        }
        private void showOutput()
        {
            if (!(string.IsNullOrWhiteSpace(InputTxt.Text))) // Make sure the textbox isnt empty
            {
                SoundPlayer Send = new SoundPlayer("SOUND1.wav"); // Send Sound Effect
                SoundPlayer Rcv = new SoundPlayer("SOUND2.wav"); // Recieve Sound Effect

                // Show the user message and play the sound
                addInMessage(InputTxt.Text);
                Send.Play();


                TransactionProcess();
                // Store the Bot's Output by giving it our input.
                //string outtt = bot.getOutput(InputTxt.Text);

                if (outtt.Length == 0)
                {
                    outtt = "I don't understand.";
                }

                //=========== Creates backup of chat from user and bot to the given location ============
                FileStream fs = new FileStream(@"chat.log", FileMode.Append, FileAccess.Write);
                if (fs.CanWrite)
                {
                    byte[] write = System.Text.Encoding.ASCII.GetBytes(InputTxt.Text + Environment.NewLine + outtt + Environment.NewLine);
                    fs.Write(write, 0, write.Length);
                }
                fs.Flush();
                fs.Close();
                //=======================================================================================

                // Make a Dynamic Timer to delay the bot's response to make it feel humanlike.
                var t = new Timer();
                
                // Time in milseconds - minimum delay of 1s plus 0.1s per character.
                t.Interval = 1000 + (outtt.Length * 100);

                // Show the "Bot is typing.." text
                txtTyping.Show();

                // disable the chat box white the bot is typing to prevent user spam.
                InputTxt.Enabled = false;

                t.Tick += (s, d) =>
                {
                    // Once the timer ends

                    InputTxt.Enabled = true; // Enable Chat box

                    // Hide the "Bot is typing.." text
                    txtTyping.Hide();

                    // Show the bot message and play the sound
                    addOutMessage(outtt);
                    Rcv.Play();

                    // Text to Speech if enabled
                    if (textToSpeech)
                    {
                        reader.SpeakAsync(outtt);
                    }
                    
                    InputTxt.Focus(); // Put the cursor back on the textbox
                    t.Stop();
                };
                t.Start(); // Start Timer

                InputTxt.Text = ""; // Reset textbox
            }
        }

        // Call the Output method when the send button is clicked.
        private void button1_Click(object sender, EventArgs e)
        {
            showOutput();
        }

        // Call the Output method when the enter key is pressed.
       
        private void InputTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showOutput();
                e.SuppressKeyPress = true; // Disable windows error sound
            }
        }
        
        
        // Dummy Bubble created to store the previous bubble data.
        BubbleUC bbl_old = new BubbleUC();

        // User Message Bubble Creation
        public void addInMessage(string message)
        {
            // Create new chat bubble
            BubbleUC bbl = new BubbleUC(message, msgtype.In);
            bbl.Location = bubble1.Location; // Set the new bubble location from the bubble sample.
            bbl.Left += 50; // Indent the bubble to the right side.
            bbl.Size = bubble1.Size; // Set the new bubble size from the bubble sample.
            bbl.Top = bbl_old.Bottom + 10; // Position the bubble below the previous one with some extra space.
            
            // Add the new bubble to the panel.
            panel2.Controls.Add(bbl);

            // Force Scroll to the latest bubble
            bbl.Focus();

            // save the last added object to the dummy bubble
            bbl_old = bbl;
        }

        // Bot Message Bubble Creation
        public void addOutMessage(string message)
        {
            // Create new chat bubble
            BubbleUC bbl = new BubbleUC(message, msgtype.Out);
            bbl.Location = bubble1.Location; // Set the new bubble location from the bubble sample.
            bbl.Size = bubble1.Size; // Set the new bubble size from the bubble sample.
            bbl.Top = bbl_old.Bottom + 10; // Position the bubble below the previous one with some extra space.
            
            // Add the new bubble to the panel.
            panel2.Controls.Add(bbl);

            // Force Scroll to the latest bubble
            bbl.Focus();

            // save the last added object to the dummy bubble
            bbl_old = bbl;
        }

        // Custom close button to close the program when clicked.
        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        
        // Clear all the bubbles and chat.log
        private void clearChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Delete the log file
            File.Delete(@"chat.log");

            // Clear the chat Bubbles
            panel2.Controls.Clear();

            // This reset the position for the next bubble to come back to the top.
            bbl_old.Top = 0 - bbl_old.Height;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(menuButton, new System.Drawing.Point(0, -contextMenuStrip1.Size.Height));
        }

        private void toggleVoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // whenever the toggle is clicked, true is set to false visa versa.
            textToSpeech = !textToSpeech;
        }

        private void registerNewBankerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankerRegisterForm br = new BankerRegisterForm();
            br.Show();
        }

        private void registerNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientRegisterForm cr = new ClientRegisterForm(User_NId);
            cr.Show();
        }

        private void bankerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankerInfoForm bi = new BankerInfoForm(User_NId);
            bi.Show();
        }

        private void clientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientInfoForm bi = new ClientInfoForm(this.CardNo);
            bi.Show();
        }

        private void switchAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // trans.GetClientAccounts();
        }


        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = toolStripComboBox1.SelectedItem.ToString();

            // ValidateClient vc = new ValidateClient(User_name, User_NId);

            if (accountType[key] == CurrentAcc)
            {
                MessageBox.Show("You are already opening this account");
            }
            else
            {
                if (accounts[accountType[key]] == 0) // not valid
                {
                    ValidateAccountForm vc = new ValidateAccountForm(User_name, User_NId, true);
                    vc.Show();
                    this.CardNo = accountType[key];
                }
                else
                {
                    this.CardNo = trans.getCardFromAccountID(accountType[key]);
                    
                }
                Initialization(trans.getCardFromAccountID(accountType[key]));
            }
        }

        private void crystalReportViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrystalReportForm cr = new CrystalReportForm();
            cr.Show();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void bankerFunctionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankerFnsForm bf = new BankerFnsForm();
            bf.Show();
        }
    }
}