using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractOdev.Entities;

namespace InterfaceAbstractOdev.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
