using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {
    public class MonAnLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<MonAn> _repo;

        public MonAnLogic() {

            _context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<MonAn>();
        }

        public bool Delete(MonAn obj) {
            return _repo.Delete(obj);
        }

        public IEnumerable<MonAn> GetAll() {
            return _repo.GetAll();
        }

        public bool Insert(MonAn obj) {
            return _repo.Insert(obj);
        }

        public bool Update(MonAn obj) {
            return _repo.Update(obj);
        }

    }
}
