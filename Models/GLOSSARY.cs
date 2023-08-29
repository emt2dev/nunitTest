using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunitTest.Models
{
    internal class GLOSSARY
    {
        // Defaults
        public static int SimulatedIdOne = 101;
        public static int SimulatedIdTwo = 202;

        public static int Zed = 0;
        public static double ZedMoney = 0.00;
        public static Boolean IsTrue = true;
        public static Boolean IsFalse = false;

        // Branch Model
        public static string CustomerEmail = "user@user.com";
        public static string BankTellerName = "Mr. Bank Teller";
        public static string BranchName = "Downtown";
        public static string Address = "123 Main St, Virgina Beach, VA 23452";
        public static string AtmAddress = "Exterior of: 123 Main St, Virgina Beach, VA 23452";

        // Bank Account Model
        public static double StartingBalance = 100.00;
        public static double WithdrawlBalancePositive = 50.00;
        public static double WithdrawlBalanceNegative = 101.00;
        public static double DepositBalancePositive = 50.00;

        // Transaction Model
        public static int DebitCardNumber = 1234567890;        
    }
}
