using Company.Core;
using Company.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Infra.Repo
{
    public class EmpRepo :GenericRepo<Emp>,IEmp
    {
        CompanyContext cc;
        public EmpRepo()
        {
            cc = new CompanyContext();
        }

        public List<Emp> GetTop5Emps()
        {
            return cc.Emps.Where(p => p.EmpName.StartsWith("R")).ToList();
        }
    }
}
