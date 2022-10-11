using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectK.Abstract;
using ProjectK.Entities;

namespace ProjectK.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        private readonly ICustomerCheckService? _customerCheckService;

        public NeroCustomerManager()
        {
        }

        public  NeroCustomerManager(ICustomerCheckService? customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {

          if( _customerCheckService.CheckIfRealCustomer(customer))
            {
                base.Save(customer);
            }
          else
            {
                throw new Exception("not real person");
            }
            
        }


    }
}
