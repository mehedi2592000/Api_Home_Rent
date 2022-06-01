using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity_Layer.Repository
{
    public interface IRepository<T,Id>
    {
        List<T> GetAll();

        T Get(Id id);

        void Delete(Id id);

        void Edit(T e);

        void Add(T e);
    }
}
