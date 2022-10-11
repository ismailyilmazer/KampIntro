using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectK.Entities;

namespace ProjectK.Abstract
{
    public abstract class BaseCustomerManager
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved DB"+ customer.FirstName);
        }
    }
}
