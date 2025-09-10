CREATE TABLE NhanVien (
    MaNV INT PRIMARY KEY IDENTITY(1,1),
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    DiaChi NVARCHAR(200),
    DienThoai VARCHAR(15),
    ChucVu NVARCHAR(50),
    Username AS ('user' + CAST(MaNV AS VARCHAR(10))) PERSISTED UNIQUE,
    Password VARCHAR(50) NOT NULL DEFAULT '1'
);

CREATE TABLE KhachHang (
    MaKH INT PRIMARY KEY IDENTITY(1,1),
    HoTenChuHo NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(200) NOT NULL,
    DienThoai VARCHAR(15),
    NgayDangKy DATE DEFAULT GETDATE(),
    SoHopDong VARCHAR(50) UNIQUE
);

CREATE TABLE DongHoNuoc (
    MaDongHo INT PRIMARY KEY IDENTITY(1,1),
    MaKH INT NOT NULL,
    SoHieu VARCHAR(50) UNIQUE NOT NULL,
    NgayLapDat DATE,
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);

CREATE TABLE ChiSoNuoc (
    MaChiSo INT PRIMARY KEY IDENTITY(1,1),
    MaDongHo INT NOT NULL,
    Thang INT NOT NULL,
    Nam INT NOT NULL,
    ChiSoCu INT NOT NULL,
    ChiSoMoi INT NOT NULL,
    SoTieuThu AS (ChiSoMoi - ChiSoCu) PERSISTED,
    MaNV INT NOT NULL,
    NgayGhi DATE DEFAULT GETDATE(),
    FOREIGN KEY (MaDongHo) REFERENCES DongHoNuoc(MaDongHo),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    CONSTRAINT UQ_ChiSo UNIQUE (MaDongHo, Thang, Nam)
);

CREATE TABLE HoaDon (
    MaHD INT PRIMARY KEY IDENTITY(1,1),
    MaChiSo INT NOT NULL,
    NgayLap DATE DEFAULT GETDATE(),
    SoTien DECIMAL(18,2) NOT NULL,
    TrangThai NVARCHAR(50) DEFAULT N'Chưa thanh toán',
    FOREIGN KEY (MaChiSo) REFERENCES ChiSoNuoc(MaChiSo)
);

-- Thêm nhân viên
CREATE PROCEDURE sp_AddNhanVien
    @HoTen NVARCHAR(100),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10),
    @DiaChi NVARCHAR(200),
    @DienThoai VARCHAR(15),
    @ChucVu NVARCHAR(50)
AS
BEGIN
    INSERT INTO NhanVien(HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, ChucVu)
    VALUES(@HoTen, @NgaySinh, @GioiTinh, @DiaChi, @DienThoai, @ChucVu);
END;
GO

-- Cập nhật nhân viên
CREATE PROCEDURE sp_UpdateNhanVien
    @MaNV INT,
    @HoTen NVARCHAR(100),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10),
    @DiaChi NVARCHAR(200),
    @DienThoai VARCHAR(15),
    @ChucVu NVARCHAR(50)
AS
BEGIN
    UPDATE NhanVien
    SET HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh,
        DiaChi=@DiaChi, DienThoai=@DienThoai, ChucVu=@ChucVu
    WHERE MaNV=@MaNV;
END;
GO

-- Xóa nhân viên
CREATE PROCEDURE sp_DeleteNhanVien
    @MaNV INT
AS
BEGIN
    DELETE FROM NhanVien WHERE MaNV=@MaNV;
END;
GO

-- Lấy danh sách nhân viên
CREATE PROCEDURE sp_GetNhanVien
AS
BEGIN
    SELECT * FROM NhanVien;
END;
GO


-- Khách hàng 
CREATE PROCEDURE sp_AddKhachHang
    @HoTenChuHo NVARCHAR(100),
    @DiaChi NVARCHAR(200),
    @DienThoai VARCHAR(15),
    @SoHopDong VARCHAR(50)
AS
BEGIN
    INSERT INTO KhachHang(HoTenChuHo, DiaChi, DienThoai, SoHopDong)
    VALUES(@HoTenChuHo, @DiaChi, @DienThoai, @SoHopDong);
END;
GO

