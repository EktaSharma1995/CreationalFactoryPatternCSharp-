using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalFactoryPattern
{
    interface IBank
    {
        void checkingAccount();
        void generateAccountNumber();
        void getInitialBalance();
        void savingAccount();
        void loanAccount();
    }
}
