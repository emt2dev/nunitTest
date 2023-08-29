using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunitTest.Models
{
    internal class TransactionModel
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int DebitCardNumber { get; set; }
        public BranchModel Branch { get; set; }
        public bool? Successful { get; set; }
        public bool IsWithdraw { get; set; }
        public bool IsDeposit { get; set; }
        public double Amount { get; set; }

        public TransactionModel(BranchModel BranchLocation, int CardNumber, bool Withdraw, bool Deposit, double RequestedAmount)
        {
            Id = GLOSSARY.Zed;
            Time = DateTime.Now;
            Branch = BranchLocation;
            DebitCardNumber = CardNumber;
            IsWithdraw = Withdraw;
            IsDeposit = Deposit;
            Amount = RequestedAmount;
        }

    };
}
