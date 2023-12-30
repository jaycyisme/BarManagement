using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {

    public class SukienLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<SuKien> _repo;

        public SukienLogic() {

            _context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<SuKien>();
        }

        public bool Delete(SuKien sukien) {
            return _repo.Delete(sukien);
        }

        public IEnumerable<SuKien> GetAll() {
            return _repo.GetAll();
        }

        public bool Insert(SuKien obj) {
            return _repo.Insert(obj);
        }

        public bool Update(SuKien obj) {
            return _repo.Update(obj);
        }


    }
}
