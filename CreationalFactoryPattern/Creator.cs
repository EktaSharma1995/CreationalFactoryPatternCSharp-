using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalFactoryPattern
{
    class Creator
    {
        public IBank FactoryMethod(string choice)
        {
            if(choice == null)
            {
                return null;
            }

            if (choice.Equals("CITI"))
            {
                return new CitiBank();
            }

            else {
                return new NationalBank();
            }
        }
    }
}
