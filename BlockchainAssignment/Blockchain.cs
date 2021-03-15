﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Blockchain
    {
        // blocks are stored in the list
        public List<Block> Blocks = new List<Block>();
        int transactionsPerBlock = 5; // max transactions = 5
        // new Transaction object. 
        public List<Transaction> transactionPool = new List<Transaction>();



        // creating the constructor for the genesis block in blockchain.cs
        public Blockchain()
        {
            Blocks.Add(new Block());
        }


        // verifying the creation of the genesis block by displaying its variables 
        public String getBlockAsString(int index)
        {
            return Blocks[index].ToString();
        }

        // receivng the info of the previous block in a nice arrangement
        public Block GetLastBlock()
        {
            return Blocks[Blocks.Count - 1];
        }


        // reading off the transaction list per block as we instantiate them from the 
        // tranasaction pool. It returns the first N using the GetRange 
        public List<Transaction> getPendingTransactions()
        {
            int n = Math.Min(transactionsPerBlock, transactionPool.Count);
            List<Transaction> transactions = transactionPool.GetRange(0, n);
            transactionPool.RemoveRange(0, n);

            return transactions;
        }

        // here we check the hash to see it is equal to that which was
        // submitted before

        public bool ValidateHash(Block b)
        {
            String rehash = b.CreateHash(); // comparing created hash
            return rehash.Equals(b.hash); // with the existing hash 

        }

        // does the same as the function above but with transactions 
        // within the block
        public bool ValidateMerkleRoot(Block b)
        {
    
            String reMerkle = Block.MerkleRoot(b.transactionsList);
            return reMerkle.Equals(b.merkleRoot);
        }


        public double GetBalance(String address)
        {
            // need to make sure each block in the chain 
            // sum up each transaction link to and from and 
            // increase the balance (the crypto hash pointers are pointed
            // to one another)

            double balance = 0;
            foreach(Block b in Blocks)
            {
                foreach(Transaction t in b.transactionsList)
                {
                    if (t.recipientAddress.Equals(address))
                    {
                        balance += t.amount;
                    }
                    if (t.senderAddress.Equals(address))
                    {
                        balance -= (t.amount + t.fee);
                    }
                }
            }
            return balance;
        }
        // generating a list of the whole blockchan
        // all blocks are outputted into a string format,
        public override string ToString()
        {
            String output = String.Empty;
            Blocks.ForEach(b => output += (b.ToString() + "\n"));
            return output;
        }
    }
}