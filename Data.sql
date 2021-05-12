USE QuanLyNhaHangProject
GO

--Add Data 
--1 THÊM NHANVIEN
--2 THÊM TAIKHOAN
--3 THÊM DANHMUC
--4 THÊM MONNUOC
--5 THÊM BÀN
--6 THÊM HOADON
--7 THÊM CHITIETHOADON
--NHANVIEN
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email)
VALUES (N'Lê', N'Vương', '11/25/1999', N'Thủ Đức', '01642356018', 'vuongvaba1v2@gmail.com')
GO --1
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email)
VALUES (N'Nguyễn', N'Thoa', '06/06/1999', N'Thủ Đức', '0865605956', 'k.thoa@gmail.com')
GO --2
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email)
VALUES (N'Huy', N'Huỳnh', '2/12/1999', N'Q2', '01256314895', 'HuyHuynh@gmail.com')
GO --3
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email)
VALUES (N'Nguyễn', N'Phúc', '3/06/1999', N'Q1', '03625894125', 'N.Phuc@gmail.com')
GO --4
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email)
VALUES (N'Lê', N'Tiến', '03/05/1999', N'Q9', '08516234912', 'L.Tien@gmail.com')
GO --5
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email)
VALUES (N'Nguyễn', N'Minh', '02/08/1999', N'Bình Chánh', '02315648191', 'N.Minh@gmail.com')
GO --6
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email)
VALUES (N'Phúc', N'Đạt', '01/09/1999', N'Q3', '04562563191', 'P.Dat@gmail.com')
GO --7
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email)
VALUES (N'Nguyễn', N'Mai Thiện', '01/01/1999', N'Thủ Đức', '0315264891', 'M.Thien@gmail.com')
GO --8
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email)
VALUES (N'Tấn', N'Tài', '05/01/1999', N'Củ Chi', '01478529642', 'T.Tai@gmail.com')
GO --9
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email)
VALUES (N'Dư', N'Huỳnh', '07/11/1999', N'Thủ Đức', '04568529512', 'D.Huynh@gmail.com')
GO --10
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email)
VALUES (N'Vĩnh', N'Hằng', '06/03/1999', N'Thủ Đức', '01235685913', 'V.Hang@gmail.com')
GO --11

--TAIKHOAN
INSERT INTO TAIKHOAN (IDNhanVien , TaiKhoan , MatKhau , LoaiTaiKhoan) 
VALUES 
('NV001' , 'Vuong' , 'admin' , 1),
('NV002' , 'Thoa' , 'admin' , 1),
('NV003' , 'Huynh' , 'admin' , 2),
('NV004' , 'Phuc' , 'admin' , 2),
('NV005' , 'Tien' , 'admin' , 2),
('NV006' , 'Minh' , 'admin' , 2),
('NV007' , 'Dat' , 'admin' , 2),
('NV008' , 'Thien' , 'admin' , 2),
('NV009' , 'Tai' , 'admin' , 2),
('NV010' , 'Huynh2' , 'admin' , 2),
('NV011' , 'Hang' , 'admin' , 2)
GO

--DANHMUC
INSERT INTO DANHMUC (TenDanhMuc)
VALUES (N'Cafe') , (N'Trà Sữa') , (N'Trà Trái Cây') , (N'Sinh Tố') , (N'Soda') , (N'Topping')
GO

