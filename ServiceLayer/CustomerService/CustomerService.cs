using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private IRepository<Customer> repo;
        public CustomerService(IRepository<Customer> repo)
        {
            this.repo = repo;

        }
        public void DeleteCustomer(int id)
        {
            Customer customer = GetCustomer(id);
            repo.Remove(customer);
            repo.SaveChanges();
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return repo.GetAll();
        }

        public Customer GetCustomer(int id)
        {
            return repo.Get(id);
        }

        public void InsertCustomer(Customer customer)
        {
            repo.Insert(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
           
            repo.Update(customer);
        }
    }
}
