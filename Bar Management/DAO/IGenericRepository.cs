using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.DAO {
    public interface IGenericRepository<T> where T : class{
        IEnumerable<T> GetAll();
        bool Insert(T obj);
        bool Delete(T ob0j);
        bool Update(T ob0j);
    }
}
