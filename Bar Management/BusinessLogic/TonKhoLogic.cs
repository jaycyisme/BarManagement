using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {
    public class TonKhoLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<TonKho> _repo;

        public TonKhoLogic() {

            _context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<TonKho>();
        }

        public bool Delete(TonKho obj) {
            return _repo.Delete(obj);
        }

        public IEnumerable<TonKho> GetAll() {
            return _repo.GetAll();
        }

        public bool Insert(TonKho obj) {
            return _repo.Insert(obj);
        }

        public bool Update(TonKho obj) {
            return _repo.Update(obj);
        }
    }
}
