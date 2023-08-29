using nunitTest.Models;

namespace nunitTest
{
    
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void GivenCardNumberFunReturnsBankAccountModel()
        {
            // arrange
            // models
            BankAccountModel BankAccountOne = new BankAccountModel(GLOSSARY.CustomerEmail, GLOSSARY.StartingBalance, GLOSSARY.DebitCardNumber)
            {
                Id = GLOSSARY.SimulatedIdOne,
                Transactions = new List<TransactionModel>(),
                Opened = DateTime.Now
            };

            TellerModel TellerOne = new TellerModel(GLOSSARY.BankTellerName);
            TellerOne.Id = 1;

            BranchModel PhysicalBranch = new BranchModel(GLOSSARY.SimulatedIdOne);
            PhysicalBranch.IsATM = GLOSSARY.IsFalse;
            PhysicalBranch.Teller = TellerOne;

            BranchModel AtmBranch = new BranchModel(GLOSSARY.SimulatedIdOne);
            AtmBranch.IsATM = GLOSSARY.IsTrue;


            TransactionModel NegativeWithdrawl = new TransactionModel(PhysicalBranch, BankAccountOne.DebitNumber, GLOSSARY.IsTrue, GLOSSARY.IsFalse, GLOSSARY.WithdrawlBalanceNegative);
            TransactionModel PositiveWithdrawl = new TransactionModel(PhysicalBranch, BankAccountOne.DebitNumber, GLOSSARY.IsTrue, GLOSSARY.IsFalse, GLOSSARY.WithdrawlBalancePositive);
            TransactionModel DepositOne = new TransactionModel(AtmBranch, BankAccountOne.DebitNumber, GLOSSARY.IsFalse, GLOSSARY.IsTrue, GLOSSARY.DepositBalancePositive);
            TransactionModel DepositTwo = new TransactionModel(PhysicalBranch, BankAccountOne.DebitNumber, GLOSSARY.IsFalse, GLOSSARY.IsTrue, GLOSSARY.DepositBalancePositive);
            TransactionModel DepositThree = new TransactionModel(AtmBranch, BankAccountOne.DebitNumber, GLOSSARY.IsFalse, GLOSSARY.IsTrue, GLOSSARY.DepositBalancePositive);

            // arrange
            // methods
            BankAccountModel GetAccountDetailsFromCard(int CardNumber)
            {
                BankAccountModel Found = new BankAccountModel(GLOSSARY.CustomerEmail, GLOSSARY.StartingBalance, GLOSSARY.DebitCardNumber);
                Found.Id = GLOSSARY.SimulatedIdOne;
                Found.Transactions = new List<TransactionModel>();
                Found.Opened = DateTime.Now;

                return Found;
            }

            // act
            var Account = GetAccountDetailsFromCard(GLOSSARY.DebitCardNumber);

            // assert
            Assert.IsInstanceOf<BankAccountModel>(Account);
        }
    }
}