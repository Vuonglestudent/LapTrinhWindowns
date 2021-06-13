USE QuanLyNhaHangProject
GO

--CONGVIEC

INSERT INTO CONGVIEC (TenCongViec, LuongCongViec)
VALUES 
(N'Quản Lý' , 2000000) ,
(N'Nhân Viên Bán Hàng' , 800000) ,
(N'Nhân Viên Phụ Vụ' , 1000000) ,
(N'Bảo Vệ' , 1200000),
(N'Nhân Viên Vệ Sinh' , 1000000)
GO


--NHANVIEN
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email , IDCongViec, HinhNV, TrangThai)
VALUES (N'Lê', N'Vương', '11/25/1999', N'Thủ Đức', '01642356018', 'vuongvaba1v2@gmail.com', 1, 'NV001.jpg', 0)
GO --1
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email , IDCongViec, HinhNV, TrangThai)
VALUES (N'Nguyễn', N'Thoa', '06/06/1999', N'Thủ Đức', '0865605956', 'k.thoa@gmail.com', 1, 'NV002.jpg', 0)
GO --2
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email , IDCongViec, HinhNV, TrangThai)
VALUES (N'Huy', N'Huỳnh', '2/12/1999', N'Q2', '01256314895', 'HuyHuynh@gmail.com', 3, 'NV003.jpg', 0)
GO --3
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email , IDCongViec, HinhNV, TrangThai)
VALUES (N'Nguyễn', N'Phúc', '3/06/1999', N'Q1', '03625894125', 'N.Phuc@gmail.com' , 3, 'NV004.jpg', 0)
GO --4
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email , IDCongViec, HinhNV, TrangThai)
VALUES (N'Lê', N'Tiến', '03/05/1999', N'Q9', '08516234912', 'L.Tien@gmail.com' , 2, 'NV005.jpg', 0)
GO --5
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email , IDCongViec, HinhNV, TrangThai)
VALUES (N'Nguyễn', N'Minh', '02/08/1999', N'Bình Chánh', '02315648191', 'N.Minh@gmail.com' , 2, 'NV006.jpg', 0)
GO --6
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email , IDCongViec, HinhNV, TrangThai)
VALUES (N'Phúc', N'Đạt', '01/09/1999', N'Q3', '04562563191', 'P.Dat@gmail.com' , 2, 'NV007.jpg', 0)
GO --7
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email , IDCongViec, HinhNV, TrangThai)
VALUES (N'Nguyễn', N'Mai Thiện', '01/01/1999', N'Thủ Đức', '0315264891', 'M.Thien@gmail.com' , 4 , 'NV008.jpg', 0)
GO --8
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email , IDCongViec, HinhNV, TrangThai)
VALUES (N'Tấn', N'Tài', '05/01/1999', N'Củ Chi', '01478529642', 'T.Tai@gmail.com' , 4, 'NV009.jpg', 0)
GO --9
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email , IDCongViec, HinhNV, TrangThai)
VALUES (N'Dư', N'Huỳnh', '07/11/1999', N'Thủ Đức', '04568529512', 'D.Huynh@gmail.com' , 5, 'NV010.jpg', 0)
GO --10
INSERT INTO NHANVIEN (Ho, Ten, NgaySinh, DiaChi, SDT, Email , IDCongViec, HinhNV, TrangThai)
VALUES (N'Vĩnh', N'Hằng', '06/03/1999', N'Thủ Đức', '01235685913', 'V.Hang@gmail.com' , 5, 'NV011.jpg', 0)
GO --11

--TAIKHOAN
INSERT INTO TAIKHOAN (IDNhanVien , TaiKhoan , MatKhau) 
VALUES 
('NV001' , 'Vuong' , 'admin'),
('NV002' , 'Thoa' , 'admin'),
('NV003' , 'Huynh' , 'admin'),
('NV004' , 'Phuc' , 'admin'),
('NV005' , 'Tien' , 'admin'),
('NV006' , 'Minh' , 'admin'),
('NV007' , 'Dat' , 'admin'),
('NV008' , 'Thien' , 'admin'),
('NV009' , 'Tai' , 'admin'),
('NV010' , 'Huynh2' , 'admin'),
('NV011' , 'Hang' , 'admin')
GO

