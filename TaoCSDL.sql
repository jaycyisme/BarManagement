create database QuanLyBar

create table LoaiMonAn(
	Id int identity primary key,
	TenLoai nvarchar(50) not null
)

create table MonAn(
	Id int primary key identity,
	TenMon nvarchar(50) not null,
	LoaiMonAnId int foreign key references LoaiMonAn(Id) not null,
	Gia money not null,
	IsAvailable int default 1,
	HinhAnh text default '',
	MoTa nvarchar(100) default ''
)

create table NguyenLieu(
	Id int primary key identity,
	Ten nvarchar(50) not null,
	HinhAnh text default '',
	GiaBan money default 0
)

create table CongThuc(
	Id int identity primary key,
	MonAnId int foreign key references MonAn(Id) not null,
	NguyenLieuId int foreign key references NguyenLieu(Id) not null,
	DonVi varchar(20) not null,
	SoLuong int not null
)

create table NhaCungCap(
	Id int identity primary key,
	Ten nvarchar(50) not null,
	DiaChi nvarchar(100),
	Sdt varchar(11) not null,
	Email varchar(50) unique not null
)

/*1-Còn hàng, 2-hết hàng, 3-hết hạn*/
create table TrangThaiTonKho(
	Id int identity primary key,
	Ten Nvarchar(50) not null
)

create table TonKho(
	Id int primary key identity,
	NguyenLieuId int foreign key references NguyenLieu(Id) not null,
	SoLuong int not null,
	NhacungcapId int  foreign key references NhaCungCap(Id)  not null,
	DonVi nvarchar(20) not null,
	GiaNhap money not null,
	TrangThaiId int  foreign key references TrangThaiTonKho(Id) default 1,
	NgayNhap date not null,
	NgayHetHan date not null

)

create table NhanVien(
	Id int identity primary key,
	Ten nvarchar(50) not null,
	NgaySinh date not null,
	SDT varchar(11) not null,
	Email varchar(256) default '',
	HinhAnh text default '',
	Luong money default 0
)

/*English/Vietnam*/
create table Setting (
	Id int identity primary key,
	NgonNgu varchar(20)
)

/*1-NV quản lý, 2-NV kho, 3-admin*/
create table Role(
	Id int primary key identity,
	Ten nvarchar(20) not null
)

create table TaiKhoan(
	Id int identity primary key,
	Ten nvarchar(50) not null,
	MatKhau nvarchar(50) not null,
	RoleId int foreign key references Role(Id) not null,
	NhanVienId int foreign key references NhanVien(Id),
	SettingId int foreign key references Setting(Id)
)

create table HoaDon(
 Id int primary key identity,
 NgayTao date not null,
 TaiKhoanTaoId int not null foreign key references TaiKhoan(Id),
 TongGia money not null,
 TrangThai int not null
)
/*1 đã thanh toán, 0 chưa thanh toán*/

create table ChiTietHoaDon(
 Id int primary key identity,
 HoaDonId int foreign key references HoaDon(Id) not null,
 MonAnId int foreign key references MonAn(Id) not null,
 SoLuong int not null,
 ThanhTien money not null
)
/*Chống-xanh lá, Đang dùng-đỏ, Đã có người đặt-vàng, NotInUse-xám*/
create table TrangThaiBan(
	Id int primary key identity,
	Ten nvarchar(20) not null
)

create table Ban(
 Id int primary key identity,
 TenBan nvarchar(50) not null,
 TrangThaiId int foreign key references TrangThaiBan(Id) not null,
 GhiChu nvarchar(100)
)

create table SuKien(
	Id int primary key identity,
	TenSuKien nvarchar(50) not null,
	NgayDienRa date not null,
	MoTa nvarchar(100) default ''
)

create table DatBanTruoc(
	Id int primary key identity,
	BanId int  foreign key references Ban(Id) not null,
	TenNguoiDat nvarchar(50) not null,
	TaiKhoanDatId int not null foreign key references TaiKhoan(Id),
	SDT varchar(11) not null,
	NgayDat date not null,
	NgaySuDung date not null,
	MoTa nvarchar(100) default ''
)


INSERT INTO LoaiMonAn (TenLoai) VALUES 
(N'Đồ Uống Nóng'), 
(N'Đồ Uống Lạnh'), 
(N'Cocktails'), 
(N'Bia'), 
(N'Rượu Vang'), 
(N'Nước Ép Trái Cây');

