using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockchainAssignment
{
    public partial class mainWindow : Form
    {
        // initialising the blockchain

        Blockchain blockchain;
        public mainWindow()
        {
            InitializeComponent();
            blockchain = new Blockchain(); // initialising the blockchain
            richTextBox1.Text = "New Blockchain Initialised.";
        }


        // print button which gets the string of the block 
        // and places it on the screen

        private void printBlock_Click(object sender, EventArgs e)
        {

            int index = 0;
            if (Int32.TryParse(printOutput.Text, out index))
            {
                // getting the info to print from the mini text box to the
                // actual screen. 
                richTextBox1.Text = blockchain.blockToString(index);
            }
        }

        // generating the private-public key-pairs to form the account's identity.
        // an asymmetric encryption algorithm is used to generate the key-pairs. 
        private void generateWallet_Click(object sender, EventArgs e)
        {
            String privKey;
            Wallet.Wallet myNewWallet = new Wallet.Wallet(out privKey);
            publicKey.Text = myNewWallet.publicID;
            privateKey.Text = privKey;

        }


        private void validateKeys_Click(object sender, EventArgs e)
        {
            if (Wallet.Wallet.ValidatePrivateKey(privateKey.Text, publicKey.Text))
            {
                richTextBox1.Text = "Keys are valid";
            }
            else
            {
                richTextBox1.Text = "Invalid keys";
            }
        }

        // creating a transaction and adding it to the transaxction pool
        private void createTransaction_Click(object sender, EventArgs e)
        {// error: input string was not in a correct format
            Transaction transaction = new Transaction(publicKey.Text, receiver.Text, Double.Parse(amount.Text), Double.Parse(fee.Text), privateKey.Text);
            blockchain.transactionPool.Add(transaction);
            richTextBox1.Text = transaction.ToString();
        }



        private void newBlock_Click(object sender, EventArgs e)
        {
            // transactions to be included within the new block.
            List<Transaction> transactions = blockchain.getPendingTransactions();

            // Create the new block w/ the transactions from the pool
            Block newBlock = new Block(blockchain.getPrevBlock(), transactions, publicKey.Text);

            // the block w/ transactions is added to the blockchain
            blockchain.Blocks.Add(newBlock);

            // the blockchain is printed to the UI. 
            richTextBox1.Text = blockchain.ToString();
        }

        private void readAll_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = blockchain.ToString();
        }

        private void readPending_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = String.Join("\n", blockchain.transactionPool);
        }


        // function to check that sure the blockchain is valid 
        // It checks that the hash chain is consistent throughout
        // the blockchain. 
        private void validate_Click(object sender, EventArgs e)
        {
            if (blockchain.Blocks.Count == 1)
            {
                if (blockchain.validateMerkleRoot(blockchain.Blocks[0]))
                {
                    richTextBox1.Text = "Valid Blockchain";
                }
                else
                {
                    richTextBox1.Text = "Invalid Blockchain: Merkle Root";
                }

                return;
            }
            else
            {
                for (int i = 1; i < blockchain.Blocks.Count - 1; i++)
                {

                    if (blockchain.Blocks[i].prevHash != blockchain.Blocks[i - 1].hash || // hash line check
                        !blockchain.validateMerkleRoot(blockchain.Blocks[i]) || // merkle root check
                        !blockchain.validateHash(blockchain.Blocks[i])) //hash check
                    {
                        richTextBox1.Text = "Invalid Blockchain";
                        return;
                    }
                }
            }
            richTextBox1.Text = "Valid Blockchain";


        }

        private void checkBalance_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = blockchain.getBalance(publicKey.Text).ToString() + " Assignment ";
        }
    }
}
