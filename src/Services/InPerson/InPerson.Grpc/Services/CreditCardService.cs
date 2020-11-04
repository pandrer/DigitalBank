using Grpc.Core;
using InPerson.Grpc.Protos;
using System.Threading.Tasks;

namespace InPerson.Grpc.Services
{
    public class CreditCardService : CreditCardEntry.CreditCardEntryBase
    {
        public override Task<DefaultResponse> AddCreditCard(CreditCardRequest request, ServerCallContext context)
        {
            return base.AddCreditCard(request, context);
        }

        public override Task<CreditCardCollectionResponse> GetAvailableCreditCards(Empty request, ServerCallContext context)
        {
            return base.GetAvailableCreditCards(request, context);
        }

        public override Task<DefaultResponse> UpdateAvailabilityCreditCard(CreditCardByReferenceFilter request, ServerCallContext context)
        {
            return base.UpdateAvailabilityCreditCard(request, context);
        }
    }
}
