using AutoMapper;
using Microsoft.Extensions.Logging;
using paymentSystemAPI.Application.DTOs;
using paymentSystemAPI.Application.Interfaces.IRepository;
using paymentSystemAPI.Application.Interfaces.IServices;
using paymentSystemAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paymentSystemAPI.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ILogger<CustomerService> _logger;
        private readonly IBaseRepository<Customer> _customerRepo;
        private readonly IMapper _mapper;

        public CustomerService(ILogger<CustomerService> logger, IBaseRepository<Customer> customerRepo, IMapper mapper)
        {
            _customerRepo = customerRepo;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<bool> AddCustomerAsync(CustomerDTO customerdto)
        {
            try
            {
                var customer = _mapper.Map<Customer>(customerdto);

                if (customer == null)
                {
                    return false;
                }

                await _customerRepo.AddAsync(customer);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task DeleteCustomer(int customerId)
        {
            var customer = await _customerRepo.GetByIdAsync(customerId);

            if (customer == null)
            {
                _logger.LogWarning($"Customer with ID {customerId} not found");
                return;
            }

            await _customerRepo.DeleteAsync(customer);
        }

        public async Task<IEnumerable<CustomerDTO>> GetAllCustomerAsync()
        {
            var customers = await _customerRepo.GetAllAsync();
            return _mapper.Map<IEnumerable<CustomerDTO>>(customers);
        }

        public async Task<CustomerDTO> GetCustomerByIdAsync(int customerId)
        {
            var customer = await _customerRepo.GetByIdAsync(customerId);

            if (customer == null)
            {
                _logger.LogWarning($"Customer with the ID {customerId} not found");
                return null;
            }

            return _mapper.Map<CustomerDTO>(customer);
        }

        public async Task UpdateCustomerAsync(int customerId, CustomerDTO customerdto)
        {
            var existingCustomer = await _customerRepo.GetByIdAsync(customerId);

            if (existingCustomer == null)
            {
                _logger.LogWarning($"Customer with the ID {customerId}  not found");
                return;
            }

            _mapper.Map(customerdto, existingCustomer);
            //_mapper.Map<CustomerDTO>(existingCustomer);
            await _customerRepo.UpdateAsync(existingCustomer);
        }
    }
}
