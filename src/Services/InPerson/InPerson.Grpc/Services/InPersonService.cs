using Grpc.Core;
using InPerson.Grpc.Protos;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace InPerson.Grpc.Services
{
    public class InPersonService : InPersonEntry.InPersonEntryBase
    {
        public override Task<DefaultResponse> AddProduct(ProductRequest request, ServerCallContext context)
        {
            return base.AddProduct(request, context);
        }


        public override Task<ProductsCollectionResponse> GetProduct(ProductsByReferenceFilter request, ServerCallContext context)
        {
            return base.GetProduct(request, context);
        }

        public override Task<ProductsCollectionResponse> GetProductsByPerson(ProductsByIdFilter request, ServerCallContext context)
        {
            return base.GetProductsByPerson(request, context);
        }
    }
}
