using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalFactoryPattern
{
    class NationalBank : IBank
    {
        private string accountNumber;
        private int initialAccountBalance;

        public NationalBank()
        {
            generateAccountNumber();
            getInitialBalance();
        }

        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }

            set
            {
                accountNumber = value;
            }
        }

        public int InitialAccountBalance
        {
            get
            {
                return initialAccountBalance;
            }

            set
            {
                initialAccountBalance = value;
            }
        }


        public void checkingAccount()
        {
            Console.WriteLine("This is a checking account in National bank");
        }

        public void savingAccount()
        {
            Console.WriteLine("Saving account is not allowed in National Bank");
        }
        

        public void loanAccount()
        {
            Console.WriteLine("This is a loan account in National Bank");
        }

        public void generateAccountNumber()
        {
            Random r = new Random();
            this.accountNumber = "NATIONAL" + r.Next(1, 100);
        }

        public void getInitialBalance()
        {
            this.initialAccountBalance = 2000;
        }

        public override string ToString()
        {
            return "Account Number: " +accountNumber + ", " + "Initial Balance: " + InitialAccountBalance ;
        }
    }
}

