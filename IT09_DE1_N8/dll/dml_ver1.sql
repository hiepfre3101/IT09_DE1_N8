SET XACT_ABORT ON;

BEGIN TRY
    BEGIN TRAN;

    -- ====== Nhân viên ======
    INSERT INTO NhanVien (HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, ChucVu)
    VALUES (N'Nguyễn Văn A', '1990-05-12', N'Nam', N'123 Lê Lợi, Hà Nội', '0901234567', N'Nhân viên ghi chỉ số');
    DECLARE @MaNV1 INT = SCOPE_IDENTITY();

    INSERT INTO NhanVien (HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, ChucVu)
    VALUES (N'Trần Thị B', '1995-09-20', N'Nữ', N'45 Hai Bà Trưng, Hà Nội', '0912345678', N'Nhân viên thu tiền');
    DECLARE @MaNV2 INT = SCOPE_IDENTITY();

    -- ====== Khách hàng ======
    INSERT INTO KhachHang (HoTenChuHo, DiaChi, DienThoai, NgayDangKy, SoHopDong)
    VALUES (N'Lê Văn Cường', N'12 Nguyễn Trãi, Hà Đông, Hà Nội', '0987654321', GETDATE(), 'HD001');
    DECLARE @MaKH1 INT = SCOPE_IDENTITY();

    INSERT INTO KhachHang (HoTenChuHo, DiaChi, DienThoai, NgayDangKy, SoHopDong)
    VALUES (N'Phạm Thị Hạnh', N'89 Trần Duy Hưng, Cầu Giấy, Hà Nội', '0978123456', '2023-03-01', 'HD002');
    DECLARE @MaKH2 INT = SCOPE_IDENTITY();

    INSERT INTO KhachHang (HoTenChuHo, DiaChi, DienThoai, NgayDangKy, SoHopDong)
    VALUES (N'Ngô Minh Tuấn', N'34 Lý Thường Kiệt, Hoàn Kiếm, Hà Nội', '0934567890', '2023-05-20', 'HD003');
    DECLARE @MaKH3 INT = SCOPE_IDENTITY();

    -- ====== Đồng hồ nước (mỗi KH 1 đồng hồ) ======
    INSERT INTO DongHoNuoc (MaKH, SoHieu, NgayLapDat)
    VALUES (@MaKH1, 'DH001', '2023-01-10');
    DECLARE @MaDH1 INT = SCOPE_IDENTITY();

    INSERT INTO DongHoNuoc (MaKH, SoHieu, NgayLapDat)
    VALUES (@MaKH2, 'DH002', '2023-03-15');
    DECLARE @MaDH2 INT = SCOPE_IDENTITY();

    INSERT INTO DongHoNuoc (MaKH, SoHieu, NgayLapDat)
    VALUES (@MaKH3, 'DH003', '2023-05-22');
    DECLARE @MaDH3 INT = SCOPE_IDENTITY();

    -- ====== Chỉ số nước (tháng 8/2025) ======
    -- KH1: 120 -> 145 (25 m3)
    INSERT INTO ChiSoNuoc (MaDongHo, Thang, Nam, ChiSoCu, ChiSoMoi, MaNV, NgayGhi)
    VALUES (@MaDH1, 8, 2025, 120, 145, @MaNV1, '2025-08-05');
    DECLARE @MaChiSo1 INT = SCOPE_IDENTITY();

    -- KH2: 200 -> 230 (30 m3)
    INSERT INTO ChiSoNuoc (MaDongHo, Thang, Nam, ChiSoCu, ChiSoMoi, MaNV, NgayGhi)
    VALUES (@MaDH2, 8, 2025, 200, 230, @MaNV1, '2025-08-06');
    DECLARE @MaChiSo2 INT = SCOPE_IDENTITY();

    -- KH3: 80 -> 100 (20 m3)
    INSERT INTO ChiSoNuoc (MaDongHo, Thang, Nam, ChiSoCu, ChiSoMoi, MaNV, NgayGhi)
    VALUES (@MaDH3, 8, 2025, 80, 100, @MaNV2, '2025-08-07');
    DECLARE @MaChiSo3 INT = SCOPE_IDENTITY();

    -- ====== Hóa đơn (đơn giá 7000 đ/m3) ======
    DECLARE @SoTieuThu INT;
    DECLARE @SoTien DECIMAL(18,2);
    DECLARE @DonGia INT = 7000;

    SELECT @SoTieuThu = SoTieuThu FROM ChiSoNuoc WHERE MaChiSo = @MaChiSo1;
    SET @SoTien = @SoTieuThu * @DonGia;
    INSERT INTO HoaDon (MaChiSo, SoTien, TrangThai) VALUES (@MaChiSo1, @SoTien, N'Chưa thanh toán');

    SELECT @SoTieuThu = SoTieuThu FROM ChiSoNuoc WHERE MaChiSo = @MaChiSo2;
    SET @SoTien = @SoTieuThu * @DonGia;
    INSERT INTO HoaDon (MaChiSo, SoTien, TrangThai) VALUES (@MaChiSo2, @SoTien, N'Chưa thanh toán');

    SELECT @SoTieuThu = SoTieuThu FROM ChiSoNuoc WHERE MaChiSo = @MaChiSo3;
    SET @SoTien = @SoTieuThu * @DonGia;
    INSERT INTO HoaDon (MaChiSo, SoTien, TrangThai) VALUES (@MaChiSo3, @SoTien, N'Đã thanh toán');

    COMMIT TRAN;
END TRY
BEGIN CATCH
    IF XACT_STATE() <> 0 ROLLBACK TRAN;
    DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
    DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
    DECLARE @ErrorState INT = ERROR_STATE();
    RAISERROR('Lỗi khi chèn dữ liệu mẫu: %s', @ErrorSeverity, @ErrorState, @ErrorMessage);
END CATCH;


