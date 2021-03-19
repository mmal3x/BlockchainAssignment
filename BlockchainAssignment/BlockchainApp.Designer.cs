namespace BlockchainAssignment
{
    partial class mainWindow
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printBlock = new System.Windows.Forms.Button();
            this.printOutput = new System.Windows.Forms.TextBox();
            this.generateWallet = new System.Windows.Forms.Button();
            this.publicKey = new System.Windows.Forms.TextBox();
            this.privateKey = new System.Windows.Forms.TextBox();
            this.publicKeyLabel = new System.Windows.Forms.Label();
            this.privateKeyLabel = new System.Windows.Forms.Label();
            this.validateKeys = new System.Windows.Forms.Button();
            this.createTransaction = new System.Windows.Forms.Button();
            this.newBlock = new System.Windows.Forms.Button();
            this.feeLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.fee = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.receiverLabel = new System.Windows.Forms.Label();
            this.receiver = new System.Windows.Forms.TextBox();
            this.readAll = new System.Windows.Forms.Button();
            this.readPending = new System.Windows.Forms.Button();
            this.validate = new System.Windows.Forms.Button();
            this.checkBalance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(15, 16);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(984, 482);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // printBlock
            // 
            this.printBlock.Location = new System.Drawing.Point(34, 545);
            this.printBlock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printBlock.Name = "printBlock";
            this.printBlock.Size = new System.Drawing.Size(104, 60);
            this.printBlock.TabIndex = 1;
            this.printBlock.Text = "Print Block";
            this.printBlock.UseVisualStyleBackColor = true;
            this.printBlock.Click += new System.EventHandler(this.printBlock_Click);
            // 
            // printOutput
            // 
            this.printOutput.Location = new System.Drawing.Point(155, 545);
            this.printOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printOutput.Name = "printOutput";
            this.printOutput.Size = new System.Drawing.Size(57, 26);
            this.printOutput.TabIndex = 2;
            // 
            // generateWallet
            // 
            this.generateWallet.Location = new System.Drawing.Point(520, 640);
            this.generateWallet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.generateWallet.Name = "generateWallet";
            this.generateWallet.Size = new System.Drawing.Size(127, 86);
            this.generateWallet.TabIndex = 3;
            this.generateWallet.Text = "Generate Wallet";
            this.generateWallet.UseVisualStyleBackColor = true;
            this.generateWallet.Click += new System.EventHandler(this.generateWallet_Click);
            // 
            // publicKey
            // 
            this.publicKey.Location = new System.Drawing.Point(755, 640);
            this.publicKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.publicKey.Name = "publicKey";
            this.publicKey.Size = new System.Drawing.Size(247, 26);
            this.publicKey.TabIndex = 4;
            // 
            // privateKey
            // 
            this.privateKey.Location = new System.Drawing.Point(755, 697);
            this.privateKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.privateKey.Name = "privateKey";
            this.privateKey.Size = new System.Drawing.Size(247, 26);
            this.privateKey.TabIndex = 5;
            // 
            // publicKeyLabel
            // 
            this.publicKeyLabel.AutoSize = true;
            this.publicKeyLabel.Location = new System.Drawing.Point(659, 640);
            this.publicKeyLabel.Name = "publicKeyLabel";
            this.publicKeyLabel.Size = new System.Drawing.Size(81, 20);
            this.publicKeyLabel.TabIndex = 6;
            this.publicKeyLabel.Text = "Public Key";
            // 
            // privateKeyLabel
            // 
            this.privateKeyLabel.AutoSize = true;
            this.privateKeyLabel.Location = new System.Drawing.Point(659, 703);
            this.privateKeyLabel.Name = "privateKeyLabel";
            this.privateKeyLabel.Size = new System.Drawing.Size(87, 20);
            this.privateKeyLabel.TabIndex = 7;
            this.privateKeyLabel.Text = "Private Key";
            // 
            // validateKeys
            // 
            this.validateKeys.Location = new System.Drawing.Point(692, 545);
            this.validateKeys.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.validateKeys.Name = "validateKeys";
            this.validateKeys.Size = new System.Drawing.Size(127, 38);
            this.validateKeys.TabIndex = 8;
            this.validateKeys.Text = "Validate Keys";
            this.validateKeys.UseVisualStyleBackColor = true;
            this.validateKeys.Click += new System.EventHandler(this.validateKeys_Click);
            // 
            // createTransaction
            // 
            this.createTransaction.Location = new System.Drawing.Point(24, 746);
            this.createTransaction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createTransaction.Name = "createTransaction";
            this.createTransaction.Size = new System.Drawing.Size(188, 61);
            this.createTransaction.TabIndex = 9;
            this.createTransaction.Text = "Create Transaction";
            this.createTransaction.UseVisualStyleBackColor = true;
            this.createTransaction.Click += new System.EventHandler(this.createTransaction_Click);
            // 
            // newBlock
            // 
            this.newBlock.Location = new System.Drawing.Point(24, 640);
            this.newBlock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newBlock.Name = "newBlock";
            this.newBlock.Size = new System.Drawing.Size(188, 55);
            this.newBlock.TabIndex = 10;
            this.newBlock.Text = "Generate Block";
            this.newBlock.UseVisualStyleBackColor = true;
            this.newBlock.Click += new System.EventHandler(this.newBlock_Click);
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Location = new System.Drawing.Point(241, 772);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(37, 20);
            this.feeLabel.TabIndex = 14;
            this.feeLabel.Text = "Fee";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(241, 746);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(65, 20);
            this.amountLabel.TabIndex = 13;
            this.amountLabel.Text = "Amount";
            // 
            // fee
            // 
            this.fee.Location = new System.Drawing.Point(325, 781);
            this.fee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(54, 26);
            this.fee.TabIndex = 12;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(325, 743);
            this.amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(54, 26);
            this.amount.TabIndex = 11;
            // 
            // receiverLabel
            // 
            this.receiverLabel.AutoSize = true;
            this.receiverLabel.Location = new System.Drawing.Point(555, 775);
            this.receiverLabel.Name = "receiverLabel";
            this.receiverLabel.Size = new System.Drawing.Size(101, 20);
            this.receiverLabel.TabIndex = 16;
            this.receiverLabel.Text = "Receiver Key";
            // 
            // receiver
            // 
            this.receiver.Location = new System.Drawing.Point(692, 769);
            this.receiver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(324, 26);
            this.receiver.TabIndex = 15;
            // 
            // readAll
            // 
            this.readAll.Location = new System.Drawing.Point(245, 545);
            this.readAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.readAll.Name = "readAll";
            this.readAll.Size = new System.Drawing.Size(106, 40);
            this.readAll.TabIndex = 17;
            this.readAll.Text = "Read All";
            this.readAll.UseVisualStyleBackColor = true;
            this.readAll.Click += new System.EventHandler(this.readAll_Click_1);
            // 
            // readPending
            // 
            this.readPending.Location = new System.Drawing.Point(243, 640);
            this.readPending.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.readPending.Name = "readPending";
            this.readPending.Size = new System.Drawing.Size(136, 58);
            this.readPending.TabIndex = 18;
            this.readPending.Text = "Read Pending Transactions";
            this.readPending.UseVisualStyleBackColor = true;
            this.readPending.Click += new System.EventHandler(this.readPending_Click);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(520, 545);
            this.validate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(127, 62);
            this.validate.TabIndex = 19;
            this.validate.Text = "Validate Blockchain";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.validate_Click);
            // 
            // checkBalance
            // 
            this.checkBalance.Location = new System.Drawing.Point(851, 546);
            this.checkBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBalance.Name = "checkBalance";
            this.checkBalance.Size = new System.Drawing.Size(128, 61);
            this.checkBalance.TabIndex = 20;
            this.checkBalance.Text = "Check Balance";
            this.checkBalance.UseVisualStyleBackColor = true;
            this.checkBalance.Click += new System.EventHandler(this.checkBalance_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1028, 859);
            this.Controls.Add(this.checkBalance);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.readPending);
            this.Controls.Add(this.readAll);
            this.Controls.Add(this.receiverLabel);
            this.Controls.Add(this.receiver);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.fee);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.newBlock);
            this.Controls.Add(this.createTransaction);
            this.Controls.Add(this.validateKeys);
            this.Controls.Add(this.privateKeyLabel);
            this.Controls.Add(this.publicKeyLabel);
            this.Controls.Add(this.privateKey);
            this.Controls.Add(this.publicKey);
            this.Controls.Add(this.generateWallet);
            this.Controls.Add(this.printOutput);
            this.Controls.Add(this.printBlock);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainWindow";
            this.Text = "Blockchain App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button printBlock;
        private System.Windows.Forms.TextBox printOutput;
        private System.Windows.Forms.Button generateWallet;
        private System.Windows.Forms.TextBox publicKey;
        private System.Windows.Forms.TextBox privateKey;
        private System.Windows.Forms.Label publicKeyLabel;
        private System.Windows.Forms.Label privateKeyLabel;
        private System.Windows.Forms.Button validateKeys;
        private System.Windows.Forms.Button createTransaction;
        private System.Windows.Forms.Button newBlock;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox fee;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label receiverLabel;
        private System.Windows.Forms.TextBox receiver;
        private System.Windows.Forms.Button readAll;
        private System.Windows.Forms.Button readPending;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Button checkBalance;
    }
}

