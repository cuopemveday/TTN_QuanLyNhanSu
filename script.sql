USE [QUANLINHANSU]
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHI_DANHSACHNHANVIEN_THEOMA]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PR_HIENTHI_DANHSACHNHANVIEN_THEOMA]
	-- Add the parameters for the stored procedure here
	@MANV NVARCHAR(10)
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM tbl_NhanVien WHERE MaNV = @MANV
END
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHI_DANHSACHNHANVIEN_THEOTEN]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PR_HIENTHI_DANHSACHNHANVIEN_THEOTEN]
	-- Add the parameters for the stored procedure here
	@MANV NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM tbl_NhanVien WHERE TenNV = @MANV
END
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHI_KHENTHUONG_ALL]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PR_HIENTHI_KHENTHUONG_ALL]
	-- Add the parameters for the stored procedure here
	--@MANV NVARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT TenNV,tbl_TongLuong.MaNV,tbl_TongLuong.HSL,tbl_TongLuong.HST,TienLuong,TienThuong, TienLuong + TienThuong as TONGLUONG
	FROM tbl_NhanVien,tbl_Thuong,tbl_Luong,tbl_TongLuong
	where tbl_NhanVien.MaNV = tbl_TongLuong.MaNV and tbl_TongLuong.HSL = tbl_Luong.HSL and tbl_TongLuong.HST = tbl_Thuong.HST
END
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHI_KHENTHUONG_ma]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PR_HIENTHI_KHENTHUONG_ma]
	

AS
BEGIN
	SET NOCOUNT ON;

   select MaNV
	from tbl_TongLuong
END
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHI_KHENTHUONG_ten]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PR_HIENTHI_KHENTHUONG_ten]

AS
BEGIN
	SET NOCOUNT ON;

	select tbl_NhanVien.TenNV
	from tbl_TongLuong , tbl_NhanVien
	WHERE tbl_TongLuong.MaNV = tbl_NhanVien.MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHI_KHENTHUONG_theoma]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PR_HIENTHI_KHENTHUONG_theoma]
	-- Add the parameters for the stored procedure here
	@MANV NVARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	SELECT TenNV,tbl_TongLuong.MaNV,tbl_TongLuong.HSL,tbl_TongLuong.HST,TienLuong,TienThuong, TienLuong + TienThuong as TONGLUONG
	FROM tbl_NhanVien,tbl_Thuong,tbl_Luong,tbl_TongLuong
	where tbl_NhanVien.MaNV = tbl_TongLuong.MaNV and tbl_TongLuong.HSL = tbl_Luong.HSL and tbl_TongLuong.HST = tbl_Thuong.HST and tbl_TongLuong.MaNV = @MANV
END
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHI_KHENTHUONG_theoten]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PR_HIENTHI_KHENTHUONG_theoten]
	-- Add the parameters for the stored procedure here
	@MANV NVARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	SELECT TenNV,tbl_TongLuong.MaNV,tbl_TongLuong.HSL,tbl_TongLuong.HST,TienLuong,TienThuong, TienLuong + TienThuong as TONGLUONG
	FROM tbl_NhanVien,tbl_Thuong,tbl_Luong,tbl_TongLuong
	where tbl_NhanVien.MaNV = tbl_TongLuong.MaNV and tbl_TongLuong.HSL = tbl_Luong.HSL and tbl_TongLuong.HST = tbl_Thuong.HST and tbl_NhanVien.TenNV = @MANV
END
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHI_NV_ALL]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC   [dbo].[PR_HIENTHI_NV_ALL]
AS
BEGIN
SELECT tbl_NhanVien.MaNV,tbl_NhanVien.TenNV, GioiTinh, tbl_NhanVien.DienThoai,DiaChi,tbl_NhanVien.Email,NgaySinh, NoiCap, NgayCap,SoCMND,ChuyenMon,MaCV, tbl_Luong.TienLuong + tbl_Thuong.TienThuong as TongLuong
	FROM tbl_NhanVien,tbl_Thuong,tbl_Luong,tbl_TongLuong
	where tbl_NhanVien.MaNV = tbl_TongLuong.MaNV and tbl_TongLuong.HSL = tbl_Luong.HSL and tbl_TongLuong.HST = tbl_Thuong.HST 
