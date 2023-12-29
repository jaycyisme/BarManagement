using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.DAO {
    public interface IGenericRepository<T> where T : class{
        IEnumerable<T> GetAll();
        void GetById(object id);
        object Insert(T obj);
        bool Update(object id, T obj);
        Result Delete(T obj);
    }
}
