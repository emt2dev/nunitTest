using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nunitTest.Models;

namespace nunitTest.Interfaces
{
    internal interface IMethods
    {
        // Bank Teller
        public TellerModel GetTeller(string EID);

        // Transactions
        public BranchModel GetBranch(int BranchId);
        public BankAccountModel GetAccountDetailsFromCard(int CardNumber);
        public BankAccountModel GetAccountDetailsFromEmail(string Email);
        public bool TransactionASuccess(double RequestAmount, double AccountAmount, bool IsWithdraw);
        public void UpdateAccount(BankAccountModel Account, TransactionModel Transaction);
    }
}
