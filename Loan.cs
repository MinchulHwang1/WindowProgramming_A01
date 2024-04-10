// Loan.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01
{
    /** -* Class Comment *-
     *  NAME : Loan
     *  PURPOSE : This class is responsible for creating loan object which is inherited by account
     *            
     *  -- Method --
     *  name                    contents
     *  Loan()                  A default constructor
     *  Loan()                  A constructor which can instantiate class 
     *  DepositTrans()          Print calculated Deposit Transaction value
     *  WithdrawTrans()         Print calculated withdraw transaction value
     *  GetInfo()               Print account informantion
     */
    internal class Loan : Account
    {
        double ApplyLoanInterestForAnnual;      // To save loan which is applied annual interest
        double ApplyLoanToDeposit;              // To save a value which is applied deposit 
        double ApplyLoanToWithdraw;             // To save a value which is applied withdraw

        /** -- Method Header Comment --
         *  Name    : Loan -- default constructor
         *  Purpose : To instantiate a new Loan object
         *  Input   : none
         *  Output  : none
         *  Return  : none
         */
        public Loan()
        {
            AccountNumber = "";
            CurrentBalance = 0;
            Rate = 0;
        }

        /** -- Method Header Comment --
         *  Name    : Loan -- constructor
         *  Purpose : To instantiate a new Loan object
         *  Input   : string        AccountNumber       An account number which gets from user
         *            double        CurrentBalance      A current balance from user - in this case it is loan
         *            double        Rate                A Loan Rate from user
         *  Output  : Print some phrases when user input negative value in CurrentBalance or Rate
         *  Return  : none
         */
        public Loan(string AccountNumber, double CurrentBalance, double Rate) : base(AccountNumber, CurrentBalance, Rate)
        {
            this.AccountNumber = AccountNumber;

            this.CurrentBalance = CurrentBalance;
            

            if (Rate < 0)
            {
                Console.WriteLine("the Interest Rate can not be negative");
            }
            else
            {
                this.Rate = Rate;
            }

            ApplyLoanInterestForAnnual = CurrentBalance + (CurrentBalance * Rate) ;
            ApplyLoanToDeposit = 0;
            ApplyLoanToWithdraw = 0;
        }

        /** -- Method Header Comment --
         *  Name    : DepositTrans
         *  Purpose : Use this method when user wants to put money into deposit
         *            if the deposit amount is lager then loan,
         *            current balance which is loan is getting big.
         *            and if the deposit amount is smaller than loan,
         *            current balance is calculated as take away from loan.
         *  Input   : MomeyAmount       double      A money amount which user wants to out to balance
         *  Output  : Print a message current balance and apply interest loan
         *  Return  : none
         */
        public override void DepositTrans(double MoneyAmount)
        {

            if (CurrentBalance >= MoneyAmount)
            {
                CurrentBalance -= MoneyAmount;
                ApplyLoanInterestForAnnual = CurrentBalance + (CurrentBalance * Rate);
                Console.WriteLine("Current Loan Balance : ${0}", CurrentBalance);
                Console.WriteLine("Apply interest rate to loan  : ${0}", ApplyLoanInterestForAnnual);
            }
            else
            {
                ApplyLoanToDeposit = MoneyAmount - CurrentBalance;
                CurrentBalance = 0;
                ApplyLoanInterestForAnnual = ApplyLoanToDeposit + (ApplyLoanToDeposit * Rate);
                Console.WriteLine("Current Loan Balance : ${0}", ApplyLoanToDeposit);
                Console.WriteLine("Apply interest rate to Loan : ${0}", ApplyLoanInterestForAnnual);
                CurrentBalance = ApplyLoanToDeposit;
            }
        }

        /** -- Method Header Comment --
         *  Name    : DepositTrans
         *  Purpose : Use this method when user wants to take away money into current balance
         *  Input   : MomeyAmount       double      A money amount which user wants to take away to balance
         *  Output  : Print a message current balance and apply interest loan
         *  Return  : none
         */
        public override void WithdrawTrans(double MoneyAmount)
        {
            ApplyLoanToWithdraw = CurrentBalance + MoneyAmount;
            ApplyLoanInterestForAnnual = ApplyLoanToWithdraw + (ApplyLoanToWithdraw * Rate);
            Console.WriteLine("Current Loan Balance : ${0}", ApplyLoanToWithdraw);
            Console.WriteLine("Apply interest rate to Loan : ${0}", ApplyLoanInterestForAnnual);
            CurrentBalance = ApplyLoanToWithdraw;
        }

        /** -- Method Header Comment --
         *  Name    : GetInfo
         *  Purpose : Use this method when user wants to get current balance, account number, and applied interest rate
         *  Input   : none
         *  Output  : Print a message which current balance, account number and applied interest rate.
         *  Return  : none
         */
        public override void GetInfo()
        {
            Console.WriteLine("Account Number : {0}", AccountNumber);
            Console.WriteLine("Current Loan Balance : ${0}", CurrentBalance);
            Console.WriteLine("Apply interest rate to loan : ${0}", ApplyLoanInterestForAnnual);
        }
    }
}
