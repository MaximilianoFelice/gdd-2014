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


----- PRUEBAS
EXEC [BOBBY_TABLES].validateUserPass @User = 'MaximilianoFelice', @Pass = '53acbedaad48d8d482fe1a9bf8cd8b8e329ff8033c5c1dc81dcccdff38dd197f';

EXEC [BOBBY_TABLES].validateUserPass @User = 'MaximilianoFelice', @Pass = '5dd197f';

SELECT * FROM BOBBY_TABLES.ACTIVE_USERS;

UPDATE BOBBY_TABLES.USERS
	SET login_attempts = 0;

SELECT * FROM BOBBY_TABLES.PERSONS;


DROP PROCEDURE [BOBBY_TABLES].validateUserPass


/* Creating Procedure to get features by roles */
GO
DROP PROCEDURE [BOBBY_TABLES].GetRoleFeatures;
GO
CREATE PROCEDURE [BOBBY_TABLES].GetRoleFeatures(
@Role INT
)
AS
	SELECT * FROM [BOBBY_TABLES].FEATURES feat 
			INNER JOIN [BOBBY_TABLES].FEATURES_ROLES fr ON (feat.id_feature = fr.id_feature)
			INNER JOIN [BOBBY_TABLES].ROLES roles ON (roles.id_role = fr.id_role)
	WHERE roles.id_role = @Role;
GO