CREATE DATABASE QuanLyTacGia;
GO

USE QuanLyTacGia;
GO
CREATE TABLE TacGia (
    MaTacGia VARCHAR(10) PRIMARY KEY,
    TenTacGia NVARCHAR(100),
    LienLac NVARCHAR(100)
);
INSERT INTO TacGia VALUES 
('TG1', N'Tô Hoài', N'Việt Nam'),
('TG2', N'Đoàn Giỏi', N'Việt Nam'),
('TG3', N'Trần Đăng Khoa', N'Việt Nam'),
('TG4', N'Nguyễn Nhật Ánh', N'Việt Nam'),
('TG5', N'Rolf Kalnuczack', N'Đức'),
('TG6', N'Sơn Tùng', N'Việt Nam'),
('TG7', N'Fujiko F. Fujio', N'Nhật Bản'),
('TG8', N'Đặng Thùy Trâm', N'Việt Nam'),
('TG9', N'Yann Martel', N'Canda'),
('TGa1', N'Murakami Haruki', N'Nhật Bản'),
('TGa2', N'Antoine de Saint-Exupéry', N'Pháp'),
('TGa3', N'William Golding', N'Anh'),
('TGa4', N'Shin Kyung-sook', N'Hàn Quốc');
--them--
CREATE PROCEDURE sp_ThemTacGia
    @MaTacGia VARCHAR(10),
    @TenTacGia NVARCHAR(100),
    @LienLac NVARCHAR(100)
AS
BEGIN
    INSERT INTO TacGia VALUES (@MaTacGia, @TenTacGia, @LienLac);
END;
--sua--
CREATE PROCEDURE sp_SuaTacGia
    @MaTacGia VARCHAR(10),
    @TenTacGia NVARCHAR(100),
    @LienLac NVARCHAR(100)
AS
BEGIN
    UPDATE TacGia
    SET TenTacGia = @TenTacGia,
        LienLac = @LienLac
    WHERE MaTacGia = @MaTacGia;
END;

--xoa--
CREATE PROCEDURE sp_XoaTacGia
    @MaTacGia VARCHAR(10)
AS
BEGIN
    DELETE FROM TacGia WHERE MaTacGia = @MaTacGia;
END;

--timkiem--
SELECT * FROM TacGia
WHERE TenTacGia LIKE N'%Từ khóa%';
