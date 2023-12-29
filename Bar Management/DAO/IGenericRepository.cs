using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.DAO {
    public interface IGenericRepository<T> where T : class{
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(object id);
        Task<object> Insert(T obj);
        Task<bool> Update(object id, T obj);
        Task<Result> Delete(T obj);
    }
}
