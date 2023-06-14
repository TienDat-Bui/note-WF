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
note NVARCHAR(MAx),
idUser INT NOT NULL REFERENCES dbo.Account(idUser)
)
ALTER TABLE dbo.Content
ALTER COLUMN note NVARCHAR(MAx);
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
go

create PROC USP_SelectbyID (@Id int)
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
create proc USP_InsertNote(@title NVARCHAR(1000), @mess NVARCHAR(4000), @idUser int)
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




create PROC USP_UpdateNote(@idNote int, @title Nvarchar(1000), @note NVARCHAR(4000))
 AS
 BEGIN
	UPDATE dbo.Content SET title = @title, note = @note WHERE idNote = @idNote
 END
 GO

EXEC dbo.USP_UpdateNote @idNote = 0,  -- int
                        @title = N'', -- nvarchar(1000)
                        @note = N''   -- nvarchar(4000)
select *FROM  dbo.Content

 EXEC dbo.USP_InsertNote @title = N'bốn bảy năm mười', -- nvarchar(1000)
                         @mess = N'bốn bảy năm mười',  -- nvarchar(4000)
                         @idUser = 1   -- int
 

