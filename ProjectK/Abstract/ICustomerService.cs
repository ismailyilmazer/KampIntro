using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectK.Entities;
using ProjectK.Concrete;

namespace ProjectK.Abstract
{
    public interface ICustomerService
    {
      public  void Save(Customer customer);

    }
}
