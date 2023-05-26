CREATE DATABASE Note 
GO
USE Note
GO


-- Account
-- Content

CREATE TABLE Account (
idUser INT NOT NULL PRIMARY KEY IDENTITY,
userName VARCHAR(30) NOT NULL UNIQUE,
pass VARCHAR(30) NOT NULL,
displayName VARCHAR(30) NOT NULL,
mail VARCHAR(50))
GO

CREATE TABLE Content (
idNote INT NOT NULL PRIMARY KEY IDENTITY,
title NVARCHAR(1000) NOT NULL,
note TEXT,
idUser INT NOT NULL REFERENCES dbo.Account(idUser)
)
go
INSERT INTO dbo.Account
(
    userName,
    pass,
    displayName,
    mail
)
VALUES
(   'a','1','a1','a@1'),
(   'b','2','a2','a@2'),
(   'c','3','a3','a@3')
SELECT * FROM dbo.Account
INSERT INTO dbo.Content
(
    
    title,
    note,
    idUser
)
GO

alter PROC USP_SelectbyID (@Id int)
AS
BEGIN
SELECT title AS [Tiêu đề], note AS[Nội dung], idNote AS Id FROM dbo.Content WHERE idUser = @ID 
END
GO

SELECT * FROM dbo.Content
EXEC dbo.USP_SelectbyID @Id = 2-- int
	go

CREATE PROC USP_Login (@userName varchar(30), @pass VARCHAR(30))
AS
BEGIN
 SELECT * FROM	dbo.Account WHERE userName = @userName AND pass = @pass

END
go
alter proc USP_InsertNote(@title NVARCHAR(1000), @mess NVARCHAR(4000), @idUser int)
AS
BEGIN
	INSERT INTO dbo.Content
	( title,note,idUser
	)
	VALUES(   @title,@mess,@idUser	)
END
go
EXEC dbo.USP_InsertNote @title = N'2',@mess = '2222',@idUser = 1
SELECT *FROM dbo.Content
GO


UPDATE dbo.Content SET title = 'babababba', note = '213444444' WHERE idNote = 1
GO

ALTER PROC USP_UpdateNote(@idNote int, @title Nvarchar(1000), @note NVARCHAR(4000))
 AS
 BEGIN
	UPDATE dbo.Content SET title = @title, note = @note WHERE idNote = @idNote
 END
 GO



