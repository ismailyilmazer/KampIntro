using System;
using ProjectK.Abstract;
using ProjectK.Entities;
using ProjectK.Concrete;


namespace ProjectK
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new NeroCustomerManager();


            baseCustomerManager.Save(new Customer{ Id = 12, FirstName = "ismail", LastName = "yilmazer", CreatedDate = new DateTime(2000, 4, 17), NationalityId = "123" } );
        }
    }
}
