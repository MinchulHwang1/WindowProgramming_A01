// Saving.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01
{
    /** -* Class Comment *-
     *  NAME : Saving - inherited by Account.cs
     *  PURPOSE : This class is responsible for creating saving object which is inherited by account 
     *  -- Method --
     *  name                   contents
     *  Saving()               A default constructor
     *  Saving()               A constructor which can instantiate class 
     */
    internal class Saving : Account
    {
        /** -- Method Header Comment --
         *  Name    : Saving -- default constructor
         *  Purpose : To instantiate a new Saving object
         *  Input   : none
         *  Output  : none
         *  Return  : none
         */
        public Saving() : base()
        {
            AccountNumber = "";
            CurrentBalance = 0;
            Rate = 0;
        }

        /** -- Method Header Comment --
         *  Name    : Saving -- constructor
         *  Purpose : To instantiate a new Saving object
         *  Input   : string        AccountNumber       An account number which gets from user
         *            double        CurrentBalance      A current balance from user - in this case it is save
         *            double        Rate                A Rate from user
         *  Output  : Print some phrases when user input negative value in CurrentBalance or interest Rate
         *  Return  : none
         */
        public Saving(string AccountNumber, double CurrentBalance, double Rate) : base(AccountNumber, CurrentBalance, Rate)
        {
            this.AccountNumber = AccountNumber;

            if (CurrentBalance < 0)
            {
                Console.WriteLine("Current Balance can not be negative");
                CurrentBalance = 0;
            }
            else
            {
                this.CurrentBalance = CurrentBalance;
            }

            if (Rate < 0)
            {
                Console.WriteLine("the Interest Rate can not be negative");
            }
            else
            {
                this.Rate = Rate;
            }
        }



    }
}
