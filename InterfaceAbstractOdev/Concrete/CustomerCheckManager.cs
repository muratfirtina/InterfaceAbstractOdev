using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractOdev.Abstract;
using InterfaceAbstractOdev.Entities;

namespace InterfaceAbstractOdev.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
