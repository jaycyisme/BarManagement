using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {
    public class HoaDonLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<HoaDon> _repo;

        public HoaDonLogic() {

            _context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<HoaDon>();
        }

        public bool Delete(HoaDon obj) {
            return _repo.Delete(obj);
        }

        public IEnumerable<HoaDon> GetAll() {
            return _repo.GetAll();
        }

        public bool Insert(HoaDon obj) {
            return _repo.Insert(obj);
        }

        public bool Update(HoaDon obj) {
            return _repo.Update(obj);
        }
    }
}