INSERT INTO MonAn
VALUES 
  ('Cocktail Fruit Punch', 1,4.5, 1, 'fruit_punch.jpg', N'Một loại cocktail trái cây sảo vị.'),
  ('Margarita', 1, 7.50, 1, 'margarita.jpg', N'Margarita cổ điển với một chút chanh.'),
  ('Chicken Wings', 2, 9.99, 1, 'chicken_wings.jpg', N'Cánh gà cay nồng.'),
  ('Vegetarian Pizza', 2, 12.99, 1, 'vegetarian_pizza.jpg', N'Pizza chay ngon với rau sống tươi.'),
  ('Seafood Pasta', 3, 15.99, 1, 'seafood_pasta.jpg', N'Mì hải sản phong cách Ý với tỏi và thảo mộc.'),
  ('Chocolate Martini', 1, 8.50, 1, 'chocolate_martini.jpg', N'Martini vị sô cô la thơm ngon.'),
  ('Beef Tacos', 2, 10.50, 1, 'beef_tacos.jpg', N'Tacos bò thơm ngon với salsa và guacamole.'),
  ('Caprese Salad', 2, 6.99, 1, 'caprese_salad.jpg', N'Salad Caprese cổ điển với cà chua và phô mai tươi.'),
  ('Shrimp Scampi', 3, 14.75, 1, 'shrimp_scampi.jpg', N'Shrimp scampi với bơ tỏi.'),
  ('Blue Lagoon', 1, 9.25, 1, 'blue_lagoon.jpg', N'Cocktail Blue Lagoon độc đáo.'),
  ('Nachos Supreme', 2, 11.25, 1, 'nachos_supreme.jpg', N'Nachos thượng hạng với phô mai, guacamole và kem chua.')


  INSERT INTO NguyenLieu (Ten, HinhAnh, GiaBan)
VALUES 
  (N'Rượu vodka', 'vodka.jpg', 25.99),
  (N'Dâu tây', 'dau_tay.jpg', 3.50),
  (N'Gà cánh cụt', 'ga_canh_cut.jpg', 7.99),
  (N'Bột pizza', 'bot_pizza.jpg', 2.99),
  (N'Mì Ý', 'mi_y.jpg', 1.75),
  (N'Chocolate liqueur', 'chocolate_liqueur.jpg', 12.50),
  (N'Nước sốt cay', 'nuoc_sot_cay.jpg', 4.25),
  (N'Bò hầm', 'bo_ham.jpg', 9.75),
  (N'Sốt cà chua', 'sot_ca_chua.jpg', 2.25),
  (N'Rượu rum', 'rum.jpg', 18.50),
  (N'Bánh pizza', 'banh_pizza.jpg', 3.99),
  (N'Tôm', 'tom.jpg', 10.99),
  (N'Syrup sô cô la', 'syrup_so_co_la.jpg', 6.25),
  (N'Thịt bò xay', 'thit_bo_xay.jpg', 8.99),
  (N'Dầu olive', 'dau_olive.jpg', 5.75),
  (N'Bơ tỏi', 'bo_toi.jpg', 1.99),
  (N'Cà chua', 'ca_chua.jpg', 1.50),
  ('Phô mai mozzarella', 'pho_mai_mozzarella.jpg', 7.25);


  INSERT INTO CongThuc (MonAnId, NguyenLieuId, DonVi, SoLuong)
VALUES 
  (1, 1, 'lọ', 1),
  (1, 2, 'gói', 1),
  (1, 3, 'lọ', 1),
  (1, 4, 'gói', 2),
  (1, 5, 'lọ', 1),
  (2, 6, 'lọ', 1),
  (2, 7, 'gói', 1),
  (2, 8, 'kg', 0.5),
  (2, 9, 'lọ', 1),
  (2, 10, 'gói', 1),
  (3, 11, 'gói', 2),
  (3, 12, 'kg', 0.3),
  (3, 13, 'lọ', 1),
  (3, 14, 'kg', 0.5),
  (4, 15, 'lọ', 1),
  (4, 16, 'gói', 1),
  (4, 17, 'kg', 0.7),
  (5, 18, 'lọ', 1),
  (5, 18, 'gói', 1),
  (6, 3, 'gói', 2), -- Gà cánh cụt
  (6, 7, 'gói', 1), -- Nước sốt cay
  (6, 16, 'gram', 150), -- Bơ tỏi
  (6, 15, 'gram', 200),
  (7, 4, 'gói', 1), -- Bột pizza
  (7, 9, 'ml', 50), -- Sốt cà chua
  (7, 16, 'gram', 100),
  (8, 11, 'gram', 150), -- Tôm
  (8, 6, 'ml', 75),
  (9, 14, 'gram', 200), -- Thịt bò xay
  (9, 11, 'gram', 100), -- Tôm
  (9, 8, 'ml', 50),
  (10, 17, 'gram', 150), -- Rau xào
  (10, 10, 'ml', 30),
  (11, 2, 'gói', 1), -- Dâu tây
  (11, 18, 'gram', 200); -- Phô mai mozzarella

  INSERT INTO TrangThaiTonKho (Ten) VALUES
