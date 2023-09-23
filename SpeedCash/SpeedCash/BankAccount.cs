using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCash
{
   public class BankAccount
    {
       
       public string CustomerName { get; set; }
       public string Email { get; set; }
       public string AccountNo { get; set; }
       public string OpeningDate { get; set; }

        private double balance = 300;
        
        public double Balance
        {
            get{ return balance; }
        }

        public BankAccount(string accountno, string openingdate)
        {
            this.AccountNo = accountno;
            this.OpeningDate =  openingdate;
        }

        public bool Deposit (double amount)
        {
            balance += amount;
            return true;
        }
     public bool WithDraw (double amount)
        {
            balance -= amount;
            return true;
        }

    }
}
