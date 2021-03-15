using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Transaction
    {
        // attributes for transaction 
        public String hash;
        String signature;
        public String senderAddress;
        public String recipientAddress;
        public double fee;
        public double amount;
        DateTime timeStamp;

       
        
        public Transaction(String from, String to, double amount, double fee, String privateKey)
        {
            this.timeStamp = DateTime.Now; // time the transaction is created. 
            this.senderAddress = from; 
            this.hash = CreateHash();
            this.recipientAddress = to;
            this.amount = amount;
            this.fee = fee;

            this.signature = Wallet.Wallet.CreateSignature(from, privateKey, this.hash);

        }

        // lifted from Block.cs
        public String CreateHash()
        {
            String hash = String.Empty;
            // hash all properties
            SHA256 hasher = SHA256Managed.Create();
            String input = timeStamp.ToString() + senderAddress + recipientAddress + amount.ToString() + fee.ToString();


            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            // convert hash from byte array to string
            foreach (byte x in hashByte)
            {
                hash += String.Format("{0:x2}", x);
            }
            return hash;

        }

        // iban code equivalent called the transaction structure.
        public override string ToString()
        {
            return "Transaction Hash: " + hash + "\n" + 
                "\nDigital Signature: " + signature + "\n"
                + "\nTimestamp: " + timeStamp.ToString() + "\n"
                + "\nAmount Transferred: " + amount.ToString() + "AssignmentCoin\n" 
                + "\nSender Address: "+ senderAddress + "\n"
                + "\nReceiver Address: " + recipientAddress + "\n"
                + "\nFees: " + fee.ToString() + "\n";

        }
    }
}
