using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalFactoryPattern
{
    class CitiBank : IBank
    {
        private string accountNumber;
        private int initialAccountBalance;

        public CitiBank()
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
            Console.WriteLine("This is a Checking Account in Citi bank");
        }

        public void savingAccount()
        {
            Console.WriteLine("This is a Saving Account in Citi Bank");
        }

        public void loanAccount()
        {
            Console.WriteLine("Loan account is not allowed in Citi Bank");
        }

        public void generateAccountNumber()
        {
            Random r = new Random();
            this.accountNumber = "CITI" + r.Next(1, 100);
        }

        public void getInitialBalance()
        {
            this.initialAccountBalance = 5000;
        }

        public override string ToString()
        {
            return "Account Number: " + accountNumber + ", " + "Initial Balance:" + InitialAccountBalance;
        }
    }
}
