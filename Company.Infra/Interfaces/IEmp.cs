using Company.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Infra.Interfaces
{
    public interface IEmp :IGeneric<Emp>
    {
        List<Emp> GetTop5Emps();
    }
}
