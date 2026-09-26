USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'NhaStudent_2410900003_Db')
BEGIN
    ALTER DATABASE NhaStudent_2410900003_Db SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE NhaStudent_2410900003_Db;
END
GO

CREATE DATABASE NhaStudent_2410900003_Db;
GO

USE NhaStudent_2410900003_Db;
GO

IF OBJECT_ID('dbo.NhaStudent', 'U') IS NOT NULL
    DROP TABLE dbo.NhaStudent;
GO

CREATE TABLE dbo.NhaStudent (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NhaName NVARCHAR(100) NOT NULL,
    NhaGender BIT NOT NULL,
    NhaBirthDay DATE NOT NULL,
    NhaEmail NVARCHAR(100) NOT NULL,
    NhaPhone NVARCHAR(20) NOT NULL,
    NhaActive BIT NOT NULL DEFAULT 1
);
GO

INSERT INTO dbo.NhaStudent (NhaName, NhaGender, NhaBirthDay, NhaEmail, NhaPhone, NhaActive)
VALUES 
(N'Nguyen Huy Anh', 1, '2004-05-15', 'huyanh.nguyen@student.edu.vn', '0912345678', 1);
GO

SELECT * FROM dbo.NhaStudent;
GO
