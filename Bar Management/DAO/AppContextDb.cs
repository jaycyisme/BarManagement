
using Microsoft.EntityFrameworkCore;
using Bar_Management.Models;
using System.Configuration;

namespace Bar_Management.DAO {
    internal class AppContextDb: DbContext {
        protected AppContextDb() {
        }
        public virtual DbSet<LoaiMonAn> LoaiMonAn { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString);
        }
    }
}
