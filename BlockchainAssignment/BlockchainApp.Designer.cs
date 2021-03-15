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
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(875, 386);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // printBlock
            // 
            this.printBlock.Location = new System.Drawing.Point(28, 420);
            this.printBlock.Name = "printBlock";
            this.printBlock.Size = new System.Drawing.Size(92, 48);
            this.printBlock.TabIndex = 1;
            this.printBlock.Text = "Print";
            this.printBlock.UseVisualStyleBackColor = true;
            this.printBlock.Click += new System.EventHandler(this.printBlock_Click);
            // 
            // printOutput
            // 
            this.printOutput.Location = new System.Drawing.Point(126, 426);
            this.printOutput.Name = "printOutput";
            this.printOutput.Size = new System.Drawing.Size(51, 22);
            this.printOutput.TabIndex = 2;
            // 
            // generateWallet
            // 
            this.generateWallet.Location = new System.Drawing.Point(778, 410);
            this.generateWallet.Name = "generateWallet";
            this.generateWallet.Size = new System.Drawing.Size(113, 69);
            this.generateWallet.TabIndex = 3;
            this.generateWallet.Text = "Generate Wallet";
            this.generateWallet.UseVisualStyleBackColor = true;
            this.generateWallet.Click += new System.EventHandler(this.generateWallet_Click);
            // 
            // publicKey
            // 
            this.publicKey.Location = new System.Drawing.Point(547, 420);
            this.publicKey.Name = "publicKey";
            this.publicKey.Size = new System.Drawing.Size(220, 22);
            this.publicKey.TabIndex = 4;
            // 
            // privateKey
            // 
            this.privateKey.Location = new System.Drawing.Point(547, 455);
            this.privateKey.Name = "privateKey";
            this.privateKey.Size = new System.Drawing.Size(220, 22);
            this.privateKey.TabIndex = 5;
            // 
            // publicKeyLabel
            // 
            this.publicKeyLabel.AutoSize = true;
            this.publicKeyLabel.Location = new System.Drawing.Point(467, 426);
            this.publicKeyLabel.Name = "publicKeyLabel";
            this.publicKeyLabel.Size = new System.Drawing.Size(74, 17);
            this.publicKeyLabel.TabIndex = 6;
            this.publicKeyLabel.Text = "Public Key";
            // 
            // privateKeyLabel
            // 
            this.privateKeyLabel.AutoSize = true;
            this.privateKeyLabel.Location = new System.Drawing.Point(462, 458);
            this.privateKeyLabel.Name = "privateKeyLabel";
            this.privateKeyLabel.Size = new System.Drawing.Size(80, 17);
            this.privateKeyLabel.TabIndex = 7;
            this.privateKeyLabel.Text = "Private Key";
            // 
            // validateKeys
            // 
            this.validateKeys.Location = new System.Drawing.Point(778, 485);
            this.validateKeys.Name = "validateKeys";
            this.validateKeys.Size = new System.Drawing.Size(113, 30);
            this.validateKeys.TabIndex = 8;
            this.validateKeys.Text = "Validate Keys";
            this.validateKeys.UseVisualStyleBackColor = true;
            this.validateKeys.Click += new System.EventHandler(this.validateKeys_Click);
            // 
            // createTransaction
            // 
            this.createTransaction.Location = new System.Drawing.Point(21, 585);
            this.createTransaction.Name = "createTransaction";
            this.createTransaction.Size = new System.Drawing.Size(167, 49);
            this.createTransaction.TabIndex = 9;
            this.createTransaction.Text = "Create Transaction";
            this.createTransaction.UseVisualStyleBackColor = true;
            this.createTransaction.Click += new System.EventHandler(this.createTransaction_Click);
            // 
            // newBlock
            // 
            this.newBlock.Location = new System.Drawing.Point(21, 512);
            this.newBlock.Name = "newBlock";
            this.newBlock.Size = new System.Drawing.Size(167, 44);
            this.newBlock.TabIndex = 10;
            this.newBlock.Text = "Generate Block";
            this.newBlock.UseVisualStyleBackColor = true;
            this.newBlock.Click += new System.EventHandler(this.newBlock_Click);
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Location = new System.Drawing.Point(214, 614);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(32, 17);
            this.feeLabel.TabIndex = 14;
            this.feeLabel.Text = "Fee";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(214, 582);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(56, 17);
            this.amountLabel.TabIndex = 13;
            this.amountLabel.Text = "Amount";
            // 
            // fee
            // 
            this.fee.Location = new System.Drawing.Point(289, 612);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(48, 22);
            this.fee.TabIndex = 12;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(289, 580);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(48, 22);
            this.amount.TabIndex = 11;
            // 
            // receiverLabel
            // 
            this.receiverLabel.AutoSize = true;
            this.receiverLabel.Location = new System.Drawing.Point(495, 618);
            this.receiverLabel.Name = "receiverLabel";
            this.receiverLabel.Size = new System.Drawing.Size(92, 17);
            this.receiverLabel.TabIndex = 16;
            this.receiverLabel.Text = "Receiver Key";
            // 
            // receiver
            // 
            this.receiver.Location = new System.Drawing.Point(600, 614);
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(288, 22);
            this.receiver.TabIndex = 15;
            // 
            // readAll
            // 
            this.readAll.Location = new System.Drawing.Point(183, 426);
            this.readAll.Name = "readAll";
            this.readAll.Size = new System.Drawing.Size(94, 32);
            this.readAll.TabIndex = 17;
            this.readAll.Text = "Read All";
            this.readAll.UseVisualStyleBackColor = true;
            this.readAll.Click += new System.EventHandler(this.readAll_Click_1);
            // 
            // readPending
            // 
            this.readPending.Location = new System.Drawing.Point(216, 512);
            this.readPending.Name = "readPending";
            this.readPending.Size = new System.Drawing.Size(121, 46);
            this.readPending.TabIndex = 18;
            this.readPending.Text = "Read Pending Transactions";
            this.readPending.UseVisualStyleBackColor = true;
            this.readPending.Click += new System.EventHandler(this.readPending_Click);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(775, 548);
            this.validate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(113, 50);
            this.validate.TabIndex = 19;
            this.validate.Text = "Full Blockchain Validation";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.validate_Click);
            // 
            // checkBalance
            // 
            this.checkBalance.Location = new System.Drawing.Point(642, 548);
            this.checkBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBalance.Name = "checkBalance";
            this.checkBalance.Size = new System.Drawing.Size(114, 49);
            this.checkBalance.TabIndex = 20;
            this.checkBalance.Text = "Check Balance";
            this.checkBalance.UseVisualStyleBackColor = true;
            this.checkBalance.Click += new System.EventHandler(this.checkBalance_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 687);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

