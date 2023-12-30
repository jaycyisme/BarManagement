using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {
    public class ChiTieHoaDonLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<ChiTietHoaDon> _repo;

        public ChiTieHoaDonLogic() {

            _context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<ChiTietHoaDon>();
        }

        public bool Delete(ChiTietHoaDon obj) {
            return _repo.Delete(obj);
        }

        public IEnumerable<ChiTietHoaDon> GetAll() {
            return _repo.GetAll();
        }

        public bool Insert(ChiTietHoaDon obj) {
            return _repo.Insert(obj);
        }

        public bool Update(ChiTietHoaDon obj) {
            return _repo.Update(obj);
        }
    }
}
