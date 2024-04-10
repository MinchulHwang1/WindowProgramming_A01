// Account.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01
{

    //current balance, account number, rate는 private로 선언한 다음 accessor, mutator로 저장하는 걸로 하는것으로 변경

    // 적용 된 값을 current로 저장하지 말고 다른 값으로 저장하는 것으로 바꿔야 조금 더 명확한 길로 될것이다.
    /** -* Class Comment *-
     *  NAME : Account
     *  PURPOSE : This class is responsible for creating a basic Account object.
     *            and also this class inherits methods and data members to it's child classes.
     *  -- Method --
     *  name                    contents
     *  Account()               A default constructor
     *  Account()               A constructor which can instantiate class 
     *  GetAccountNumber()      Send AccountNumber value
     *  GetCurrentBalance()     Send CurrentBalance value
     *  GetRateOrFee()          Send Rate of annual fee value
     *  DepositTrans()          Print calculated Deposit Transaction value
     *  WithdrawTrans()         Print calculated withdraw transaction value
     *  GetApplyRate()          Print value which is applied rate value
     *  GetInfo()               Print account informantion
     */

    internal class Account
    {
        public string AccountNumber;    // To save account number from user 
        public double CurrentBalance;   // to save current balance from user
        public double Rate;             // To save rate from user


        /** -- Method Header Comment --
         *  Name    : Account -- default constructor
         *  Purpose : To instantiate a new Account object
         *  Input   : none
         *  Output  : none
         *  Return  : none
         */
        public Account()
        {
            AccountNumber = "";
            CurrentBalance = 0;
            Rate = 0;
        }

        /** -- Method Header Comment --
         *  Name    : Account -- constructor
         *  Purpose : To instantiate a new Account object
         *  Input   : string        AccountNumber       An account number which gets from user
         *            double        CurrentBalance      A current balance from user
         *            double        Rate                A Rate from user
         *  Output  : Print some phrases when user input negative value in CurrentBalance or Rate
         *  Return  : none
         */
        public Account(string AccountNumber, double CurrentBalance, double Rate)
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


        /** -- Method Header Comment --
         *  Name    : GetAccountNumber
         *  Purpose : Use this method to get account number
         *  Input   : none
         *  Output  : none
         *  Return  : AccountNumber     string      an account number
         */
        public string GetAccountNumber()
        {
            return AccountNumber;
        }

        /** -- Method Header Comment --
         *  Name    : GetCurrentBalance
         *  Purpose : Use this method to get current balance
         *  Input   : none
         *  Output  : none
         *  Return  : CurrentBalance     string      current balance
         */
        virtual public double GetCurrentBalance() 
        {
            return CurrentBalance; 
        }

        /** -- Method Header Comment --
         *  Name    : GetRateOrFee
         *  Purpose : Use this method to get rate or fee
         *  Input   : none
         *  Output  : none
         *  Return  : Rate     double      rate
         */
        virtual public double GetRateOrFee()
        {
            return Rate;
        }

        /** -- Method Header Comment --
         *  Name    : DepositTrans
         *  Purpose : Use this method when user wants to put money into current balance
         *  Input   : MomeyAmount       double      A money amount which user wants to out to balance
         *  Output  : Print a message when user inputs negative value on deposit or applied deposit to current balance
         *  Return  : none
         */
        virtual public void DepositTrans(double MoneyAmount)
        {
            if (MoneyAmount < 0)
            {
                Console.WriteLine("Deposit cannot be negative");
            }
            else
            {
                CurrentBalance += MoneyAmount;
                Console.WriteLine("Apply Deposit is : ${0}", CurrentBalance);
            }
        }

        /** -- Method Header Comment --
         *  Name    : DepositTrans
         *  Purpose : Use this method when user wants to take away money into current balance
         *  Input   : MomeyAmount       double      A money amount which user wants to takw away to balance
         *  Output  : Print a message when user inputs negative value on deposit or applied deposit to current balance
         *  Return  : none
         */
        virtual public void WithdrawTrans(double MoneyAmount)
        {
            if (MoneyAmount > CurrentBalance)
            {
                Console.WriteLine("Withdraw money cannot be bigger than current balance");
            }
            else
            {
                CurrentBalance -= MoneyAmount;
                Console.WriteLine("Left Money after withdraw : ${0}", CurrentBalance);
            }
        }

        /** -- Method Header Comment --
         *  Name    : GetApplyRate
         *  Purpose : Use this method when user wants to get current balance applied interest rate
         *  Input   : none
         *  Output  : Print a message which current balance applied interest rate
         *  Return  : none
         */
        virtual public void GetApplyRate()
        {
            CurrentBalance += (CurrentBalance * Rate);
            Console.WriteLine("Apply interest rate is : ${0}", CurrentBalance);
        }

        /** -- Method Header Comment --
         *  Name    : GetInfo
         *  Purpose : Use this method when user wants to get current balance and account number
         *  Input   : none
         *  Output  : Print a message which current balance and account number
         *  Return  : none
         */
        virtual public void GetInfo()
        {
            if (CurrentBalance >= 0)
            {
                Console.WriteLine("Account Number : {0}", AccountNumber);
                Console.WriteLine("Current Balance : ${0}", CurrentBalance);
            }
            else
            {
                Console.WriteLine( "Current Balance can not be negative\n");
            }
        }
    }
}
