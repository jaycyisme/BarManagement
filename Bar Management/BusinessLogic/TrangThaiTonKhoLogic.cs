using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {

    public class TrangThaiTonKhoLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<TrangThaiTonKho> _repo;

        public TrangThaiTonKhoLogic() {
            _context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<TrangThaiTonKho>();
        }

        public bool Delete(TrangThaiTonKho obj) {
            return _repo.Delete(obj);
        }

        public IEnumerable<TrangThaiTonKho> GetAll() {
            return _repo.GetAll();
        }

        public bool Insert(TrangThaiTonKho obj) {
            return _repo.Insert(obj);
        }

        public bool Update(TrangThaiTonKho obj) {
            return _repo.Update(obj);
        }
    }
}
