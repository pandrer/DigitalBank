using System;

namespace InPerson.Grpc.Model
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string CardReference { get; set; }
        public CreditCardType CreditCardType { get; set; }
        public DateTimeOffset OpeningDate { get; set; }
        public bool IsAvailable { get; set; }
    }
}
