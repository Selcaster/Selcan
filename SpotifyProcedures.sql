USE SPOTIF
CREATE PROCEDURE usp_CreateCategory
    @Name NVARCHAR(100)
AS
BEGIN
    INSERT INTO Category (Name)
    VALUES (@Name);
END;
CREATE PROCEDURE usp_CreateUser
    @Name NVARCHAR(100),
    @Surname NVARCHAR(100),
    @Username NVARCHAR(100),
    @Password NVARCHAR(100),
    @Gender NVARCHAR(10)
AS
BEGIN
    INSERT INTO [User] (Name, Surname, Username, Password, Gender)
    VALUES (@Name, @Surname, @Username, @Password, @Gender);
END;
ALTER TABLE MUSICS
ADD IsDeleted bit NOT NULL DEFAULT 0;
CREATE PROCEDURE usp_DeleteMusic
    @Id INT
AS
BEGIN
    DECLARE @IsDeleted bit;
    SELECT @IsDeleted = IsDeleted FROM Musics WHERE Id = @Id;

    IF @IsDeleted = 0
    BEGIN
        UPDATE Musics
        SET IsDeleted = 1
        WHERE Id = @Id;
    END
END;
DROP PROCEDURE usp_DeleteMusic ;
CREATE PROCEDURE usp_DeleteMusic
    @Id INT
AS
BEGIN
    DECLARE @IsDeleted bit;
    SELECT @IsDeleted = IsDeleted FROM Musics WHERE Id = @Id;

    IF @IsDeleted = 0
    BEGIN
        UPDATE Musics
        SET IsDeleted = 1
        WHERE Id = @Id;
    END
	ELSE--serti tam odeyir
	BEGIN
		DELETE FROM MUSICS WHERE @ID=ID;
	END
END;
