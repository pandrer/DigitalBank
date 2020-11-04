using Customer.Grpc.Infrastructure;
using Customer.Grpc.Storage.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Grpc.Storage
{
    public class CostumerRepository : ICostumerRepository
    {

        private readonly CustomerContext _context;
        public CostumerRepository(CustomerContext context)
        {
            _context = context;
        }

        public async Task<int> Add(Model.Customer model)
        {
            _context.Customer.Add(model);
            return _context.SaveChanges();
        }

        public async Task<Model.Customer> Get(string idNumber)
        {
            var costumer = _context.Customer.Where(x => x.IdNumber == idNumber).FirstOrDefault();
            return costumer;
        }

        public async Task<IList<Model.Customer>> GetAll()
        {
            var costumers = _context.Customer.ToList();
            return costumers;
        }
    }
}
