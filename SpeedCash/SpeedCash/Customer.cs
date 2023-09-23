using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCash
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public BankAccount Account { get; set; }

        public Customer(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }

        
   }
    }

