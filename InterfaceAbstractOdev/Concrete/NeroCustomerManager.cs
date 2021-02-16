using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractOdev.Abstract;

namespace InterfaceAbstractOdev.Concrete
{
    public class NeroCustomerManager:BaseCustomerManager
    {
        private CustomerCheckManager customerCheckManager;

        public NeroCustomerManager(CustomerCheckManager customerCheckManager)
        {
            this.customerCheckManager = customerCheckManager;
        }
    }
}
