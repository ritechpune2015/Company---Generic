using Company.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Infra
{
    public class CompanyContext:DbContext
    {
    //    public CompanyContext() : base("scon")
     //   { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Emp> Emps { get; set; }
    }
}