--MONNUOC
	--('Cafe')
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (1 , N'Cafe Đen' , 12)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (1 , N'Cafe Sữa' , 15)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (1 , N'Bạc Sỉu' , 17)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (1 , N'Latte' , 20)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (1 , N'Capochino' , 20)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (1 , N'Epreso' , 22)
	GO
	--('Trà Sữa')
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (2 , N'Trà Sữa Đường Đen' , 30)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (2 , N'Trà Sữa Lài' , 27)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (2 , N'Trà Sữa Chocolate' , 29)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (2 , N'Trà Sữa OLong' , 27)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (2 , N'Trà Sữa Matcha' , 30)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (2 , N'Trà Sữa Đặc Biệt' , 35)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (2 , N'Trà Sữa Siêu To Khổng Lồ' , 40)
	GO
	--('Trà Trái Cây')
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (3 , N'Trà Đào' , 30)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (3 , N'Trà Ổi Hồng' , 30)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (3 , N'Trà Đậu Biếc' , 27)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (3 , N'Trà Chanh Dây' , 27)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (3 , N'Trà Tứ Mùa' , 33)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (3 , N'Trà Nhiệt Đới' , 33)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (3 , N'Trà Bạc Hà' , 27)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (3 , N'Trà Liton' , 25)
	GO
	--('Sinh Tố')
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (4 , N'Sinh Tố Dâu' , 33)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (4 , N'Sinh Tố Xoài' , 30)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (4 , N'Sinh Tố Măng Cầu' , 33)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (4 , N'Sinh Tố Đu Đủ' , 28)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (4 , N'Sinh Tố Sampo' , 28)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (4 , N'Sinh Tố Bơ' , 33)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (4 , N'Sinh Tố Dứa' , 28)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (4 , N'Sinh Tố Tổng Hợp' , 33)
	GO
	--('Soda')
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (5 , N'Soda Táo' , 28)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (5 , N'Soda Bạc Hà' , 28)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (5 , N'Soda Xoài' , 28)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (5 , N'Soda Việt Quất' , 28)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (5 , N'Soda Chanh' , 25)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (5 , N'Soda Nhiệt Đới' , 30)
	GO
	--('Topping')
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (6 , N'Trân Châu Đen' , 5)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (6 , N'Trân Châu Trắng' , 10)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (6 , N'Nha Đam' , 5)
	GO
		INSERT INTO NUOCUONG (IDDanhMuc , TenMon , GiaTien)
	VALUES (6 , N'Thạch Dừa' , 5)
	GO
--THÊM BÀN

INSERT INTO BAN (TenBan, TrangThai)
VALUES (N'Bàn 1' , 0) , (N'Bàn 2' , 0) , (N'Bàn 3' , 0) , (N'Bàn 4' , 0) , (N'Bàn 5' , 0) , (N'Bàn 6' , 0) , (N'Bàn 7' , 0) , (N'Bàn 8' , 0) , (N'Bàn 9' , 0) , (N'Bàn 10' , 0)
GO


--THÊM HÓA ĐƠN
INSERT INTO HOADON (IDNhanVien , NgayLap , TongTien)
VALUES ('NV001' , '06/05/2021 13:50:00' , 91) -- 33 + 28 +30
GO
INSERT INTO HOADON (IDNhanVien , NgayLap , TongTien)
VALUES ('NV002' , '06/05/2021 14:02:00' , 85) -- 25 +33 +27
GO
INSERT INTO HOADON (IDNhanVien , NgayLap , TongTien)
VALUES ('NV003' , '06/05/2021 14:10:00' , 45) --15 + 30
GO
INSERT INTO HOADON (IDNhanVien , NgayLap , TongTien)
VALUES ('NV002' , '06/05/2021 14:30:00' , 42) --15 + 27
GO

----CHITIETHOADON
--INSERT INTO CHITIETHOADON (IDHoaDon , IDMonNuoc, SoLuong , GiaTien)
--VALUES
----HD1
--('7CFFD9CE72' , 'NU018' ,  1 , 33),
--('7CFFD9CE72' , 'NU025' ,  1 , 28),
--('7CFFD9CE72' , 'NU015' ,  1 , 30),
----HD2
--('B129AA937D' , 'NU034' ,  1 , 25),
--('B129AA937D' , 'NU022' ,  1 , 33),
--('B129AA937D' , 'NU016' ,  1 , 27),
----HD3
--('B8E30EC19B' , 'NU002' ,  1 , 15),
--('B8E30EC19B' , 'NU011' ,  1 , 30),
----HD4
--('B8E30EC19B' , 'NU002' ,  1 , 15),
--('B8E30EC19B' , 'NU008' ,  1 , 27)
--GO