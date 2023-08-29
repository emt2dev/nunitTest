using nunitTest.Interfaces;
using nunitTest.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace nunitTest.Repositories
{
    internal class MethodRepository : IMethods
    {
        public void UpdateAccount(BankAccountModel Account, TransactionModel Transaction)
        {
            switch (Transaction.IsWithdraw)
            {
                case true:
                    Account.Balance -= Transaction.Amount;
                    Account.Transactions.Add(Transaction);
                    break;

                default:
                    Account.Balance += Transaction.Amount;
                    Account.Transactions.Add(Transaction);
                    break;
            }
        }

        public bool TransactionASuccess(double RequestAmount, double AccountAmount, bool IsWithdraw)
        {
            if (IsWithdraw)
            {
                switch (RequestAmount - AccountAmount)
                {
                    case < 0.00:
                        return false;

                    default:
                        return true;
                }
            } else
            {
                switch (RequestAmount + AccountAmount)
                {
                    default:
                        return true;
                }
            }
            
        }

        public BankAccountModel GetAccountDetailsFromCard(int CardNumber)
        {
            // Here we simulate doing a query
            // BankAccountModel Found = await _context.Set<BankAccountModel>()
            // FirstOrDefaultAsync(x => x.CardNumber == CardNumber);

            // if (Found is not null) return Found;
            // else return null;

            BankAccountModel Found = new BankAccountModel(GLOSSARY.CustomerEmail, GLOSSARY.StartingBalance, GLOSSARY.DebitCardNumber);
            Found.Id = GLOSSARY.SimulatedIdTwo;

            return Found;
        }

        public BankAccountModel GetAccountDetailsFromEmail(string Email)
        {
            // Here we simulate doing a query
            // BankAccountModel Found = await _context.Set<BankAccountModel>()
            // .Include(x => x.Transactions)
            // FirstOrDefaultAsync(x => x.Email == Email)
            // ;

            // if (Found is not null) return Found;
            // else return null;

            BankAccountModel Found = new BankAccountModel(GLOSSARY.CustomerEmail, GLOSSARY.StartingBalance, GLOSSARY.DebitCardNumber);
            Found.Id = GLOSSARY.SimulatedIdOne;
            Found.Transactions = new List<TransactionModel>();
            Found.Opened = DateTime.Now;

            return Found;
        }

        public BranchModel GetBranch(int BranchId)
        {
            // Here we simulate doing a query
            // BranchModel Found = await _context.Set<BranchModel>()
            // FirstOrDefaultAsync(x => x.Id == BranchId);

            // if (Found is not null) return Found;
            // else return null;

            BranchModel Found = new BranchModel(GLOSSARY.SimulatedIdOne);

            return Found;
        }

        public TellerModel GetTeller(string EID)
        {
            // Here we simulate doing a query
            // BranchModel Found = await _context.Set<BranchModel>()
            // FirstOrDefaultAsync(x => x.Id == BranchId);

            // if (Found is not null) return Found;
            // else return null;

            TellerModel Found = new TellerModel(GLOSSARY.BankTellerName);

            return Found;
        }
    }
}
