using System;

namespace InPerson.Grpc.Model
{

    public class BankProduct
    {
        public int Id { get; set; }
        public string AccountReference { get; set; }
        public string IdClient { get; set; }
        public AccountBankType AccountType { get; set; }
        public bool HasCard { get; set; }
        public DateTimeOffset OpeningDate { get; set; }
    }
}
