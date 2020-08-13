using Company.Core;
using Company.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Infra.Repo
{
    public class CustomerRepo :GenericRepo<Customer>,ICustomer
    {
        //contain actual data access code to work with customer entity
        CompanyContext cc;
        public CustomerRepo()
        {
            cc = new CompanyContext();
        }
      
    }
}
