using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunitTest.Models
{
    internal class BankAccountModel
    {
        public int Id { get; set; }
        public string UserEmail { get; set; }
        public double Balance { get; set; }
        public int DebitNumber { get; set; }
        public IList<TransactionModel>? Transactions { get; set; }
        public DateTime Opened { get; set; }
        public DateTime? Closed { get; set; }

        public BankAccountModel(string GivenEmail, double StartBalance, int Debit)
        {
            UserEmail = GivenEmail;
            Balance = StartBalance;
            DebitNumber = Debit;
            Transactions = new List<TransactionModel>();
            Opened = DateTime.Now;
        }
    }
}
