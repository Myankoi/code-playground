using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _5_Account_Bank
{
    public class Account
    {
        private string id, name;
        private int balance = 0;

        public Account(string id, string name, int balance = 0)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }

        public string getID()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }


        public int getBalance()
        {
            return balance;
        }

        public int credit(int amount)
        {
            balance -= amount;
            return balance;
        }

        public int debit(int amount)
        {
            if(amount <= balance)
            {
                balance += amount;
            } else
            {
                Console.WriteLine("Amount excedeed balance");
            }
            return balance;
        }
        public int transferTo(Account anotherAcc, int amount)
        {
            if (amount <= balance)
            {
                credit(amount);
                anotherAcc.debit(amount);
                Console.WriteLine($"Transfer sebesar: {amount} ke rekening {anotherAcc.name} Sukses...\n" +
                    $"Saldo {name} sebelumnya: {balance} --> {credit(amount)}");

            }
            else
            {
                Console.WriteLine("Amount excedeed balance");
            }
            return balance;
        }

        public string toString()
        {
            return $"Account[id={id}, name={name}, balance={balance}]";
        }
    }
}
