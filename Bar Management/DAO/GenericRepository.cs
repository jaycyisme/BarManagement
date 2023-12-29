using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management.DAO {
    public class GenericRepository<T>: IGenericRepository<T> where T : class {
        private readonly AppDbContext _appDbContext;
        private DbSet < T > entities;
        string errorMessage = string.Empty;

        public GenericRepository() {
            _appDbContext = new AppDbContext();
            entities = _appDbContext.Set<T>();
        }

        public async Task<Result> Delete(T entity) {
            if (entity == null) {
                return new Result(){Message = "Du lieu trong"};
            }
            try {
                entities.Remove(entity);
                _appDbContext.SaveChanges();
                return new Result() { IsSuccess=true};
            } catch (Exception ex) {

                return new Result() { Message = ex.Message };
            }
        }

        public Task<IEnumerable<T>> GetAll() {
            throw new NotImplementedException();
        }

        public Task<T> GetById(object id) {
            throw new NotImplementedException();
        }

        public Task<object> Insert(T obj) {
            throw new NotImplementedException();
        }

        public Task<bool> Update(object id, T obj) {
            throw new NotImplementedException();
        }
    }
}
