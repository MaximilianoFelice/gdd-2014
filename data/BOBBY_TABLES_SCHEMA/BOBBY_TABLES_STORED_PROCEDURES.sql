
--=======================================
--PERSON_EXISTS
--=======================================
CREATE PROCEDURE [BOBBY_TABLES].SP_PERSON_EXISTS
@Name VARCHAR(50) = NULL,
@Lastname VARCHAR(50) = NULL,
@DocType VARCHAR(10),
@DocNumber DECIMAL(10,0),
@BirthDate DATETIME = NULL,
@GuestExist BIT = 0x0 OUTPUT
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
		SET @GuestExist = 0x1
	END
	
GO


--=======================================
--INSERT PERSON
--=======================================
CREATE PROCEDURE [BOBBY_TABLES].SP_INSERT_PERSON
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
--EMAIL_EXISTS_UPDATE
--=======================================
CREATE PROCEDURE [BOBBY_TABLES].SP_EMAIL_EXISTS_UPDATE
@Id INTEGER,
@Email VARCHAR(50),
@EmailExist BIT = 0x0 OUTPUT
AS 

	DECLARE @SearchedMail VARCHAR(50)

	SELECT @SearchedMail = mail FROM [BOBBY_TABLES].PERSONS WHERE id_person = @Id 
	
	IF @SearchedMail <> @Email
	BEGIN
		SET @EmailExist = 0x1
	END
	
GO


--=======================================
--EMAIL_EXISTS
--=======================================
CREATE PROCEDURE [BOBBY_TABLES].SP_EMAIL_EXISTS
@Email VARCHAR(50),
@EmailExist BIT = 0x0 OUTPUT
AS 

	SELECT id_person FROM [BOBBY_TABLES].PERSONS WHERE mail = @Email 
	
	IF @@ROWCOUNT > 0
	BEGIN
		SET @EmailExist = 0x1
	END
	
GO


--=======================================
--UPDATE PERSON
--=======================================
CREATE PROCEDURE [BOBBY_TABLES].SP_UPDATE_PERSON
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
@IdPersonToUpdate INTEGER,
@Updated BIT = 0x0 OUTPUT
AS

	UPDATE [BOBBY_TABLES].PERSONS 
	SET
		name = @Name,
		lastname = @Lastname,
		doc_type = @DocType,
		doc_number = @DocNumber,
		mail = @Mail,
		phone = @Phone,
		birthdate = @BirthDate,
		street = @Street,
		street_num = @StreetNum,
		dir_floor = @Floor,
		dir_dpt = @Dept,
		nationality = @Nationality,
		stat = @State
	WHERE id_person = @IdPersonToUpdate
	
	IF @@ERROR = 0
	BEGIN
		SET @Updated = 0x1
	END

GO


--=======================================
--FILTER PERSON
--=======================================
CREATE FUNCTION [BOBBY_TABLES].SP_FILTER_PERSONS
(@Name VARCHAR(50) = NULL,
@Lastname VARCHAR(50) = NULL,
@DocType VARCHAR(10) = NULL,
@DocNumber DECIMAL(10,0) = NULL,
@Mail VARCHAR(50) = NULL)
RETURNS TABLE
AS
	BEGIN
		
		RETURN
		(SELECT * FROM [BOBBY_TABLES].PERSONS 
		WHERE
			((@Name IS NULL)  OR (name LIKE '%' + @Name + '%')) AND
			((@Lastname IS NULL) OR (lastname LIKE '%' + @Lastname+ '%')) AND
			((@DocNumber IS NULL) OR (doc_number = @DocNumber )) AND
			((@Mail IS NULL) OR (mail LIKE '%' + @Mail + '%')) AND
			((@DocType IS NULL) OR (doc_type = @DocType)) 
		ORDER BY lastname, name)
    
    END
    
GO


--=======================================
--DELETE PERSON
--=======================================
CREATE PROCEDURE [BOBBY_TABLES].SP_DELETE_PERSON
@IdPersonToDelete INTEGER,
@Deleted BIT = 0x0 OUTPUT
AS
	
	UPDATE [BOBBY_TABLES].PERSONS SET stat = 303 WHERE id_person = @IdPersonToDelete
	
	IF @@ERROR = 0
	BEGIN
		SET @Deleted = 0x1
	END
	
GO


