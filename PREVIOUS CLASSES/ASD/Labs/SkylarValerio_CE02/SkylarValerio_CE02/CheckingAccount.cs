using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkylarValerio_CE02
{
    class CheckingAccount
    {

        public decimal accBalance { get; set; }
        public int accNumber { get; set; }

        public CheckingAccount(int number, decimal balance)
        {

            accNumber = number;
            accBalance = balance;


        }


    }
}
