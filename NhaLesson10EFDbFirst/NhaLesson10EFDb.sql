-- =======================================================================
-- Script tao co so du lieu va bang cho bai tap: NhaLesson10EFDbFirst
-- Sinh vien: Nguyen Huy Anh
-- Ma SV: 2410900003
-- Lop: K24CNT1
-- =======================================================================

USE master;
GO

-- Tao Database neu chua ton tai
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'NhaLesson10EFDb')
BEGIN
    CREATE DATABASE NhaLesson10EFDb;
END
GO

USE NhaLesson10EFDb;
GO

-- Xoa bang cu neu da ton tai
IF OBJECT_ID(N'dbo.NhaMember', N'U') IS NOT NULL
    DROP TABLE dbo.NhaMember;
GO

-- Tao bang NhaMember
CREATE TABLE dbo.NhaMember (
    Id BIGINT IDENTITY(1,1) PRIMARY KEY,
    NhaUserName VARCHAR(20) NULL,
    NhaPassword VARCHAR(50) NULL,
    NhaFullName NVARCHAR(50) NULL,
    NhaEmail VARCHAR(50) NULL,
    NhaPhone CHAR(12) NULL,
    NhaStatus BIT NULL
);
GO

-- Chen du lieu mau
INSERT INTO dbo.NhaMember (NhaUserName, NhaPassword, NhaFullName, NhaEmail, NhaPhone, NhaStatus)
VALUES
('nguyenhuyanh', '123456', N'Nguyen Huy Anh', 'hyanh173@gmail.com', '0987654321', 1),
('nhamember01', 'password1', N'Tran Thi Mai', 'maitt@gmail.com', '0912345678', 1),
('nhamember02', 'password2', N'Le Hoang Long', 'longlh@gmail.com', '0934567890', 0),
('nhamember03', 'password3', N'Pham Minh Tuan', 'tuanpm@gmail.com', '0945678901', 1);
GO

-- Kiem tra du lieu
SELECT * FROM dbo.NhaMember;
GO