--=======================================
--INSERT HOTEL
--=======================================
GO
CREATE PROCEDURE [BOBBY_TABLES].SP_INSERT_HOTEL
@Name VARCHAR(50),
@Mail VARCHAR(50),
@Phone DECIMAL(20,0),
@City VARCHAR(255),
@Country VARCHAR(255),
@Street VARCHAR(255),
@StreetNum INTEGER,
@Stars INTEGER,
@Inserted BIT = 0x0 OUTPUT
AS

	INSERT INTO [BOBBY_TABLES].HOTELS (name, mail, phone, city, country, street, street_num, stars, stat)
	VALUES (@Name, @Mail, @Phone, @City, @Country, @Street, @StreetNum, @Stars, 401)
	
	IF @@ERROR = 0
	BEGIN
		SET @Inserted = 0x1
	END

GO


--=======================================
--UPDATE HOTEL
--=======================================
CREATE PROCEDURE [BOBBY_TABLES].SP_UPDATE_HOTEL
@Id INTEGER,
@Name VARCHAR(50),
@Mail VARCHAR(50),
@Phone DECIMAL(20,0),
@City VARCHAR(255),
@Country VARCHAR(255),
@Street VARCHAR(255),
@StreetNum INTEGER,
@Stars INTEGER,
@CreationDate DATETIME,
@Updated BIT = 0x0 OUTPUT
AS

	UPDATE [BOBBY_TABLES].HOTELS
	SET
		name = @Name,
		mail = @Mail,
		phone = @Phone,
		city = @City,
		country = @Country,
		street = @Street,
		street_num = @StreetNum,
		stars = @Stars,
		creation_date = @CreationDate
	WHERE id_hotel = @Id
	
	IF @@ERROR = 0
	BEGIN
		SET @Updated = 0x1
	END

GO


--=======================================
--INSERT REGIMEN_HOTEL
--=======================================
CREATE PROCEDURE [BOBBY_TABLES].SP_INSERT_REGIMENS_HOTEL
@IdHotel INTEGER,
@IdRegimen INTEGER,
@Inserted BIT = 0x0 OUTPUT
AS

	INSERT INTO [BOBBY_TABLES].REGIMEN_HOTEL (id_hotel, id_regimen)
	VALUES (@IdHotel, @IdRegimen)
	
	IF @@ERROR = 0
	BEGIN
		SET @Inserted = 0x1
	END

GO


--=======================================
--INSERT HOTEL_MANTEINANCE
--=======================================
CREATE PROCEDURE [BOBBY_TABLES].SP_HOTEL_MANTEINANCE
@IdHotel INTEGER,
@Start DATETIME,
@End DATETIME,
@Descr VARCHAR(255),
@Manteined BIT = 0x0 OUTPUT
AS

	INSERT INTO BOBBY_TABLES.[MANT_HISTORY] (id_hotel, mant_start, mant_end, descr)
	VALUES (@IdHotel, @Start, @End, @Descr)
	
	IF @@ERROR = 0
	BEGIN
		SET @Manteined = 0x1
	END

GO


--=======================================
--ROOM_EXISTS
--=======================================
CREATE PROCEDURE [BOBBY_TABLES].SP_ROOM_EXISTS
@RoomNum INTEGER,
@IdHotel INTEGER,
@RoomExists BIT = 0x0 OUTPUT
AS 

	SELECT id_room FROM [BOBBY_TABLES].ROOMS WHERE number = @RoomNum AND id_hotel = @IdHotel 
	
	IF @@ROWCOUNT > 0
	BEGIN
		SET @RoomExists = 0x1
	END
	
GO


--=======================================
--INSERT ROOM
--=======================================
CREATE PROCEDURE [BOBBY_TABLES].SP_INSERT_ROOM
@IdHotel INTEGER,
@RoomNum INTEGER,
@Floor INTEGER,
@TypeDesc INTEGER,
@LocationDesc INTEGER,
@Descr VARCHAR(255),
@Inserted BIT = 0x0 OUTPUT
AS

	INSERT INTO [BOBBY_TABLES].ROOMS (id_hotel, number, room_floor, id_roomtype, id_location, descr)
	VALUES (@IdHotel, @RoomNum, @Floor, @TypeDesc, @LocationDesc, @Descr)
	
	IF @@ERROR = 0
	BEGIN
		SET @Inserted = 0x1
	END

GO


