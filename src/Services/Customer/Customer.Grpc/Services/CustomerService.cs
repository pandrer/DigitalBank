using Customer.Grpc.Protos;
using Customer.Grpc.Storage.Contracts;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Customer.Grpc.Services
{
    public class CustomerService : CustomerEntry.CustomerEntryBase
    {
        private readonly ILogger<CustomerService> _logger;
        private readonly ICostumerRepository _costumerRepository;

        public CustomerService(ILogger<CustomerService> logger, ICostumerRepository costumerRepository)
        {
            _logger = logger;
            _costumerRepository = costumerRepository;
        }

        public override async Task<DefaultResponse> AddCustomer(CustomerRequest request, ServerCallContext context)
        {
            var result = new DefaultResponse();
            try
            {

                var costumer = new Model.Customer()
                {
                    Address = request.Address,
                    BirthDate = DateTimeOffset.Parse(request.BirthDate),
                    City = request.City,
                    Country = request.Country,
                    Email = request.Email,
                    FirsName = request.FirsName,
                    IdNumber = request.IdNumber,
                    LastName = request.LastName,
                    MiddleName = request.MiddleName,
                    Movil = request.Movil,
                    Phone = request.Phone
                };
                await _costumerRepository.Add(costumer);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"ERROR: Adding Costumer");
                result.Message = $"ERROR: Adding Costumer";
            }
            return result;

        }

        public override async Task<CustomerResponse> GetCustomer(CustomerByIdFilter request, ServerCallContext context)
        {
            var result = new CustomerResponse();
            try
            {
                var costumer = await _costumerRepository.Get(request.IdNumber);
                result.IdNumber = costumer.IdNumber;
                result.Address = costumer.Address;
                result.BirthDate = costumer.BirthDate.ToString();
                result.City = costumer.City;
                result.Country = costumer.Country;
                result.Email = costumer.Email;
                result.FirsName = costumer.FirsName;
                result.IdNumber = costumer.IdNumber;
                result.LastName = costumer.LastName;
                result.MiddleName = costumer.MiddleName;
                result.Movil = costumer.Movil;
                result.Phone = costumer.Phone;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"ERROR: GET Costumer");
                result.Message = $"ERROR: GET Costumer";
            }
            return result;
        }

        public override async Task<CustomerCollectionResponse> GetCustomers(Empty request, ServerCallContext context)
        {
            var result = new CustomerCollectionResponse();
            try
            {
                var costumers = await _costumerRepository.GetAll();
                foreach (var costumer in costumers)
                {
                    var current = new CustomerRequest();
                    current.IdNumber = costumer.IdNumber;
                    current.Address = costumer.Address;
                    current.BirthDate = costumer.BirthDate.ToString();
                    current.City = costumer.City;
                    current.Country = costumer.Country;
                    current.Email = costumer.Email;
                    current.FirsName = costumer.FirsName;
                    current.IdNumber = costumer.IdNumber;
                    current.LastName = costumer.LastName;
                    current.MiddleName = costumer.MiddleName;
                    current.Movil = costumer.Movil;
                    current.Phone = costumer.Phone;
                    result.Customers.Add(current);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"ERROR: GETALL Costumer");
                result.Message = $"ERROR: GETALL Costumer";
            }
            return result;
        }

    }
}
