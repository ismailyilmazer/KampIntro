using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectK.Concrete;
using ProjectK.Entities;

namespace ProjectK.Abstract
{
    public interface ICustomerCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {
            return true;
        }
    }
}