--=======================================
--UPDATE ROOM
--=======================================
CREATE PROCEDURE [BOBBY_TABLES].SP_UPDATE_ROOM
@IdRoom INTEGER,
@IdHotel INTEGER,
@RoomNum INTEGER,
@Floor INTEGER,
@TypeDesc INTEGER,
@LocationDesc INTEGER,
@Descr VARCHAR(255),
@Updated BIT = 0x0 OUTPUT
AS

	UPDATE [BOBBY_TABLES].ROOMS
	SET
		id_hotel = @IdHotel,
		number = @RoomNum,
		room_floor = @Floor,
		id_roomtype = @TypeDesc,
		id_location = @LocationDesc,
		descr = @Descr
	WHERE id_room = @IdRoom
	
	IF @@ERROR = 0
	BEGIN
		SET @Updated = 0x1
	END

GO


--=======================================
--DELETE ROOM
--=======================================
CREATE PROCEDURE [BOBBY_TABLES].SP_DELETE_PERSON
@IdRoom INTEGER,
@Deleted BIT = 0x0 OUTPUT
AS
	
	UPDATE [BOBBY_TABLES].ROOMS SET stat = 603 WHERE id_room = @IdRoom
	
	IF @@ERROR = 0
	BEGIN
		SET @Deleted = 0x1
	END
	
GO


--=======================================
--FILTER ROOMS
--=======================================
CREATE FUNCTION [BOBBY_TABLES].SP_FILTER_ROOMS
(@IdHotel INTEGER = NULL,
@RoomNum INTEGER = NULL,
@Floor INTEGER = NULL,
@TypeDesc INTEGER = NULL,
@LocationDesc INTEGER = NULL,
@Descr VARCHAR(255) = NULL)
RETURNS TABLE
AS
	BEGIN
		
		RETURN
		(SELECT * FROM [BOBBY_TABLES].ROOMS 
		WHERE
			((@IdHotel IS NULL)  OR (id_hotel = @IdHotel)) AND
			((@RoomNum IS NULL) OR (number = @RoomNum)) AND
			((@Floor IS NULL) OR (room_floor = @Floor)) AND
			((@TypeDesc IS NULL) OR (id_roomtype = @TypeDesc)) AND
			((@LocationDesc IS NULL) OR (id_location = @LocationDesc)) AND
			((@Descr IS NULL) OR (descr LIKE '%' + @Descr + '%'))
		ORDER BY lastname, name)
    
    END
    
GO

	
--=======================================
--BOOKING PRICE
--=======================================
CREATE PROCEDURE [BOBBY_TABLES].SP_BOOKING_PRICE
@IdHotel INTEGER,
@IdRegimen INTEGER,
@CheckIn DATETIME,
@CheckOut DATETIME,
@ExtraGuests INTEGER,
@IdRoomType INTEGER,
@Price INTEGER OUTPUT
AS

	DECLARE @BasePrice FLOAT;
	DECLARE @Recharge INTEGER;
	DECLARE @Stars INTEGER;
	DECLARE @Perc DECIMAL(6,3);
	
	SELECT @BasePrice =	r.price, @Recharge = h.recharge_by_star, @Stars = h.stars, @Perc = rt.perc
	FROM REGIMENS r, HOTELS h, ROOM_TYPE rt WHERE r.id_regimen = @IdRegimen AND h.id_hotel = @IdHotel
	
	SET @Price = DATEDIFF(DAY, @CheckIn, @CheckOut) * (@BasePrice + @Perc + (@Stars * @Recharge))
	
GO	

--=======================================
--STATISTICS TOP 5 HOTELS WITH CANCELLED BOOKINGS
--=======================================
CREATE PROCEDURE [BOBBY_TABLES].SP_STATISTICS_CANCEL_BOOKINGS 
	@from datetime ,
	@to datetime 
AS
BEGIN
	SET NOCOUNT ON;
	select top 5
		h.name,
		h.street,
		h.street_num,
		h.city
		count(b.id_booking) as 'Amount of Cancel Bookings'
	from  [BOBBY_TABLES].BOOKINGS b
	inner join [BOBBY_TABLES].HOTELS h on h.id_hotel =  r.id_hotel		
	where
		b.id_booking  in (select id_stat from [BOBBY_TABLES].STAT 
							where descr like '%Cancel%')
	     AND b.fecha between @from and @to
	group by 	
		h.name,h.street,h.street_num,h.city
	order by 
		'Amount of Cancel Bookings' desc
END
GO



