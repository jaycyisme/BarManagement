using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.DAO {
    public class AppDbContextSingleton {
        private static AppDbContext _instance;

        public static AppDbContext Instance {
            get {
                if (_instance == null) {
                    _instance = new AppDbContext();
                }
                return _instance;
            }
        }
    }
}