CREATE PROCEDURE sp_UpdateKhachHang
    @MaKH INT,
    @HoTenChuHo NVARCHAR(100),
    @DiaChi NVARCHAR(200),
    @DienThoai VARCHAR(15),
    @SoHopDong VARCHAR(50)
AS
BEGIN
    UPDATE KhachHang
    SET HoTenChuHo=@HoTenChuHo, DiaChi=@DiaChi, DienThoai=@DienThoai, SoHopDong=@SoHopDong
    WHERE MaKH=@MaKH;
END;
GO

CREATE PROCEDURE sp_DeleteKhachHang
    @MaKH INT
AS
BEGIN
    DELETE FROM KhachHang WHERE MaKH=@MaKH;
END;
GO

CREATE PROCEDURE sp_GetKhachHang
AS
BEGIN
    SELECT * FROM KhachHang;
END;
GO

-- Đồng hồ nước
CREATE PROCEDURE sp_AddDongHoNuoc
    @MaKH INT,
    @SoHieu VARCHAR(50),
    @NgayLapDat DATE
AS
BEGIN
    INSERT INTO DongHoNuoc(MaKH, SoHieu, NgayLapDat)
    VALUES(@MaKH, @SoHieu, @NgayLapDat);
END;
GO

CREATE PROCEDURE sp_UpdateDongHoNuoc
    @MaDongHo INT,
    @MaKH INT,
    @SoHieu VARCHAR(50),
    @NgayLapDat DATE
AS
BEGIN
    UPDATE DongHoNuoc
    SET MaKH=@MaKH, SoHieu=@SoHieu, NgayLapDat=@NgayLapDat
    WHERE MaDongHo=@MaDongHo;
END;
GO

CREATE PROCEDURE sp_DeleteDongHoNuoc
    @MaDongHo INT
AS
BEGIN
    DELETE FROM DongHoNuoc WHERE MaDongHo=@MaDongHo;
END;
GO

CREATE PROCEDURE sp_GetDongHoNuoc
AS
BEGIN
    SELECT * FROM DongHoNuoc;
END;
GO

-- Chỉ số nước 
CREATE PROCEDURE sp_AddChiSoNuoc
    @MaDongHo INT,
    @Thang INT,
    @Nam INT,
    @ChiSoCu INT,
    @ChiSoMoi INT,
    @MaNV INT
AS
BEGIN
    INSERT INTO ChiSoNuoc(MaDongHo, Thang, Nam, ChiSoCu, ChiSoMoi, MaNV)
    VALUES(@MaDongHo, @Thang, @Nam, @ChiSoCu, @ChiSoMoi, @MaNV);
END;
GO

CREATE PROCEDURE sp_UpdateChiSoNuoc
    @MaChiSo INT,
    @ChiSoCu INT,
    @ChiSoMoi INT
AS
BEGIN
    UPDATE ChiSoNuoc
    SET ChiSoCu=@ChiSoCu, ChiSoMoi=@ChiSoMoi
    WHERE MaChiSo=@MaChiSo;
END;
GO

CREATE PROCEDURE sp_DeleteChiSoNuoc
    @MaChiSo INT
AS
BEGIN
    DELETE FROM ChiSoNuoc WHERE MaChiSo=@MaChiSo;
END;
GO

CREATE PROCEDURE sp_GetChiSoNuoc
AS
BEGIN
    SELECT * FROM ChiSoNuoc;
END;
GO

-- Hóa đơn
CREATE PROCEDURE sp_AddHoaDon
    @MaChiSo INT,
    @SoTien DECIMAL(18,2)
AS
BEGIN
    INSERT INTO HoaDon(MaChiSo, SoTien)
    VALUES(@MaChiSo, @SoTien);
END;
GO

CREATE PROCEDURE sp_UpdateHoaDon
    @MaHD INT,
    @TrangThai NVARCHAR(50)
AS
BEGIN
    UPDATE HoaDon
    SET TrangThai=@TrangThai
    WHERE MaHD=@MaHD;
END;
GO

CREATE PROCEDURE sp_DeleteHoaDon
    @MaHD INT
AS
BEGIN
    DELETE FROM HoaDon WHERE MaHD=@MaHD;
END;
GO

CREATE PROCEDURE sp_GetHoaDon
AS
BEGIN
    SELECT * FROM HoaDon;
END;
GO