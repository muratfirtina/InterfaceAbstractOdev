using InterfaceAbstractOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractOdev.Abstract
{
    public class BaseCustomerManager : ICustomerServices
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to db : " + customer.FirstName + " " + customer.LastName);
        }
    }
}
