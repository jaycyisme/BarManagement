
using Microsoft.EntityFrameworkCore;
using Bar_Management.Models;
using System.Configuration;

namespace Bar_Management.DAO {
    internal class AppDbContext: DbContext {
        private readonly string _connectionString;
        public AppDbContext() {
            _connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        }
        public virtual DbSet<TrangThaiTonKho> TrangThaiTonKho { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
