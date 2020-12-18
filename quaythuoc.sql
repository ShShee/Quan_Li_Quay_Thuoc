CREATE DATABASE QLQT2020
Go

USE QLQT2020
GO

CREATE TABLE THONGTINCOBAN
(
	id_thongtincoban INT IDENTITY(1,1) PRIMARY KEY,
	ten NVARCHAR(100) NOT NULL,
	diachi NVARCHAR(1000) NOT NULL,
	sodienthoai NVARCHAR(1000) NOT NULL,
)

CREATE TABLE NHANVIEN
(
	id_nhanvien INT IDENTITY(1,1) PRIMARY KEY,
	bangcap NVARCHAR(1000) NOT NULL,
	catruc INT NOT NULL,
	taikhoan NVARCHAR(100),
	matkhau NVARCHAR(100) NOT NULL,
	chucvu NVARCHAR(100) NOT NULL,

	id_thongtincoban INT foreign key references THONGTINCOBAN(id_thongtincoban)
)

CREATE TABLE NHACUNGCAP
(
	id_nhacungcap INT IDENTITY(1,1) PRIMARY KEY,
	giayphep NVARCHAR(100) NOT NULL,

	id_thongtincoban INT foreign key references THONGTINCOBAN(id_thongtincoban)
)

CREATE TABLE PHIEUTONKHO
(
	id_phieutonkho NVARCHAR(100) PRIMARY KEY,
	ngaylap DATETIME not null,

	id_nhanvien INT foreign key references NHANVIEN(id_nhanvien)
)

CREATE TABLE PHIEUDATHANG
(
	id_phieudathang NVARCHAR(100) PRIMARY KEY,
	ngaylap DATETIME not null,

	id_nhanvien INT foreign key references NHANVIEN(id_nhanvien)
)

CREATE TABLE CHITIETDATHANG
(
	id_chitietdathang NVARCHAR(100) PRIMARY KEY,
	tenhanghoa NVARCHAR(100) not null,
	soluong INT not null,

	id_nhacungcap INT foreign key references NHACUNGCAP(id_nhacungcap),
	id_phieudathang NVARCHAR(100) foreign key references PHIEUDATHANG(id_phieudathang)
)

CREATE TABLE PHIEUNHANHANG
(
	id_phieunhanhang NVARCHAR(100) primary key,
	ngaylap DATETIME not null,

	id_nhanvien INT foreign key references NHANVIEN(id_nhanvien),
	id_phieudathang NVARCHAR(100) foreign key references PHIEUDATHANG(id_phieudathang)
)

CREATE TABLE THONGTINBAOQUAN
(
	id_baoquan INT IDENTITY(1,1) PRIMARY KEY,
	khuvuc NVARCHAR(100) NOT NULL,
	vitri INT NOT NULL,
	nhietdo INT NOT NULL,
	cachthuc NVARCHAR(1000) NOT NULL
)

CREATE TABLE THONGTINLUUTRU
(
	id_loaithuoc INT IDENTITY(1,1) PRIMARY KEY,
	soluong INT,
	donluong INT,
	sogiayphep NVARCHAR(100),
	solo NVARCHAR(10),
	nhasanxuat NVARCHAR(1000),
	tenthuoc NVARCHAR(100),
	hansudung DATETIME,
	giathanh NVARCHAR(100),
	huongdansudung NVARCHAR(1000),
	thuocdactri NVARCHAR(10),

	id_baoquan INT foreign key references THONGTINBAOQUAN(id_baoquan),
	id_nhacungcap INT foreign key references NHACUNGCAP(id_nhacungcap),
	id_phieunhanhang NVARCHAR(100) foreign key references PHIEUNHANHANG(id_phieunhanhang)
)

CREATE TABLE CHITIETTONKHO
(
	id_chitiettonkho INT IDENTITY(1,1) PRIMARY KEY,
	soluong INT not null,
	tinhtrang NVARCHAR(20),

	id_phieutonkho NVARCHAR(100) foreign key references PHIEUTONKHO(id_phieutonkho),
	id_loaithuoc INT foreign key references THONGTINLUUTRU(id_loaithuoc)
)

CREATE TABLE THUOC
(
	id_thuoc INT IDENTITY(1,1) PRIMARY KEY,
	soluong INT NOT NULL,
	chatluong NVARCHAR(100) NOT NULL,

	id_loaithuoc INT foreign key references THONGTINLUUTRU(id_loaithuoc)
)

CREATE TABLE BAOHIEMYTE
(
	loaihinh NVARCHAR(100) PRIMARY KEY,
	tile INT
)

CREATE TABLE HOADONBANTHUOC
(
	id_hoadon NVARCHAR(100) PRIMARY KEY,
	ngaylap DATETIME not null,
	tongtien NVARCHAR(100) not null,
	bacsikedon NVARCHAR(100),
	chuandoanbenh NVARCHAR(100),
	sobaohiemyte NVARCHAR(100),

	id_nhanvien INT foreign key references NHANVIEN(id_nhanvien),
	id_thongtincoban INT foreign key references THONGTINCOBAN(id_thongtincoban),
	loaihinh NVARCHAR(100) foreign key references BAOHIEMYTE(loaihinh)
)

CREATE TABLE CHITIETKETHUOC
(
	id_chitietkethuoc INT IDENTITY(1,1) PRIMARY KEY,
	lieuluong INT not null,

	id_thuoc INT foreign key references THUOC(id_thuoc),
	id_hoadon NVARCHAR(100) foreign key references HOADONBANTHUOC(id_hoadon)
)