END
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHI_PB_ALL]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC   [dbo].[PR_HIENTHI_PB_ALL]
AS
BEGIN
SELECT * FROM tbl_PhongBan
END
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHI_PB_MA]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PR_HIENTHI_PB_MA]
	-- Add the parameters for the stored procedure here
	@MANV NVARCHAR(10)
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM tbl_PhongBan WHERE MaPB = @MANV
END
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHI_PB_TEN]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PR_HIENTHI_PB_TEN]
	-- Add the parameters for the stored procedure here
	@MANV NVARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM tbl_PhongBan WHERE TenPB = @MANV
END
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHIDANGNHAP_ALL]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC   [dbo].[PR_HIENTHIDANGNHAP_ALL]
AS
BEGIN
SELECT * FROM tbl_DangNhap
END
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHITRANGCHU_ALL]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC   [dbo].[PR_HIENTHITRANGCHU_ALL]
AS
BEGIN
SELECT tbl_LamViec.MaPB , tbl_PhongBan.TenPB,tbl_LamViec.MaNV,tbl_NhanVien.TenNV
FROM tbl_PhongBan,tbl_NhanVien,tbl_LamViec
WHERE tbl_LamViec.MaNV = tbl_NhanVien.MaNV and tbl_LamViec.MaPB = tbl_PhongBan.MaPB
END
GO
/****** Object:  StoredProcedure [dbo].[PR_hienthitrangchutheomanhanvien]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[PR_hienthitrangchutheomanhanvien]
	@MANV NVARCHAR(50)
AS
BEGIN
SELECT tbl_LamViec.MaPB , tbl_PhongBan.TenPB,tbl_LamViec.MaNV,tbl_NhanVien.TenNV
FROM tbl_PhongBan,tbl_NhanVien,tbl_LamViec
WHERE tbl_LamViec.MaNV = tbl_NhanVien.MaNV and tbl_LamViec.MaPB = tbl_PhongBan.MaPB and tbl_LamViec.MaNV = @MANV
END
GO
/****** Object:  StoredProcedure [dbo].[PR_hienthitrangchutheomaphongban]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[PR_hienthitrangchutheomaphongban]
	@MANV NVARCHAR(50)
AS
BEGIN
SELECT tbl_LamViec.MaPB , tbl_PhongBan.TenPB,tbl_LamViec.MaNV,tbl_NhanVien.TenNV
FROM tbl_PhongBan,tbl_NhanVien,tbl_LamViec
WHERE tbl_LamViec.MaNV = tbl_NhanVien.MaNV and tbl_LamViec.MaPB = tbl_PhongBan.MaPB and tbl_LamViec.MaPB = @MANV
END
GO
/****** Object:  StoredProcedure [dbo].[PR_hienthitrangchutheotennhanvien]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PR_hienthitrangchutheotennhanvien]
	@MANV NVARCHAR(50)
AS
BEGIN
SELECT tbl_LamViec.MaPB , tbl_PhongBan.TenPB,tbl_LamViec.MaNV,tbl_NhanVien.TenNV
FROM tbl_PhongBan,tbl_NhanVien,tbl_LamViec
WHERE tbl_LamViec.MaNV = tbl_NhanVien.MaNV and tbl_LamViec.MaPB = tbl_PhongBan.MaPB and tbl_NhanVien.TenNV = @MANV
END
GO
/****** Object:  StoredProcedure [dbo].[PR_hienthitrangchutheotenphongban]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[PR_hienthitrangchutheotenphongban]
	@MANV NVARCHAR(50)
AS
BEGIN
SELECT tbl_LamViec.MaPB , tbl_PhongBan.TenPB,tbl_LamViec.MaNV,tbl_NhanVien.TenNV
FROM tbl_PhongBan,tbl_NhanVien,tbl_LamViec
WHERE tbl_LamViec.MaNV = tbl_NhanVien.MaNV and tbl_LamViec.MaPB = tbl_PhongBan.MaPB and tbl_PhongBan.TenPB = @MANV
END
GO
/****** Object:  StoredProcedure [dbo].[PR_laymanhanvien]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_laymanhanvien]
AS
BEGIN
SELECT MaNV FROM tbl_NhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[PR_laymanhanvientrangchu]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_laymanhanvientrangchu]
AS
BEGIN
SELECT MaNV
FROM tbl_NhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[PR_laymaphongban]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_laymaphongban]
AS
BEGIN
SELECT MaPB FROM tbl_PhongBan
END
GO
/****** Object:  StoredProcedure [dbo].[PR_laymaphongbantrangchu]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_laymaphongbantrangchu]
AS
BEGIN
SELECT MaPB
FROM tbl_PhongBan
END
GO
/****** Object:  StoredProcedure [dbo].[PR_laytennhanvien]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_laytennhanvien]
AS
BEGIN
SELECT TenNV FROM tbl_NhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[PR_laytennhanvientrangchu]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_laytennhanvientrangchu]
AS
BEGIN
SELECT TenNV
FROM tbl_NhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[PR_laytenphongban]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_laytenphongban]
AS
BEGIN
SELECT TenPB FROM tbl_PhongBan
END
GO
/****** Object:  StoredProcedure [dbo].[PR_laytenphongbantrangchu]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_laytenphongbantrangchu]
AS
BEGIN
SELECT TenPB
FROM tbl_PhongBan
END
GO
/****** Object:  StoredProcedure [dbo].[PR_SUA_DANGNHAP]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[PR_SUA_DANGNHAP]
@manv nvarchar(50),
@tennv nvarchar(50), 
@matp nvarchar(50)

AS
BEGIN
UPDATE tbl_DangNhap
SET 
PassWord = @tennv,
Quyen = @matp

WHERE UserName = @manv
END
GO
/****** Object:  StoredProcedure [dbo].[PR_SUA_KHENTHUONG]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROC [dbo].[PR_SUA_KHENTHUONG]
@manv nvarchar(50),
@tennv nvarchar(50), 
@matp nvarchar(50)


AS
BEGIN
UPDATE tbl_TongLuong
SET 
HST = @tennv,
HSL= @matp

WHERE MaNV = @manv
END
GO
/****** Object:  StoredProcedure [dbo].[PR_SUA_LAMVIEC]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_SUA_LAMVIEC]
@MA nvarchar(50) , 
@na nvarchar(50)
AS 
BEGIN
update tbl_LamViec
set MaPB = @MA
WHERE MaNV = @na
END
GO
/****** Object:  StoredProcedure [dbo].[PR_SUA_NHANVIEN]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[PR_SUA_NHANVIEN]
@manv nvarchar(50),
@tennv nvarchar(50), 
@gioitinh nvarchar(50),  
@diachi nvarchar(50), 
@dienthoai nvarchar(50),  
@email nvarchar(50),  
@ngaysinh nvarchar(50),  
@socmnd nvarchar(50),
 @noicap nvarchar(50), 
  @ngaycap nvarchar(50),  
  @chuyenmon nvarchar(50),
   @macv nvarchar(50)
AS
BEGIN
---DECLARE @MALOP NVARCHAR(10);
--SELECT @MALOP=MALOP FROM tbl_LOP WHERE TENLOP=@TENLOP
UPDATE tbl_NhanVien
SET 
TenNV = @tennv,
GioiTinh = @gioitinh,
DiaChi = @diachi,
DienThoai= @dienthoai,
Email= Email,
NgaySinh=@ngaysinh,
SoCMND=@socmnd,
NoiCap=@noicap,
NgayCap = @ngaycap,
ChuyenMon = @chuyenmon,
MaCV = @macv
WHERE MaNV = @manv
END
GO
/****** Object:  StoredProcedure [dbo].[PR_SUA_PHONGBAN]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_SUA_PHONGBAN]
@manv nvarchar(50),
@tennv nvarchar(50), 
@matp nvarchar(50),  
@diadiem nvarchar(50), 
@dienthoai nvarchar(50),  
@email nvarchar(50)

AS
BEGIN
UPDATE tbl_PhongBan
SET 
TenPB = @tennv,
MaTP = @matp,
DiaDiem= @diadiem,
DienThoai= @dienthoai,
Email= Email

WHERE MaPB = @manv
END
GO
/****** Object:  StoredProcedure [dbo].[PR_THEM_DANGNHAP]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC   [dbo].[PR_THEM_DANGNHAP]
@manv nvarchar(50),
@tennv nvarchar(50), 
@matp nvarchar(50)

AS
BEGIN
INSERT INTO tbl_DangNhap(UserName,PassWord,Quyen)
VALUES (@manv ,
@tennv , 
@matp )
END
GO
/****** Object:  StoredProcedure [dbo].[PR_THEM_NHANVIEN]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_THEM_NHANVIEN]
@manv nvarchar(50),
@tennv nvarchar(50), 
@gioitinh nvarchar(50),  
@diachi nvarchar(50), 
@dienthoai nvarchar(50),  
@email nvarchar(50),  
@ngaysinh nvarchar(50),  
@socmnd nvarchar(50),
 @noicap nvarchar(50), 
  @ngaycap nvarchar(50),  
  @chuyenmon nvarchar(50),
   @macv nvarchar(50)
AS
BEGIN

--INSERT INTO  tbl_ChucVu(MaCV)
--VALUES (@macv)
--DECLARE @MAHH NVARCHAR(10), @MAHV NVARCHAR(10), @MABM NVARCHAR(10)
--SELECT @MAHH = (SELECT MAHH FROM tbl_HOCHAM WHERE HOCHAM = @HOCHAM)
--SELECT @MAHV = (SELECT MAHV FROM tbl_HOCVI WHERE HOCVI = @HOCVI)
--SELECT @MABM = (SELECT MABM FROM tbl_BOMON WHERE MABM = @MABM)
INSERT INTO tbl_NhanVien(MaNV,TenNV,GioiTinh,DiaChi,DienThoai,Email,NgaySinh,SoCMND,NoiCap,NgayCap,ChuyenMon,MaCV)
VALUES (@manv ,
@tennv , 
@gioitinh ,  
@diachi , 
@dienthoai ,  
@email ,  
@ngaysinh ,  
@socmnd ,
 @noicap , 
  @ngaycap ,  
  @chuyenmon ,
   @macv)
   INSERT INTO tbl_TongLuong(MaNV,HST,HSL)
VALUES (@manv, '0', '0')
   INSERT INTO tbl_LamViec(MaPB,MaNV)
VALUES ('PB1',@manv)
END
GO
/****** Object:  StoredProcedure [dbo].[PR_THEM_PHONGBAN]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_THEM_PHONGBAN]
@manv nvarchar(50),
@tennv nvarchar(50), 
@matp nvarchar(50),  
@diadiem nvarchar(50), 
@dienthoai nvarchar(50),  
@email nvarchar(50)

AS
BEGIN
INSERT INTO tbl_PhongBan(MaPB,TenPB,MaTP,DiaDiem,DienThoai,Email)
VALUES (@manv ,
@tennv , 
@matp ,  
@diadiem , 
@dienthoai ,  
@email )


END
GO
/****** Object:  StoredProcedure [dbo].[PR_XACTHUC]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[PR_XACTHUC]
	@username nvarchar(50),
	@password nvarchar(50)
AS
BEGIN
	select quyen from tbl_DangNhap where UserName =@username and PassWord = @password
END

GO
/****** Object:  StoredProcedure [dbo].[PR_XOA_DANGNHAP]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[PR_XOA_DANGNHAP]
	@MASV	NVARCHAR(10)	
AS
BEGIN
DELETE tbl_DangNhap
WHERE UserName = @MASV

END
GO
/****** Object:  StoredProcedure [dbo].[PR_XOA_NHANVIEN]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_XOA_NHANVIEN]
	@MASV	NVARCHAR(10)	
AS
BEGIN
DELETE tbl_TongLuong
WHERE MaNV = @MASV
DELETE tbl_LamViec
WHERE MaNV = @MASV
DELETE tbl_NHANVIEN
WHERE MaNV = @MASV
END
GO
/****** Object:  StoredProcedure [dbo].[PR_XOA_PHONGBAN]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[PR_XOA_PHONGBAN]
	@MASV	NVARCHAR(10)	
AS
BEGIN
DELETE tbl_PhongBan
WHERE MaPB = @MASV

END
GO
/****** Object:  Table [dbo].[tbl_ChucVu]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ChucVu](
	[MaCV] [nvarchar](50) NOT NULL,
	[TenCV] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_DangNhap]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_DangNhap](
	[UserName] [nvarchar](50) NOT NULL,
	[PassWord] [nvarchar](50) NULL,
	[Quyen] [int] NULL,
 CONSTRAINT [PK_tbl_DangNhap] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_LamViec]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_LamViec](
	[MaPB] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_LamViec] PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC,
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Luong]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Luong](
	[HSL] [nvarchar](50) NOT NULL,
	[TienLuong] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_Luong] PRIMARY KEY CLUSTERED 
(
	[HSL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_NhanVien]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_NhanVien](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgaySinh] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[SoCMND] [nvarchar](50) NULL,
	[NoiCap] [nvarchar](50) NULL,
	[NgayCap] [nvarchar](50) NULL,
	[ChuyenMon] [nvarchar](50) NULL,
	[MaCV] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_PhongBan]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PhongBan](
	[MaPB] [nvarchar](50) NOT NULL,
	[TenPB] [nvarchar](50) NULL,
	[MaTP] [nvarchar](50) NULL,
	[DiaDiem] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_PhongBan1] PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Thuong]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Thuong](
	[HST] [nvarchar](50) NOT NULL,
	[TienThuong] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_Thuong] PRIMARY KEY CLUSTERED 
(
	[HST] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_TongLuong]    Script Date: 10/10/2016 11:17:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_TongLuong](
	[MaNV] [nvarchar](50) NOT NULL,
	[HSL] [nvarchar](50) NOT NULL,
	[HST] [nvarchar](50) NOT NULL,
	[TongLuong] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_TongLuong] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[HSL] ASC,
	[HST] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[tbl_ChucVu] ([MaCV], [TenCV]) VALUES (N'1', N'GIAM DOC')
INSERT [dbo].[tbl_ChucVu] ([MaCV], [TenCV]) VALUES (N'2', N'NHAN VIEN')
INSERT [dbo].[tbl_ChucVu] ([MaCV], [TenCV]) VALUES (N'3 ', N'TRUONG PHONG')
INSERT [dbo].[tbl_DangNhap] ([UserName], [PassWord], [Quyen]) VALUES (N'ADMIN', N'123', 1)
INSERT [dbo].[tbl_DangNhap] ([UserName], [PassWord], [Quyen]) VALUES (N'huy', N'123', 2)
INSERT [dbo].[tbl_DangNhap] ([UserName], [PassWord], [Quyen]) VALUES (N'sever', N'123', 3)
INSERT [dbo].[tbl_DangNhap] ([UserName], [PassWord], [Quyen]) VALUES (N'Thieugt95', N'123', 1)
INSERT [dbo].[tbl_LamViec] ([MaPB], [MaNV]) VALUES (N'PB1', N'NV3')
INSERT [dbo].[tbl_LamViec] ([MaPB], [MaNV]) VALUES (N'PB1', N'NV7')
INSERT [dbo].[tbl_LamViec] ([MaPB], [MaNV]) VALUES (N'PB1', N'NV8')
INSERT [dbo].[tbl_LamViec] ([MaPB], [MaNV]) VALUES (N'PB2', N'NV1')
INSERT [dbo].[tbl_LamViec] ([MaPB], [MaNV]) VALUES (N'PB2', N'NV2')
INSERT [dbo].[tbl_LamViec] ([MaPB], [MaNV]) VALUES (N'PB3', N'NV4')
INSERT [dbo].[tbl_Luong] ([HSL], [TienLuong]) VALUES (N'0', N'0')
INSERT [dbo].[tbl_Luong] ([HSL], [TienLuong]) VALUES (N'1', N'1000')
INSERT [dbo].[tbl_Luong] ([HSL], [TienLuong]) VALUES (N'2', N'2000')
INSERT [dbo].[tbl_Luong] ([HSL], [TienLuong]) VALUES (N'3', N'2500')
INSERT [dbo].[tbl_NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [Email], [SoCMND], [NoiCap], [NgayCap], [ChuyenMon], [MaCV]) VALUES (N'NV1', N'NGUYEN HUU HUY', N'NAM', N'15/08/1995', N'0972693571', N'GIA NGHIA', NULL, N'245233769', N'DAK NONG', NULL, N'IT', N'1')
INSERT [dbo].[tbl_NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [Email], [SoCMND], [NoiCap], [NgayCap], [ChuyenMon], [MaCV]) VALUES (N'NV2', N'NGUYEN DUY THIEN HIEU', N'NAM', N'06/09/1995', N'01354', N'122223333', NULL, N'54444', N'NAM DINH', N'', N'PV', NULL)
INSERT [dbo].[tbl_NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [Email], [SoCMND], [NoiCap], [NgayCap], [ChuyenMon], [MaCV]) VALUES (N'NV3', N'PHAN TRONG DUY', N'NU', N'19/06/1995', N'12354697', N'GIA LAI', NULL, N'123456789', N'NAM DINH', NULL, N'BT', N'3')
INSERT [dbo].[tbl_NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [Email], [SoCMND], [NoiCap], [NgayCap], [ChuyenMon], [MaCV]) VALUES (N'NV4', N'NGUYEN HUU HUY', N'NAM', N'15/08/1995', N'0972693571', N'GIA NGHIA', N'', N'245233769', N'DAK NONG', N'', N'IT', NULL)
INSERT [dbo].[tbl_NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [Email], [SoCMND], [NoiCap], [NgayCap], [ChuyenMon], [MaCV]) VALUES (N'NV5', N'DOAN VAN THIEU', N'NU', N'', N'NAM DINH', N'12546325', NULL, N'456987231', N'NAMDINH', N'', N'IT', NULL)
INSERT [dbo].[tbl_NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [Email], [SoCMND], [NoiCap], [NgayCap], [ChuyenMon], [MaCV]) VALUES (N'NV6', N'NGUYEN HUU HUY', N'NAM', N'15/08/1995', N'GIA NGHIA', N'0972693571', N'', N'245233769', N'DAK NONG', N'', N'IT', NULL)
INSERT [dbo].[tbl_NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [Email], [SoCMND], [NoiCap], [NgayCap], [ChuyenMon], [MaCV]) VALUES (N'NV7', N'DOA', N'NU', N'', N'12546325', N'NAM DINH', N'', N'456987231', N'NAMDINH', N'', N'hg', NULL)
INSERT [dbo].[tbl_NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [Email], [SoCMND], [NoiCap], [NgayCap], [ChuyenMon], [MaCV]) VALUES (N'NV8', N'DOA', N'NU', N'', N'NAM DINH', N'12546325', N'', N'456987231', N'NAMDINH', N'', N'hg', NULL)
INSERT [dbo].[tbl_PhongBan] ([MaPB], [TenPB], [MaTP], [DiaDiem], [DienThoai], [Email]) VALUES (N'PB1', N'HANH CHINH', N'NV2', N'H5', N'0133678965', NULL)
INSERT [dbo].[tbl_PhongBan] ([MaPB], [TenPB], [MaTP], [DiaDiem], [DienThoai], [Email]) VALUES (N'PB2', N'CONG NGHE', N'NV3', N'S11', N'0124569745', NULL)
INSERT [dbo].[tbl_PhongBan] ([MaPB], [TenPB], [MaTP], [DiaDiem], [DienThoai], [Email]) VALUES (N'PB3', N'TIN HOC', NULL, N'S10', NULL, NULL)
INSERT [dbo].[tbl_Thuong] ([HST], [TienThuong]) VALUES (N'0', N'0')
INSERT [dbo].[tbl_Thuong] ([HST], [TienThuong]) VALUES (N'1', N'500')
INSERT [dbo].[tbl_Thuong] ([HST], [TienThuong]) VALUES (N'2', N'400')
INSERT [dbo].[tbl_Thuong] ([HST], [TienThuong]) VALUES (N'3', N'200')
INSERT [dbo].[tbl_TongLuong] ([MaNV], [HSL], [HST], [TongLuong]) VALUES (N'NV1', N'2', N'3', NULL)
INSERT [dbo].[tbl_TongLuong] ([MaNV], [HSL], [HST], [TongLuong]) VALUES (N'NV2', N'3', N'3', NULL)
INSERT [dbo].[tbl_TongLuong] ([MaNV], [HSL], [HST], [TongLuong]) VALUES (N'NV3', N'2', N'2', NULL)
INSERT [dbo].[tbl_TongLuong] ([MaNV], [HSL], [HST], [TongLuong]) VALUES (N'NV5', N'1', N'1', NULL)
INSERT [dbo].[tbl_TongLuong] ([MaNV], [HSL], [HST], [TongLuong]) VALUES (N'NV6', N'1', N'1', NULL)
INSERT [dbo].[tbl_TongLuong] ([MaNV], [HSL], [HST], [TongLuong]) VALUES (N'NV7', N'3', N'3', NULL)
INSERT [dbo].[tbl_TongLuong] ([MaNV], [HSL], [HST], [TongLuong]) VALUES (N'NV8', N'2', N'2', NULL)
ALTER TABLE [dbo].[tbl_LamViec]  WITH CHECK ADD  CONSTRAINT [FK_tbl_LamViec_tbl_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tbl_NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tbl_LamViec] CHECK CONSTRAINT [FK_tbl_LamViec_tbl_NhanVien]
GO
ALTER TABLE [dbo].[tbl_LamViec]  WITH CHECK ADD  CONSTRAINT [FK_tbl_LamViec_tbl_PhongBan] FOREIGN KEY([MaPB])
REFERENCES [dbo].[tbl_PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[tbl_LamViec] CHECK CONSTRAINT [FK_tbl_LamViec_tbl_PhongBan]
GO
ALTER TABLE [dbo].[tbl_NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tbl_NhanVien_tbl_ChucVu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[tbl_ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[tbl_NhanVien] CHECK CONSTRAINT [FK_tbl_NhanVien_tbl_ChucVu]
GO
ALTER TABLE [dbo].[tbl_TongLuong]  WITH CHECK ADD  CONSTRAINT [FK_tbl_TongLuong_tbl_Luong] FOREIGN KEY([HSL])
REFERENCES [dbo].[tbl_Luong] ([HSL])
GO
ALTER TABLE [dbo].[tbl_TongLuong] CHECK CONSTRAINT [FK_tbl_TongLuong_tbl_Luong]
GO
ALTER TABLE [dbo].[tbl_TongLuong]  WITH CHECK ADD  CONSTRAINT [FK_tbl_TongLuong_tbl_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tbl_NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tbl_TongLuong] CHECK CONSTRAINT [FK_tbl_TongLuong_tbl_NhanVien]
GO
ALTER TABLE [dbo].[tbl_TongLuong]  WITH CHECK ADD  CONSTRAINT [FK_tbl_TongLuong_tbl_Thuong] FOREIGN KEY([HST])
REFERENCES [dbo].[tbl_Thuong] ([HST])
GO
ALTER TABLE [dbo].[tbl_TongLuong] CHECK CONSTRAINT [FK_tbl_TongLuong_tbl_Thuong]
GO
