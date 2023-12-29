using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bar_Management.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiMonAns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiMonAns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NguyenLieus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(maxLength: 50, nullable: false),
                    HinhAnh = table.Column<string>(maxLength: 255, nullable: true),
                    GiaBan = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguyenLieus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCaps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(maxLength: 100, nullable: true),
                    Sdt = table.Column<string>(maxLength: 11, nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCaps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(maxLength: 50, nullable: false),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    SDT = table.Column<string>(maxLength: 11, nullable: false),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    HinhAnh = table.Column<string>(maxLength: 255, nullable: true),
                    Luong = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgonNgu = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SuKiens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSuKien = table.Column<string>(maxLength: 50, nullable: false),
                    NgayDienRa = table.Column<DateTime>(nullable: false),
                    MoTa = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuKiens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrangThaiBans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThaiBans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrangThaiTonKhos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThaiTonKhos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonAns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMon = table.Column<string>(maxLength: 50, nullable: false),
                    LoaiMonAnId = table.Column<int>(nullable: false),
                    Gia = table.Column<decimal>(nullable: false),
                    IsAvailable = table.Column<int>(nullable: false),
                    HinhAnh = table.Column<string>(maxLength: 255, nullable: true),
                    MoTa = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonAns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonAns_LoaiMonAns_LoaiMonAnId",
                        column: x => x.LoaiMonAnId,
                        principalTable: "LoaiMonAns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(maxLength: 50, nullable: false),
                    MatKhau = table.Column<string>(maxLength: 50, nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    NhanVienId = table.Column<int>(nullable: true),
                    SettingId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaiKhoans_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaiKhoans_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaiKhoans_Settings_SettingId",
                        column: x => x.SettingId,
                        principalTable: "Settings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenBan = table.Column<string>(maxLength: 50, nullable: false),
                    TrangThaiId = table.Column<int>(nullable: false),
                    GhiChu = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bans_TrangThaiBans_TrangThaiId",
                        column: x => x.TrangThaiId,
                        principalTable: "TrangThaiBans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TonKhos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguyenLieuId = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    DonVi = table.Column<string>(maxLength: 20, nullable: false),
                    GiaNhap = table.Column<decimal>(nullable: false),
                    TrangThaiId = table.Column<int>(nullable: false),
                    NgayNhap = table.Column<DateTime>(nullable: false),
                    NgayHetHan = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TonKhos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TonKhos_NguyenLieus_NguyenLieuId",
                        column: x => x.NguyenLieuId,
                        principalTable: "NguyenLieus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TonKhos_TrangThaiTonKhos_TrangThaiId",
                        column: x => x.TrangThaiId,
                        principalTable: "TrangThaiTonKhos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CongThucs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonAnId = table.Column<int>(nullable: false),
                    NguyenLieuId = table.Column<int>(nullable: false),
                    DonVi = table.Column<string>(maxLength: 20, nullable: false),
                    SoLuong = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongThucs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CongThucs_MonAns_MonAnId",
                        column: x => x.MonAnId,
                        principalTable: "MonAns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CongThucs_NguyenLieus_NguyenLieuId",
                        column: x => x.NguyenLieuId,
                        principalTable: "NguyenLieus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    TaiKhoanTaoId = table.Column<int>(nullable: false),
                    TongGia = table.Column<decimal>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDons_TaiKhoans_TaiKhoanTaoId",
                        column: x => x.TaiKhoanTaoId,
                        principalTable: "TaiKhoans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DatBanTruocs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BanId = table.Column<int>(nullable: false),
                    TenNguoiDat = table.Column<string>(maxLength: 50, nullable: false),
                    TaiKhoanDatId = table.Column<int>(nullable: false),
                    SDT = table.Column<string>(maxLength: 11, nullable: false),
                    NgayDat = table.Column<DateTime>(nullable: false),
                    NgaySuDung = table.Column<DateTime>(nullable: false),
                    MoTa = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatBanTruocs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DatBanTruocs_Bans_BanId",
                        column: x => x.BanId,
                        principalTable: "Bans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DatBanTruocs_TaiKhoans_TaiKhoanDatId",
                        column: x => x.TaiKhoanDatId,
                        principalTable: "TaiKhoans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoaDonId = table.Column<int>(nullable: false),
                    MonAnId = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    ThanhTien = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDons_HoaDons_HoaDonId",
                        column: x => x.HoaDonId,
                        principalTable: "HoaDons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDons_MonAns_MonAnId",
                        column: x => x.MonAnId,
                        principalTable: "MonAns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bans_TrangThaiId",
                table: "Bans",
                column: "TrangThaiId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDons_HoaDonId",
                table: "ChiTietHoaDons",
                column: "HoaDonId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDons_MonAnId",
                table: "ChiTietHoaDons",
                column: "MonAnId");

            migrationBuilder.CreateIndex(
                name: "IX_CongThucs_MonAnId",
                table: "CongThucs",
                column: "MonAnId");

            migrationBuilder.CreateIndex(
                name: "IX_CongThucs_NguyenLieuId",
                table: "CongThucs",
                column: "NguyenLieuId");

            migrationBuilder.CreateIndex(
                name: "IX_DatBanTruocs_BanId",
                table: "DatBanTruocs",
                column: "BanId");

            migrationBuilder.CreateIndex(
                name: "IX_DatBanTruocs_TaiKhoanDatId",
                table: "DatBanTruocs",
                column: "TaiKhoanDatId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_TaiKhoanTaoId",
                table: "HoaDons",
                column: "TaiKhoanTaoId");

            migrationBuilder.CreateIndex(
                name: "IX_MonAns_LoaiMonAnId",
                table: "MonAns",
                column: "LoaiMonAnId");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoans_NhanVienId",
                table: "TaiKhoans",
                column: "NhanVienId",
                unique: true,
                filter: "[NhanVienId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoans_RoleId",
                table: "TaiKhoans",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoans_SettingId",
                table: "TaiKhoans",
                column: "SettingId");

            migrationBuilder.CreateIndex(
                name: "IX_TonKhos_NguyenLieuId",
                table: "TonKhos",
                column: "NguyenLieuId");

            migrationBuilder.CreateIndex(
                name: "IX_TonKhos_TrangThaiId",
                table: "TonKhos",
                column: "TrangThaiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHoaDons");

            migrationBuilder.DropTable(
                name: "CongThucs");

            migrationBuilder.DropTable(
                name: "DatBanTruocs");

            migrationBuilder.DropTable(
                name: "NhaCungCaps");

            migrationBuilder.DropTable(
                name: "SuKiens");

            migrationBuilder.DropTable(
                name: "TonKhos");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "MonAns");

            migrationBuilder.DropTable(
                name: "Bans");

            migrationBuilder.DropTable(
                name: "NguyenLieus");

            migrationBuilder.DropTable(
                name: "TrangThaiTonKhos");

            migrationBuilder.DropTable(
                name: "TaiKhoans");

            migrationBuilder.DropTable(
                name: "LoaiMonAns");

            migrationBuilder.DropTable(
                name: "TrangThaiBans");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Settings");
        }
    }
}