--=======================================
--STATISTICS TOP 5 HOTELS WITH EXTRAS BILLED
--=======================================


CREATE PROCEDURE[BOBBY_TABLES].SP_STATISTICS_EXTRA_BILLED 
	@from datetime ,
	@to datetime 
AS
BEGIN
	select top 5
		h.street + ' ' +  convert(nvarchar(255),h.street_num) as 'Direccion Hotel',
		h.city,
		sum(bi.quantity) as 'Amount of Items Billed'
		from [BOBBY_TABLES].BILLS b
		
			inner join [BOBBY_TABLES].BILLS_ITEMS bi on bi.id_bill = b.id_bill
			inner join [BOBBY_TABLES].STAYS s on s.id_stay = b.id_stay		
			inner join [BOBBY_TABLES].ROOMS r on r.id_room= s.id_room
			inner join [BOBBY_TABLES].HOTELS h on h.id_hotel  = r.id_hotel
	where
		b.payment_date between @from and @to
	group by 	
		h.street, h.street_num,h.city, bi.quantity
	order by 'Amount of Items Billed' desc
	
END
GO

--=======================================
--STATISTICS TOP 5 HOTELS WITH MOST OUT SERVICE DAYS
--=======================================

CREATE PROCEDURE [BOBBY_TABLES].SP_STATISTICS_OUT_SERVICE
	@from datetime ,
	@to datetime 
AS
BEGIN
	select top 5
		h.street, h.street_num, h.city,
		sum(datediff(DD, mant_start,mant_end)) as 'Days Out of Service'
	from 
		[BOBBY_TABLES].MANT_HISTORY m
			inner join [BOBBY_TABLES].HOTELS h on h.id_hotel  = m.id_hotel
	where
		(@from between mant_start and mant_end) AND
		(@to between mant_start and mant_end) 
	group by
		h.city, h.street, h.street_num
	order by
		'Days Out of Service' desc		
END
GO

--=======================================
--STATISTICS TOP 5 ROOMS MOST OCCUPIED
--=======================================
CREATE PROCEDURE [BOBBY_TABLES].SP_STATISTICS_OCCUPIED_ROOMS

	@from datetime ,
	@to datetime 
AS
BEGIN
	select top 5
		r.number as 'Room Number',
		r.room_floor as 'Room Floor',
		h.street, 
		h.street_num,
		h.city,
		sum(s.nights) as 'Amount of Nights',
		sum(1) as 'Amount of Time Occupied'
	from [BOBBY_TABLES].STAYS s 
		inner join [BOBBY_TABLES].ROOMS r
			on r.id_room = s.id_room
		inner join [BOBBY_TABLES].HOTELS h
			on h.id_hotel = r.id_hotel
	Where
		s.stay_start between @from and @to
	group by 
		h.city, h.street, h.street_num, r.number, r.room_floor
	order by 
		'Amount of Nights' desc,
		'Amount of Time Occupied' desc
END
GO


--=======================================
--STATISTICS TOP 5 GUEST WITH MOST POINTS
--=======================================








/*
----- PRUEBAS
EXEC [BOBBY_TABLES].validateUserPass @User = 'MaximilianoFelice', @Pass = '53acbedaad48d8d482fe1a9bf8cd8b8e329ff8033c5c1dc81dcccdff38dd197f';

EXEC [BOBBY_TABLES].validateUserPass @User = 'MaximilianoFelice', @Pass = '5dd197f';

				INSERT INTO #Roles
					EXEC [BOBBY_TABLES].GetUserRoles 'MaximilianoFelice';
				SELECT * FROM #Roles;
				DROP TABLE #Roles;

SELECT * FROM BOBBY_TABLES.ACTIVE_USERS;

UPDATE BOBBY_TABLES.USERS
	SET login_attempts = 0;
UPDATE BOBBY_TABLES.USERS
	SET inactive = 0x0;

SELECT * FROM BOBBY_TABLES.PERSONS;


DROP PROCEDURE [BOBBY_TABLES].validateUserPass

EXEC BOBBY_TABLES.GetUserRoles 'Guest';


SELECT * FROM BOBBY_TABLES.PERSONS WHERE lastname = 'Tango';

SELECT * FROM BOBBY_TABLES.HOTELS;
SELECT * FROM BOBBY_TABLES.REGIMEN_HOTEL;

DELETE FROM BOBBY_TABLES.HOTELS WHERE name = 'HotelTest';

*/
