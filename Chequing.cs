// Chequing.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01
{
    /** -* Class Comment *-
     *  NAME : Chequing
     *  PURPOSE : This class is responsible for creating chequing object which is inherited by account
     *            
     *  -- Method --
     *  name                    contents
     *  Chequing()              A default constructor
     *  Chequing()              A constructor which can instantiate class 
     *  GetApplyRate()          Print value which is applied Annual fee
     */
    internal class Chequing : Account
    {
        /** -- Method Header Comment --
         *  Name    : Chequing -- default constructor
         *  Purpose : To instantiate a new Chequing object
         *  Input   : none
         *  Output  : none
         *  Return  : none
         */
        public Chequing()
        {
            AccountNumber = "";
            CurrentBalance = 0;
            Rate = 0;
        }

        /** -- Method Header Comment --
         *  Name    : Chequing -- constructor
         *  Purpose : To instantiate a new chequing object
         *            In this case the rate is the annual fee
         *  Input   : string        AccountNumber       An account number which gets from user
         *            double        CurrentBalance      A current balance from user - in this case, it is cheque
         *            double        Rate                An annual fee from user
         *  Output  : Print some phrases when user input negative value in CurrentBalance or Annual fee
         *  Return  : none
         */
        public Chequing(string AccountNumber, double CurrentBalance, double Rate) : base( AccountNumber, CurrentBalance, Rate)
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
                Console.WriteLine("the Annual fee can not be negative");
            }
            else
            {
                this.Rate = Rate;
            }
        }

        /** -- Method Header Comment --
        *  Name    : GetApplyRate
        *  Purpose : Use this method when user wants to get current balance applied annual fee
        *  Input   : none
        *  Output  : Print a message which current balance applied annual fee
        *  Return  : none
        */
        public override void GetApplyRate()
        {
            CurrentBalance += Rate;
            Console.WriteLine("Apply annual fee : ${0}", CurrentBalance);
        }
        
    }
}
