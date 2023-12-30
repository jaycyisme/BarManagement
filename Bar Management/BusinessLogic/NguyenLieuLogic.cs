using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {
    public class NguyenLieuLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<LoaiMonAn> _repo;

        public NguyenLieuLogic() {

            _context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<LoaiMonAn>();
        }

        public bool Delete(LoaiMonAn obj) {
            return _repo.Delete(obj);
        }

        public IEnumerable<LoaiMonAn> GetAll() {
            return _repo.GetAll();
        }

        public bool Insert(LoaiMonAn obj) {
            return _repo.Insert(obj);
        }

        public bool Update(LoaiMonAn obj) {
            return _repo.Update(obj);
        }
    }
}
