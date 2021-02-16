using System;
using InterfaceAbstractOdev.Abstract;
using InterfaceAbstractOdev.Adapters;
using InterfaceAbstractOdev.Concrete;

namespace InterfaceAbstractOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer { DateOfBirth = new DateTime(1983,9,23), FirstName = "MURAT", LastName = "FIRTINA", NationalityId = "123"});
            Console.ReadLine();
        }
    }
}