--DANHMUC
INSERT INTO DANHMUC (TenDanhMuc, TrangThai)
VALUES (N'Cafe', 0) , (N'Trà Sữa', 0) , (N'Trà Trái Cây', 0) , (N'Sinh Tố', 0) , (N'Soda', 0) , (N'Topping', 0), (N'Bún', 0), (N'Cơm', 0), (N'Gà',0), (N'Lẩu', 0)
GO

--MONAN
	--('Cafe')
		INSERT INTO MONAN(IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (1 , N'Cafe Đen' , 12000, 'MA001.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (1 , N'Cafe Sữa' , 15000, 'MA002.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (1 , N'Bạc Sỉu' , 17000, 'MA003.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (1 , N'Latte' , 20000, 'MA004.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (1 , N'Capochino' , 20000, 'MA005.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (1 , N'Epreso' , 22000, 'MA006.jpg', 0)
	GO
	--('Trà Sữa')
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (2 , N'Trà Sữa Đường Đen' , 30000, 'MA012.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (2 , N'Trà Sữa Chocolate' , 29000, 'MA019.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (2 , N'Trà Sữa OLong' , 27000, 'MA018.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (2 , N'Trà Sữa Matcha' , 30000, 'MA014.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (2 , N'Trà Sữa Matcha Đậu Đỏ' , 35000, 'MA017.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (2 , N'Trà Sữa Thái đỏ' , 25000, 'MA021.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (2 , N'Trà Sữa Dâu' , 25000, 'MA013.jpg', 0)
	GO
	--('Trà Trái Cây')
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (3 , N'Trà Đào' , 30000, 'MA011.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (3 , N'Trà Xanh' , 30000, 'MA007.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (3 , N'Trà Mật Ong' , 27000, 'MA008.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (3 , N'Trà Hoa Cúc' , 27000, 'MA009.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (3 , N'Trà Gừng' , 33000, 'MA010.jpg', 0)
	GO
	--('Sinh Tố')
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (4 , N'Sinh Tố Dâu' , 33000, 'MA022.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (4 , N'Sinh Tố Xoài' , 30000, 'MA023.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (4 , N'Sinh Tố Măng Cầu' , 33000, 'MA024.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (4 , N'Sinh Tố Đu Đủ' , 28000, 'MA025.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (4 , N'Sinh Tố Sampo' , 28000, 'MA026.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (4 , N'Sinh Tố Bơ' , 33000, 'MA027.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (4 , N'Sinh Tố Dứa' , 28000, 'MA028.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (4 , N'Sinh Tố Tổng Hợp' , 33000, 'MA029.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (4 , N'Sinh Tố Việt Quất' , 30000, 'MA015.jpg', 0)
	GO
	--('Soda')
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (5 , N'Soda Táo' , 28000, 'MA030.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (5 , N'Soda Bạc Hà' , 28000, 'MA031.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (5 , N'Soda Xoài' , 28000, 'MA032.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (5 , N'Soda Việt Quất' , 28000, 'MA033.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (5 , N'Soda Chanh' , 25000, 'MA034.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (5 , N'Soda Nhiệt Đới' , 30000, 'MA035.jpg', 0)
	GO
	--('Topping')
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (6 , N'Trân Châu Đen' , 5000, 'MA036.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (6 , N'Trân Châu Trắng' , 10000, 'MA037.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (6 , N'Nha Đam' , 5000, 'MA038.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (6 , N'Thạch Dừa' , 5000, 'MA039.jpg', 0)
	GO

	--('Bún')
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (7 , N'Bún Riêu' , 40, 'MA040.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (7 , N'Bún Chả Cá' , 45, 'MA041.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (7 , N'Bún Mắm Nêm' , 40, 'MA042.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (7 , N'Bún Thịt Nướng' , 40, 'MA043.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (7 , N'Phở bò' , 50, 'MA044.jpg', 0)
	GO
	--('Cơm')
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (8 , N'Cơm Tấm' , 40, 'MA045.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (8 , N'Cơm Gà' , 45, 'MA046.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (8 , N'Cơm Chiên Dương Châu' , 40, 'MA047.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (8 , N'Cơm Hải Sản' , 45, 'MA048.jpg', 0)
	GO
	--('Gà')
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (9 , N'Gà Rán' , 45, 'MA049.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (9 , N'Gà Sốt Đậu' , 50, 'MA050.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (9 , N'Gà Phô Mai' , 65, 'MA051.jpg', 0)
	GO
		INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (9 , N'Gà Chiên Nước Mắm' , 40, 'MA052.jpg', 0)
	GO
	--('Lẩu')
	INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (10 , N'Lẩu Bò' , 80, 'MA053.jpg', 0)
	GO
	INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (10 , N'Lẩu Thái' , 80, 'MA054.jpg', 0)
	GO
	INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (10 , N'Lẩu Hải Sản' , 80, 'MA055.jpg', 0)
	GO
	INSERT INTO MONAN (IDDanhMuc , TenMon , GiaTien, HinhMA, TrangThai)
	VALUES (10 , N'Lẩu Gà Lá Giang' , 80, 'MA056.jpg', 0)
	GO
--THÊM BÀN

INSERT INTO BAN (TenBan, TrangThai, SucChua, TrangThaiXoa)
VALUES (N'Bàn 1' , 0 , 2, 0), 
(N'Bàn 2' , 0 , 2, 0),
(N'Bàn 3' , 0, 2, 0),
(N'Bàn 4' , 0, 4, 0),
(N'Bàn 5' , 0, 4, 0),
(N'Bàn 6' , 0, 4, 0), 
(N'Bàn 7' , 0, 8, 0),
(N'Bàn 8' , 0, 8, 0),
(N'Bàn 9' , 0, 10, 0),
(N'Bàn 10' , 0, 10, 0)
GO


----THÊM HÓA ĐƠN
--INSERT INTO HOADON (IDNhanVien , NgayLap, NgayThanhToan, TongTien, IDBan)
--VALUES ('NV001' , '06/05/2021 13:50:00', '06/05/2021 15:50:00' , 91000, 1) -- 33 + 28 +30
--GO
--INSERT INTO HOADON (IDNhanVien , NgayLap, NgayThanhToan , TongTien, IDBan)
--VALUES ('NV002' , '06/05/2021 14:02:00', '06/05/2021 14:50:00' , 85000, 3) -- 25 +33 +27
--GO
--INSERT INTO HOADON (IDNhanVien , NgayLap, NgayThanhToan, TongTien, IDBan)
--VALUES ('NV003' , '06/05/2021 14:10:00', '06/05/2021 14:30:00',  45000, 6) --15 + 30
--GO
--INSERT INTO HOADON (IDNhanVien , NgayLap, NgayThanhToan, TongTien, IDBan)
--VALUES ('NV002' , '06/05/2021 14:30:00', '06/05/2021 15:50:00',  42000, 5) --15 + 27
--GO

------CHITIETHOADON
--INSERT INTO CHITIETHOADON (IDHoaDon , IDMonAn, SoLuong)-- , GiaTien)
--VALUES
----HD1
--('0C1B0A179F' , 'NU018' ,  1 ),-- 33),
--('0C1B0A179F' , 'NU025' ,  1 ),-- 28),
--('0C1B0A179F' , 'NU015' ,  1 ),-- 30),
----HD2
--('D828343F5A' , 'NU034' ,  1 ),-- 25),
--('D828343F5A' , 'NU022' ,  1 ),-- 33),
--('D828343F5A' , 'NU016' ,  1 ),-- 27),
----HD3
--('01718B9706' , 'NU002' ,  1 ),-- 15),
--('01718B9706' , 'NU011' ,  1 ),-- 30),
----HD4
--('BCB111FEF4' , 'NU002' ,  1 ),-- 15),
--('BCB111FEF4' , 'NU008' ,  1 )-- 27)
--GO