using Bar_Management.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.Tool {
    public class DbContextStatic {
        public static AppDbContext DbContext;

        public DbContextStatic() {
            DbContext = new AppDbContext();
        }
    }
}
