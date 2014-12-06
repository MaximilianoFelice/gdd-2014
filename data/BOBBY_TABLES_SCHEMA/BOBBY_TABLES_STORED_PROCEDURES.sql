/* Creating procedure that validate user login */
CREATE PROCEDURE [BOBBY_TABLES].validateUserPass 
@User VARCHAR(50), 
@Pass VARCHAR(64),
@RESULT BIT = 0x0 OUTPUT
AS
	DECLARE @Login_Attempts INTEGER;
	DECLARE @Current_Pass VARCHAR(64);
	
	/* Checking if Username Exists */

	SELECT @Current_Pass = pass, @Login_Attempts = login_attempts FROM [BOBBY_TABLES].ACTIVE_USERS WHERE username = @User
	
	IF @@ROWCOUNT > 0
	BEGIN
		IF @Pass = @Current_Pass
			BEGIN
				UPDATE [BOBBY_TABLES].ACTIVE_USERS	
				SET login_attempts = 0
				WHERE username = @User;
				SET @RESULT = 0x1
			END
		ELSE
			BEGIN
				UPDATE [BOBBY_TABLES].ACTIVE_USERS	
				SET login_attempts = @Login_Attempts + 1
				WHERE username = @User;
			END
	END
	
GO


--=======================================
--PERSON_EXISTS
--=======================================
CREATE PROCEDURE [BOBBY_TABLES].SP_PERSON_EXISTS
@Name VARCHAR(50) = NULL,
@Lastname VARCHAR(50) = NULL,
@DocType VARCHAR(10),
@DocNumber DECIMAL(10,0),
@BirthDate DATETIME = NULL,
@GuestExist BIT OUTPUT
AS 

	IF @Name = NULL
	BEGIN
		SELECT id_person FROM [BOBBY_TABLES].PERSONS WHERE name = @Name AND lastname = @Lastname AND doc_type = @DocType
		AND doc_number = @DocNumber AND birthdate = @BirthDate
	END
	ELSE
	BEGIN
		SELECT id_person FROM [BOBBY_TABLES].PERSONS WHERE doc_type = @DocType AND doc_number = @DocNumber
	END
	
	IF @@ROWCOUNT > 0
	BEGIN
		SET @GuestExist = 1
	END
	ELSE
	BEGIN
		SET @GuestExist = 0
	END
GO


--=======================================
--INSERT PERSON
--=======================================
CREATE PROCEDURE SP_INSERT_PERSON
@Name VARCHAR(50),
@Lastname VARCHAR(50),
@DocType VARCHAR(10),
@DocNumber DECIMAL(10,0),
@Mail VARCHAR(50),
@Phone DECIMAL(20,0),
@BirthDate DATETIME,
@Street VARCHAR(100),
@StreetNum INTEGER,
@Floor INTEGER,
@Dept VARCHAR(5),
@Nationality VARCHAR(50),
@State INTEGER,
@IdInserted INTEGER OUTPUT
AS

	INSERT INTO [BOBBY_TABLES].PERSONS (name, lastname, doc_type, doc_number, mail, phone, birthdate, street, street_num, dir_floor,
	dir_dpt, nationality, stat) 
	VALUES (@Name, @Lastname, @DocType, @DocNumber, @Mail, @Phone, @BirthDate, @Street, @StreetNum, @Floor, @Dept, @Nationality, @State)
	
	SET @IdInserted = @@IDENTITY

GO


--=======================================
--EMAIL_EXISTS
--=======================================
CREATE PROCEDURE [BOBBY_TABLES].SP_EMAIL_EXISTS
@Email VARCHAR(50),
@EmailExist BIT OUTPUT
AS 

	SELECT id_person FROM [BOBBY_TABLES].PERSONS WHERE mail = @Email 
	
	IF @@ROWCOUNT > 0
	BEGIN
		SET @EmailExist = 1
	END
	ELSE
	BEGIN
		SET @EmailExist = 0
	END
GO

----- PRUEBAS
EXEC [BOBBY_TABLES].validateUserPass @User = 'MaximilianoFelice', @Pass = '53acbedaad48d8d482fe1a9bf8cd8b8e329ff8033c5c1dc81dcccdff38dd197f';

EXEC [BOBBY_TABLES].validateUserPass @User = 'MaximilianoFelice', @Pass = '5dd197f';

SELECT * FROM BOBBY_TABLES.ACTIVE_USERS;

UPDATE BOBBY_TABLES.USERS
	SET login_attempts = 0;

SELECT * FROM BOBBY_TABLES.PERSONS;


DROP PROCEDURE [BOBBY_TABLES].validateUserPass
