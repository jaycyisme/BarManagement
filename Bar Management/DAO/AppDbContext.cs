
using Bar_Management.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Bar_Management.DAO {
    public class AppDbContext: DbContext {

        public DbSet<Ban> Bans { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<CongThuc> CongThucs { get; set; }
        public DbSet<DatBanTruoc> DatBanTruocs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<LoaiMonAn> LoaiMonAns { get; set; }
        public DbSet<MonAn> MonAns { get; set; }
        public DbSet<NguyenLieu> NguyenLieus { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SuKien> SuKiens { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<TonKho> TonKhos { get; set; }
        public DbSet<TrangThaiBan> TrangThaiBans { get; set; }
        public DbSet<TrangThaiTonKho> TrangThaiTonKhos { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public AppDbContext() {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString);
            optionsBuilder.UseSqlServer("server=.\\DONGSQLSERVER; database=QuanLyBarHai; trusted_connection=true; trustservercertificate=true; MultipleActiveResultSets=true");
        }


    }
}
