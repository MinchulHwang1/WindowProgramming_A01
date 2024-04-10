// TestProgram.cs 
/** 
 * This is a TestProgram cs's comment
 *  name        : TestProgram.cs\
 *  PURPOSE     : This program was developed from a banking program.
 *                The parent class is the Account class, and there are Saving, Chequing, and Loan classes that inherit it.
 *                Each class has methods required for each class, and the corresponding functions are sufficient.
 *                Additionally, this program is oriented as a console app program and provides the corresponding functions.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace A01
{
    internal class TestProgram
    {
        static void Main(string[] args)
        {
            // create saving objuct and act Saving class.
            // the Parameters are Account number, current saving balance, and interest rate.
            Console.WriteLine("For Saving");
            Saving save = new Saving("8818858", 200, 0.3);
            
            save.GetInfo();
            
            save.GetApplyRate();
            save.DepositTrans(200);
            save.WithdrawTrans(300);
            save.GetInfo();
           
            
            // create Chequing objuct and act Chequing class.
            // the Parameters are Account number, current chequing balance, and annual fee.
            
            Console.WriteLine("For Chequing");
            Chequing cheque = new Chequing("8818858", 350, 100);
            cheque.GetInfo();
            cheque.GetApplyRate();
            cheque.DepositTrans(200);
            cheque.WithdrawTrans(300);
            cheque.GetInfo();
            
            
            
            // create loan objuct and act Loan class.
            // the Parameters are Account number, current loan balance, and interest rate for annual.
            Console.WriteLine("For Loan");
            
            Loan loan1 = new Loan("8818858", 5000, 0.25);

            
            loan1.GetInfo();
            loan1.GetApplyRate();
            loan1.DepositTrans(200);
            loan1.WithdrawTrans(300);
            loan1.GetInfo();
            
            Console.ReadLine();
            
        }
    }
}
