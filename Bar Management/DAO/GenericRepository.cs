using Bar_Management.Tool;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management.DAO {
    public class GenericRepository<T>: IGenericRepository<T> where T : class {
        public readonly AppDbContext _appDbContext;
        private DbSet < T > entities;
        string errorMessage = string.Empty;

        public GenericRepository() {
            _appDbContext = DbContextStatic.DbContext;
            entities = _appDbContext.Set<T>();
        }

        public Result Delete(T entity) {
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

        public IEnumerable<T> GetAll() {
            return entities.AsEnumerable();
        }

        public void GetById(object id) {
        }

        public object Insert(T obj) {
             entities.AddAsync(obj);
             _appDbContext.SaveChangesAsync();
            return true;
        }

        public bool Update(object id, T objMoi) {
            return true;
        }
    }
}
