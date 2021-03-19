using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Block
    {
        // attributes for the block 
        public int index; // position of the block in the sequence of block of a blockhain
        DateTime timeStamp; // time of creation 
        public String hash; // pointer to the previous block.
        public String prevHash; // current blocks "identity"

        public String merkleRoot; // hash of all transactions


        // enables the creation of more than one transaction 
        public List<Transaction> transactionsList = new List<Transaction>(); 

        // the nonce is a central part of the proof of work and mining
        // algorithm for blockchains. it is an random no. used just once.
        public long nonce = 0;
        public long extraNonce = 0; // extra nonce needed for threading

        // associated w/ of 0s that would be placed before the string
        // reaches the block hash that is being submitted can start.
        // no. of 0s means a higher degree of difficult. It means you have
        // met the degree of diff. The miner will continue hashing using the
        // nonce untill the no. of zeros preceding reach DoD.
        // **note: an extra nonce is used in threading

        public int difficulty = 4; // no. of zeros to precede hash value


        // rewards are fixed, but the fees are not 
        public double reward = 2.0; // the fixed reward from CB for mining a transaction
        public double fees = 0.0; // counter for summing the transaction fees
        public String minerAddress = String.Empty; // public key address of miner


        /*Genesis block constructor to initialise the blockchain*/ //***
        public Block()
        {
            timeStamp = DateTime.Now;
            index = 0;
            prevHash = String.Empty;
            reward = 0;
            this.merkleRoot = String.Empty;
            hash = Mine();
        }


        // constructor for the hash & index ***
        // of the prev. block
        // create a new block w/ a set of transactions from the blockchain
        // extracted from the transaction pool
        public Block(Block lastBlock, List<Transaction> transactions, String minerAddress)
        {
            timeStamp = DateTime.Now;
            index = lastBlock.index + 1;
            prevHash = lastBlock.hash;

            // this is the wallet to be credited all the fees accrued 
            // and the rewards due for the mining effort
            this.minerAddress = minerAddress;
            transactions.Add(createRewardTransaction(transactions));
            transactionsList = transactions;

            // // initialising the merkle root and passing it a string of transactions
            this.merkleRoot = MerkleRoot(transactionsList); 

            // / calling the old createHash w/ the new elements 
            // and constructs added to be hashed
            hash = Mine(); 

        }

        // method that creates the hash & can be 
        // instantiated to create a block
        // hashing is an important authentication mechanism
        public String CreateHash()
        {
            String hash = String.Empty;

            SHA256 hasher = SHA256Managed.Create();

            // concat all properties w/ nonce as to generate a new hash
            String input = index.ToString() + timeStamp.ToString() + prevHash + nonce.ToString() + merkleRoot;


            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            // convert hash from byte array to string
            foreach(byte x in hashByte)
            {
                hash += String.Format("{0:x2}", x);
            }
            return hash;
        }
        
        // The mine function executes the create hash function. 
        // createHash = gives user a hash which satisfies the difficulty
        // for proof of work.
        public String Mine()
        {
            String hash = CreateHash();

            String re = new string('0', difficulty);


            while (!hash.StartsWith(re))
            {
                nonce++; // increment the nonce should the difficult level not be satisfied
                hash = CreateHash(); // rehash the new nonce as to generate a different hash
            }

            return hash; 
        }


        // the coinbase decides what the reward should be.
        // we create a reward for incentivisiing the mining of a block.
        // every transaction has a fee. 
        public Transaction createRewardTransaction(List<Transaction> transactions)
        {
            // all trasactions are summed together together
            fees = transactions.Aggregate(0.0, (acc, t) => acc + t.fee);
            return new Transaction("Mine Rewards,", minerAddress, (reward + fees), 0, "");

        }

        public static String MerkleRoot(List<Transaction> transactionsList)
        {

            List<String> hashes = transactionsList.Select(t => t.hash).ToList();

            if(hashes.Count == 0)
            {
                return String.Empty;
            }
            if(hashes.Count ==1)
            {
                return HashCode.HashTools.combineHash(hashes[0], hashes[0]);           
            }

            // for two or more transactions run the folllowing 
            while(hashes.Count != 1)
            {

                List<String> merkleLeaves = new List<String>();
                for(int i = 0; i < hashes.Count; i += 2)
                {
                    if(i == hashes.Count - 1)
                    {
                        // when there is one independent hash combine with self. 
                        merkleLeaves.Add(HashCode.HashTools.combineHash(hashes[i], hashes[i]));

                    }
                    else
                    {
                        // combines the adjecent leaves when there is no one independent
                        // hash, co
                        merkleLeaves.Add(HashCode.HashTools.combineHash(hashes[i], hashes[i + 1]));

                    }
                }
                hashes = merkleLeaves;
            }
            return hashes[0]; // combining the adjacent leaves until the leaves until there is only one leaf - the merkle root 
        }


        // *** this function combines every property into a string.
        // it outputs all the block info to the screen via the 
        // readAll button 
        public override string ToString()
        {
            // string rep of all transaction in the block
            String transactions = String.Join("\n", transactionsList);

            return "Index: " + index.ToString()
                + "\tTimeStamp: " + timeStamp.ToString()
                + "\nPrevious Hash: " + prevHash
                + "\nHash: " + hash
                + "\nMerkle Root: " + merkleRoot
                + "\nNonce: " + nonce  // x-tra nonce needs to be added for threading
                + "\nDifficulty Level: " + difficulty
                + "\nReward: " + reward
                + "\nTransactions:\n" + transactions;
        }

        // + "\nMiners Address: " + minerAddress
        // + "\nFees: " + fees
    }
}
