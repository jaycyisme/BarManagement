﻿// <auto-generated />
using System;
using Bar_Management.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bar_Management.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231229154416_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bar_Management.Models.Ban", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("TenBan")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("TrangThaiId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrangThaiId");

                    b.ToTable("Bans");
                });

            modelBuilder.Entity("Bar_Management.Models.ChiTietHoaDon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HoaDonId")
                        .HasColumnType("int");

                    b.Property<int>("MonAnId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<decimal>("ThanhTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("HoaDonId");

                    b.HasIndex("MonAnId");

                    b.ToTable("ChiTietHoaDons");
                });

            modelBuilder.Entity("Bar_Management.Models.CongThuc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DonVi")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("MonAnId")
                        .HasColumnType("int");

                    b.Property<int>("NguyenLieuId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MonAnId");

                    b.HasIndex("NguyenLieuId");

                    b.ToTable("CongThucs");
                });

            modelBuilder.Entity("Bar_Management.Models.DatBanTruoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BanId")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("NgayDat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgaySuDung")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<int>("TaiKhoanDatId")
                        .HasColumnType("int");

                    b.Property<string>("TenNguoiDat")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("BanId");

                    b.HasIndex("TaiKhoanDatId");

                    b.ToTable("DatBanTruocs");
                });

            modelBuilder.Entity("Bar_Management.Models.HoaDon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<int>("TaiKhoanTaoId")
                        .HasColumnType("int");

                    b.Property<decimal>("TongGia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TaiKhoanTaoId");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("Bar_Management.Models.LoaiMonAn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("LoaiMonAns");
                });

            modelBuilder.Entity("Bar_Management.Models.MonAn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("IsAvailable")
                        .HasColumnType("int");

                    b.Property<int>("LoaiMonAnId")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("TenMon")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("LoaiMonAnId");

                    b.ToTable("MonAns");
                });

            modelBuilder.Entity("Bar_Management.Models.NguyenLieu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("NguyenLieus");
                });

            modelBuilder.Entity("Bar_Management.Models.NhaCungCap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("NhaCungCaps");
                });

            modelBuilder.Entity("Bar_Management.Models.NhanVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<decimal>("Luong")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("Bar_Management.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Bar_Management.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NgonNgu")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Bar_Management.Models.SuKien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("NgayDienRa")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenSuKien")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("SuKiens");
                });

            modelBuilder.Entity("Bar_Management.Models.TaiKhoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("NhanVienId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("SettingId")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("NhanVienId")
                        .IsUnique()
                        .HasFilter("[NhanVienId] IS NOT NULL");

                    b.HasIndex("RoleId");

                    b.HasIndex("SettingId");

                    b.ToTable("TaiKhoans");
                });

            modelBuilder.Entity("Bar_Management.Models.TonKho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DonVi")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<decimal>("GiaNhap")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("NgayHetHan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayNhap")
                        .HasColumnType("datetime2");

                    b.Property<int>("NguyenLieuId")
                        .HasColumnType("int");

                    b.Property<int?>("NhaCungCapId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("TrangThaiId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NguyenLieuId");

                    b.HasIndex("NhaCungCapId");

                    b.HasIndex("TrangThaiId");

                    b.ToTable("TonKhos");
                });

            modelBuilder.Entity("Bar_Management.Models.TrangThaiBan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("TrangThaiBans");
                });

            modelBuilder.Entity("Bar_Management.Models.TrangThaiTonKho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TrangThaiTonKhos");
                });

            modelBuilder.Entity("Bar_Management.Models.Ban", b =>
                {
                    b.HasOne("Bar_Management.Models.TrangThaiBan", "TrangThai")
                        .WithMany("Bans")
                        .HasForeignKey("TrangThaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bar_Management.Models.ChiTietHoaDon", b =>
                {
                    b.HasOne("Bar_Management.Models.HoaDon", "HoaDon")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("HoaDonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bar_Management.Models.MonAn", "MonAn")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("MonAnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bar_Management.Models.CongThuc", b =>
                {
                    b.HasOne("Bar_Management.Models.MonAn", "MonAn")
                        .WithMany("CongThucs")
                        .HasForeignKey("MonAnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bar_Management.Models.NguyenLieu", "NguyenLieu")
                        .WithMany()
                        .HasForeignKey("NguyenLieuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bar_Management.Models.DatBanTruoc", b =>
                {
                    b.HasOne("Bar_Management.Models.Ban", "Ban")
                        .WithMany("DatBanTruocs")
                        .HasForeignKey("BanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bar_Management.Models.TaiKhoan", "TaiKhoanDat")
                        .WithMany("DatBanTruocs")
                        .HasForeignKey("TaiKhoanDatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bar_Management.Models.HoaDon", b =>
                {
                    b.HasOne("Bar_Management.Models.TaiKhoan", "TaiKhoanTao")
                        .WithMany("HoaDons")
                        .HasForeignKey("TaiKhoanTaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bar_Management.Models.MonAn", b =>
                {
                    b.HasOne("Bar_Management.Models.LoaiMonAn", "LoaiMonAn")
                        .WithMany("MonAns")
                        .HasForeignKey("LoaiMonAnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bar_Management.Models.TaiKhoan", b =>
                {
                    b.HasOne("Bar_Management.Models.NhanVien", "NhanVien")
                        .WithOne("TaiKhoan")
                        .HasForeignKey("Bar_Management.Models.TaiKhoan", "NhanVienId");

                    b.HasOne("Bar_Management.Models.Role", "Role")
                        .WithMany("TaiKhoans")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bar_Management.Models.Setting", "Setting")
                        .WithMany("TaiKhoans")
                        .HasForeignKey("SettingId");
                });

            modelBuilder.Entity("Bar_Management.Models.TonKho", b =>
                {
                    b.HasOne("Bar_Management.Models.NguyenLieu", "NguyenLieu")
                        .WithMany("TonKhos")
                        .HasForeignKey("NguyenLieuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bar_Management.Models.NhaCungCap", null)
                        .WithMany("TonKhos")
                        .HasForeignKey("NhaCungCapId");

                    b.HasOne("Bar_Management.Models.TrangThaiTonKho", "TrangThai")
                        .WithMany("TonKhos")
                        .HasForeignKey("TrangThaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