(N'Còn Hàng'),
(N'Hết Hàng'),
(N'Hết Hạn');

INSERT INTO NhaCungCap (Ten, DiaChi, Sdt, Email)
VALUES 
  (N'Nhà cung cấp A', 'Địa chỉ A', '0123456789', 'emailA@gmail.com'),
  (N'Nhà cung cấp B', 'Địa chỉ B', '0987654321', 'emailB@gmail.com'),
  (N'Nhà cung cấp C', 'Địa chỉ C', '0123456780', 'emailC@gmail.com'),
  (N'Nhà cung cấp D', 'Địa chỉ D', '0987654312', 'emailD@gmail.com'),
  (N'Nhà cung cấp E', 'Địa chỉ E', '0123456781', 'emailE@gmail.com'),
  (N'Nhà cung cấp F', 'Địa chỉ F', '0987654323', 'emailF@gmail.com'),
  (N'Nhà cung cấp G', 'Địa chỉ G', '0123456782', 'emailG@gmail.com'),
  (N'Nhà cung cấp H', 'Địa chỉ H', '0987654324', 'emailH@gmail.com'),
  (N'Nhà cung cấp I', 'Địa chỉ I', '0123456783', 'emailI@gmail.com'),
  (N'Nhà cung cấp J', 'Địa chỉ J', '0987654325', 'emailJ@gmail.com');

  INSERT INTO TonKho (NguyenLieuId, SoLuong, DonVi, NhacungcapId, GiaNhap, TrangThaiId, NgayNhap, NgayHetHan)
VALUES 
  (1, 50, N'Chai',1, 25.99, 1, '2023-01-01', '2023-12-31'),
  (2, 100, N'Gói',2, 3.50, 1, '2023-01-01', '2023-12-31'),
  (3, 30, N'Gói',3, 7.99, 1, '2023-01-01', '2023-12-31'),
  (4, 20, N'Gói',4, 2.99, 1, '2023-01-01', '2023-12-31'),
  (5, 80, N'Gói',5, 1.75, 1, '2023-01-01', '2023-12-31'),
  (6, 40, N'Chai',6, 12.50, 1, '2023-01-01', '2023-12-31'),
  (7, 60, N'Chai',7, 4.25, 1, '2023-01-01', '2023-12-31'),
  (8, 25, N'Gói',8, 9.75, 1, '2023-01-01', '2023-12-31'),
  (9, 35, N'Chai',9, 2.25, 1, '2023-01-01', '2023-12-31'),
  (10, 15, N'Chai',10, 18.50, 1, '2023-01-01', '2023-12-31'),
  (11, 50, N'Gói',1, 3.99, 1, '2023-01-01', '2023-12-31'),
  (12, 70, N'Kg',2, 10.99, 1, '2023-01-01', '2023-12-31'),
  (13, 45, N'Chai',3, 6.25, 1, '2023-01-01', '2023-12-31'),
  (14, 55, N'Kg',4, 8.99, 1, '2023-01-01', '2023-12-31'),
  (15, 90, N'Chai',5, 5.75, 1, '2023-01-01', '2023-12-31'),
  (16, 60, N'Kg',6, 1.99, 1, '2023-01-01', '2023-12-31'),
  (17, 40, N'Kg',7, 1.50, 1, '2023-01-01', '2023-12-31'),
  (18, 25, N'Kg',8, 7.25, 1, '2023-01-01', '2023-12-31');

  /*Chuyển tiền Mỹ sang tiền Việt*/
  update MonAn
  set Gia = Convert(money, ROUND(CONVERT(float, Gia),1) * 24000)

   update NguyenLieu
  set GiaBan = Convert(money, ROUND(CONVERT(float, GiaBan),1) * 24000)

   update TonKho
  set GiaNhap = Convert(money, ROUND(CONVERT(float, GiaNhap),1) * 24000)

  select * from TonKho;  
  select * from MonAn;
  select * from LoaiMonAn;
  select * from CongThuc;
  select * from NguyenLieu
  select * from TrangThaiTonKho