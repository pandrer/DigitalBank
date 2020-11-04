using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customer.Grpc.Storage.Contracts
{
    public interface ICostumerRepository
    {
        Task<int> Add(Model.Customer model);
        Task<Model.Customer> Get(string idNumber);
        Task<IList<Model.Customer>> GetAll();
    }
}
