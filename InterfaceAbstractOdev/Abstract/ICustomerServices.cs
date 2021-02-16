using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractOdev.Entities;

namespace InterfaceAbstractOdev.Abstract
{
    public interface ICustomerServices
    {
        void Save(Customer customer);
    }
}
