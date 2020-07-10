using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnCRUDAssignment.Entities;

namespace HandsOnCRUDAssignment.Repositories
{
    public class CustomerRepository
    {
        CustomerContext db = new CustomerContext();
        public List<Customer> GetCustomers()
        {
            return db.Customers.ToList();
        }
        public Customer GetCustomersById(string cid)
        {
            return db.Customers.Find(cid);
        }
        public void Add(Customer c)
        {
            db.Add(c);
            db.SaveChanges();
        }
        public void Delete(Customer c)
        {
            db.Remove(c);
            db.SaveChanges();
        }
        public void Update(Customer c)
        {
            db.Update(c);
            db.SaveChanges();
        }

    }
}
