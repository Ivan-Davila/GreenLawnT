using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawnTree.Clases
{
    class DatosCustomer { 
        string FirstName, LastName, Address, Mail;
        int Phone, PriceFirm;

        public string FirstName_p
        {
            set { FirstName = value; }
        }

        public string LastName_p
        {
            set { LastName = value; }
        }

        public string Address_p
        {
            set { Address = value; }
        }

        public string Mail_p
        {
            set { Mail = value; }
        }

        public int Phone_p
        {
            set { Phone = value; }
        }

        public int PriceFirm_p
        {
            set { PriceFirm = value; }
        }


    }
}
