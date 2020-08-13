using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Infra.Interfaces
{
    public interface IGeneric <T>
    {
        void Add(T rec);
        void Edit(T rec);
        void Delete(Int64 id);
        List<T> GetAll();
        T FindById(Int64 id);
    }
}
