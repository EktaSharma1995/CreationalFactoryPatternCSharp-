using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalFactoryPattern
{
    class Program
    {
        //NationalBank nb = new NationalBank();
        //CitiBank cb = new CitiBank();
        //public void returnAskedAccount(string choice)
        //{
        //    if (choice.Equals("LOAN"))
        //    {
        //        nb.loanAccount();
        //    }

        //    else if (choice.Equals("SAVING"))
        //    {
        //        cb.savingAccount();
        //    }
        //}

        static void Main(string[] args)
        {
            
            Creator c = new Creator();
            
            IBank forCitiBank = c.FactoryMethod("CITI");
            Console.WriteLine("City Bank");
            Console.WriteLine(forCitiBank.ToString());

            forCitiBank.checkingAccount();
            forCitiBank.savingAccount();
            forCitiBank.loanAccount();

            Console.WriteLine("");
            IBank forNationalBank = c.FactoryMethod("NATIONAL");
            Console.WriteLine("National Bank");
            Console.WriteLine(forNationalBank.ToString());

            forNationalBank.checkingAccount();
            forNationalBank.loanAccount();
            forNationalBank.savingAccount();
            
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
