using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {
    public class CongThucLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<CongThuc> _repo;

        public CongThucLogic() {

            _context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<CongThuc>();
        }

        public bool Delete(CongThuc obj) {
            return _repo.Delete(obj);
        }

        public IEnumerable<CongThuc> GetAll() {
            return _repo.GetAll();
        }

        public bool Insert(CongThuc obj) {
            return _repo.Insert(obj);
        }

        public bool Update(CongThuc obj) {
            return _repo.Update(obj);
        }
    }
}
