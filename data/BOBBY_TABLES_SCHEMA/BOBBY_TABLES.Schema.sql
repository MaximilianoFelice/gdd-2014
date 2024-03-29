USE [GD2C2014]
GO
CREATE SCHEMA [BOBBY_TABLES] AUTHORIZATION [gd]
GO

/* ---------------------- */
/* TABLE DEFINITION ZONE  */
/* ---------------------- */

CREATE TABLE [BOBBY_TABLES].PERSONS (
id_person INTEGER NOT NULL IDENTITY(1,1),
name VARCHAR(50) NOT NULL,
lastname VARCHAR(50) NOT NULL,
doc_type VARCHAR(10),
doc_number DECIMAL(10,0),
mail VARCHAR(50),
phone DECIMAL(20,0),
birthdate DATETIME,
street VARCHAR(100),
street_num INTEGER,
dir_floor INTEGER,
dir_dpt VARCHAR(5),
nationality VARCHAR(50),
stat INTEGER NOT NULL,
PRIMARY KEY (id_person),
UNIQUE (doc_type, doc_number, lastname, name, birthdate)
);

CREATE TABLE [BOBBY_TABLES].DOC_TYPE (
doc_type VARCHAR(10) NOT NULL,
PRIMARY KEY(doc_type)
);

CREATE TABLE [BOBBY_TABLES].COUNTRIES (
country VARCHAR(50) PRIMARY KEY
);

CREATE TABLE [BOBBY_TABLES].ROLES (
id_role INTEGER NOT NULL IDENTITY(1,1),
name VARCHAR(100) NOT NULL,
inactive BIT DEFAULT(0x0) NOT NULL,
PRIMARY KEY (id_role),
UNIQUE (name)
);

CREATE TABLE [BOBBY_TABLES].USER_ROLES (
id_user INTEGER NOT NULL,
id_role INTEGER NOT NULL,
PRIMARY KEY(id_user, id_role)
);

CREATE TABLE [BOBBY_TABLES].FEATURES (
id_feature INTEGER NOT NULL IDENTITY(1,1),			-- Handles it's own codification system
descr VARCHAR(255),
inactive BIT DEFAULT(0x0) NOT NULL,
PRIMARY KEY (id_feature),
UNIQUE(descr)
);

CREATE TABLE [BOBBY_TABLES].FEATURES_ROLES (
id_role INTEGER NOT NULL,
id_feature INTEGER NOT NULL,
PRIMARY KEY (id_role, id_feature)
);

CREATE TABLE [BOBBY_TABLES].USERS (
id_user INTEGER NOT NULL IDENTITY(1,1),
id_person INTEGER NOT NULL,
username VARCHAR(50) NOT NULL,
pass VARCHAR(64) NOT NULL,
login_attempts NUMERIC(1,0) NOT NULL DEFAULT(0),
inactive BIT DEFAULT(0x0) NOT NULL,
deleted BIT DEFAULT(0x0) NOT NULL,
UNIQUE (username),
PRIMARY KEY(id_user)
);

CREATE TABLE [BOBBY_TABLES].USER_HOTELS (
id_hotel INTEGER NOT NULL,
id_user INTEGER NOT NULL,
PRIMARY KEY (id_hotel, id_user)
);

CREATE TABLE [BOBBY_TABLES].HOTELS (
id_hotel INTEGER NOT NULL IDENTITY(1,1),
name VARCHAR(255),
city VARCHAR(255),
street VARCHAR(255),
street_num INTEGER,
country VARCHAR(50),
mail VARCHAR(50),
phone VARCHAR(20), -- TODO: Make it a number
stars INTEGER NOT NULL,
recharge_by_star INTEGER NOT NULL DEFAULT(10),
stat INTEGER NOT NULL DEFAULT(401),
PRIMARY KEY (id_hotel),
UNIQUE (city, street, street_num)
);

CREATE TABLE [BOBBY_TABLES].ROOMS (
id_room INTEGER NOT NULL IDENTITY(1,1),
number INTEGER NOT NULL,
room_floor INTEGER NOT NULL,
id_hotel INTEGER NOT NULL,
id_roomtype INTEGER NOT NULL,
id_location INTEGER NOT NULL,
descr VARCHAR(255),
stat INTEGER NOT NULL,
PRIMARY KEY (id_room),
UNIQUE(number, room_floor, id_hotel)
);

CREATE TABLE [BOBBY_TABLES].ROOM_LOCATION (
id_location INTEGER NOT NULL IDENTITY(1,1),
descr VARCHAR(255) NOT NULL,
PRIMARY KEY (id_location)
);

CREATE TABLE [BOBBY_TABLES].ROOM_TYPE (
id_roomtype INTEGER NOT NULL IDENTITY(1,1),
descr VARCHAR(255),
perc DECIMAL(6,3) NOT NULL,
PRIMARY KEY (id_roomtype)
);

CREATE TABLE [BOBBY_TABLES].REGIMEN_HOTEL (
id_hotel INTEGER NOT NULL,
id_regimen INTEGER NOT NULL,
PRIMARY KEY (id_hotel, id_regimen)
);

CREATE TABLE [BOBBY_TABLES].REGIMENS (
id_regimen INTEGER NOT NULL IDENTITY(1,1),
descr VARCHAR(255),
price FLOAT NOT NULL,
stat INTEGER NOT NULL,
PRIMARY KEY (id_regimen)
);

CREATE TABLE [BOBBY_TABLES].MANT_HISTORY (
id_history INTEGER NOT NULL IDENTITY(1,1),
id_hotel INTEGER NOT NULL,
mant_start DATETIME NOT NULL,
mant_end DATETIME,
descr VARCHAR(255),
PRIMARY KEY (id_history)
);

CREATE TABLE [BOBBY_TABLES].BOOKINGS (
id_booking INTEGER NOT NULL IDENTITY(1,1),
id_regimen INTEGER NOT NULL,
id_hotel INTEGER NOT NULL,
id_roomtype INTEGER NOT NULL,
regimen_price FLOAT NOT NULL,
guests INTEGER NOT NULL DEFAULT(0),
booking_start DATETIME NOT NULL,
nights INTEGER,
stat INTEGER NOT NULL
PRIMARY KEY (id_booking)
);

CREATE TABLE [BOBBY_TABLES].CANCELED_BOOKINGS (
id_booking INTEGER NOT NULL,
reason VARCHAR(500),
cancelation_date DATETIME DEFAULT(GETDATE()),
id_user INTEGER NOT NULL,
PRIMARY KEY (id_booking)
);

CREATE TABLE [BOBBY_TABLES].GUEST_BOOKINGS (
id_booking INTEGER NOT NULL,
id_person INTEGER NOT NULL,
stat INTEGER NOT NULL,
PRIMARY KEY (id_booking, id_person)
);

CREATE TABLE [BOBBY_TABLES].STAYS (
id_stay INTEGER NOT NULL,
id_room INTEGER NOT NULL,
stay_start DATETIME NOT NULL,
nights INTEGER,
stat INTEGER NOT NULL,
PRIMARY KEY (id_stay)
);

CREATE TABLE [BOBBY_TABLES].EXTRAS (
id_extra INTEGER NOT NULL IDENTITY(1,1),
descr VARCHAR(255) NOT NULL,
price FLOAT NOT NULL,
PRIMARY KEY (id_extra)
);

CREATE TABLE [BOBBY_TABLES].STAY_EXTRAS (
id_extra_bought INTEGER NOT NULL IDENTITY(1,1),		-- Totally private key
id_stay INTEGER NOT NULL,
id_extra INTEGER NOT NULL, 
price FLOAT NOT NULL,
quantity INTEGER NOT NULL,
PRIMARY KEY (id_extra_bought)
);

CREATE TABLE [BOBBY_TABLES].STAT (			-- Must replace IF NECESSARY timestamp and username
id_stat INTEGER NOT NULL,					-- Handles it's own codification system
descr VARCHAR(255) NOT NULL,
comments VARCHAR(255),
PRIMARY KEY (id_stat)
)

CREATE TABLE [BOBBY_TABLES].BILLS (
id_bill INTEGER NOT NULL IDENTITY(1,1),
stay_price FLOAT NOT NULL,
id_stay INTEGER NOT NULL,
payment_date DATETIME,
payment_mode VARCHAR(255),
PRIMARY KEY (id_bill)
);

CREATE TABLE [BOBBY_TABLES].BILLS_ITEMS (
id_bill INTEGER NOT NULL,
price FLOAT NOT NULL,
quantity INTEGER NOT NULL
PRIMARY KEY(id_bill, price, quantity)
);



/* -------------------------- */
/* VIEWS CRATION ZONE         */
/* -------------------------- */
GO
CREATE VIEW [BOBBY_TABLES].ACTIVE_USERS AS
SELECT id_user, id_person, username, pass, login_attempts  FROM [BOBBY_TABLES].USERS WHERE 
	(inactive = 0x0) AND (deleted = 0x0) AND (login_attempts < 3)	
GO
GO
CREATE VIEW [BOBBY_TABLES].DELETED_USERS AS
SELECT id_user, id_person, username, pass, login_attempts  FROM [BOBBY_TABLES].USERS WHERE 
	(deleted = 0x1)
GO
GO
CREATE VIEW [BOBBY_TABLES].INACTIVE_USERS AS
SELECT id_user, id_person, username, pass, login_attempts  FROM [BOBBY_TABLES].USERS WHERE 
	(inactive = 0x1)	
GO

GO
CREATE VIEW [BOBBY_TABLES].ACTIVE_FEATURES AS
SELECT * FROM BOBBY_TABLES.FEATURES WHERE (inactive = 0x0);
GO
GO
CREATE VIEW [BOBBY_TABLES].ACTIVE_ROLES AS
SELECT * FROM BOBBY_TABLES.ROLES WHERE (inactive = 0x0);
GO

GO
CREATE VIEW [BOBBY_TABLES].ACTIVE_HOTELS AS
SELECT * FROM BOBBY_TABLES.HOTELS WHERE (stat = 401 OR stat = 404) AND name IS NOT NULL;
GO

/* -------------------------- */
/* TRIGGERS CRATION ZONE      */
/* -------------------------- */
GO
CREATE TRIGGER [BOBBY_TABLES].CHECK_USER_ATTEMPTS
ON [BOBBY_TABLES].USERS
FOR UPDATE
AS
	DECLARE @ATTEMPTS INTEGER;
	DECLARE @ID_USER INTEGER;
	
	SELECT @ATTEMPTS=login_attempts, @ID_USER=id_user FROM inserted;
	
	IF ( @ATTEMPTS  >= 3 )
		UPDATE [BOBBY_TABLES].USERS 
		SET inactive = 0x1
		WHERE id_user = @ID_USER;
GO

/* Set feature inactive instead of deleting */
GO
CREATE TRIGGER [BOBBY_TABLES].DELETE_FEATURE
ON [BOBBY_TABLES].ACTIVE_FEATURES
INSTEAD OF DELETE
AS
BEGIN
	UPDATE [BOBBY_TABLES].FEATURES SET inactive=0x1 WHERE id_feature = (SELECT d.id_feature FROM deleted d);
END
GO

GO
CREATE TRIGGER [BOBBY_TABLES].DELETE_FEATURE_PROT
ON [BOBBY_TABLES].FEATURES
INSTEAD OF DELETE
AS
BEGIN
	UPDATE [BOBBY_TABLES].FEATURES SET inactive=0x1 WHERE id_feature = (SELECT d.id_feature FROM deleted d);
END
GO

/* Set role inactive instead of deleting */
GO
CREATE TRIGGER [BOBBY_TABLES].DELETE_ROLE
ON [BOBBY_TABLES].ACTIVE_ROLES
INSTEAD OF DELETE
AS
BEGIN
	UPDATE [BOBBY_TABLES].ROLES SET inactive=0x1 WHERE id_role = (SELECT d.id_role FROM deleted d);
END
GO

GO
CREATE TRIGGER [BOBBY_TABLES].DELETE_ROLE_PROT
ON [BOBBY_TABLES].ROLES
INSTEAD OF DELETE
AS
BEGIN
	UPDATE [BOBBY_TABLES].ROLES SET inactive=0x1 WHERE id_role = (SELECT d.id_role FROM deleted d);
END
GO

/* -------------------------- */
/* RELATIONS DEFINITION ZONE  */
/* -------------------------- */

/* ADDING FOREIGN KEYS TO STATUS */
ALTER TABLE [BOBBY_TABLES].PERSONS
ADD FOREIGN KEY(stat) REFERENCES [BOBBY_TABLES].STAT(id_stat),
	FOREIGN KEY(doc_type) REFERENCES [BOBBY_TABLES].DOC_TYPE(doc_type),
	FOREIGN KEY(nationality) REFERENCES [BOBBY_TABLES].COUNTRIES(country);

ALTER TABLE [BOBBY_TABLES].HOTELS
ADD FOREIGN KEY(stat) REFERENCES [BOBBY_TABLES].STAT(id_stat),
	FOREIGN KEY(country) REFERENCES [BOBBY_TABLES].COUNTRIES(country);

ALTER TABLE [BOBBY_TABLES].ROOMS
ADD FOREIGN KEY(stat) REFERENCES [BOBBY_TABLES].STAT(id_stat);

ALTER TABLE [BOBBY_TABLES].REGIMENS
ADD FOREIGN KEY(stat) REFERENCES [BOBBY_TABLES].STAT(id_stat);

ALTER TABLE [BOBBY_TABLES].BOOKINGS
ADD FOREIGN KEY(stat) REFERENCES [BOBBY_TABLES].STAT(id_stat);

ALTER TABLE [BOBBY_TABLES].GUEST_BOOKINGS
ADD FOREIGN KEY(stat) REFERENCES [BOBBY_TABLES].STAT(id_stat);

ALTER TABLE [BOBBY_TABLES].STAYS
ADD FOREIGN KEY(stat) REFERENCES [BOBBY_TABLES].STAT(id_stat);


/* ADDING MANY TO MANY FOREIGN KEYS */
ALTER TABLE [BOBBY_TABLES].FEATURES_ROLES
ADD FOREIGN KEY(id_role) REFERENCES [BOBBY_TABLES].ROLES(id_role),
	FOREIGN KEY(id_feature) REFERENCES [BOBBY_TABLES].FEATURES(id_feature);
	
ALTER TABLE [BOBBY_TABLES].USER_HOTELS
ADD FOREIGN KEY(id_hotel) REFERENCES [BOBBY_TABLES].HOTELS(id_hotel),
	FOREIGN KEY(id_user) REFERENCES [BOBBY_TABLES].USERS(id_user);
	
ALTER TABLE [BOBBY_TABLES].REGIMEN_HOTEL
ADD FOREIGN KEY(id_hotel) REFERENCES [BOBBY_TABLES].HOTELS(id_hotel),
	FOREIGN KEY(id_regimen) REFERENCES [BOBBY_TABLES].REGIMENS(id_regimen);
	
ALTER TABLE [BOBBY_TABLES].STAY_EXTRAS
ADD FOREIGN KEY(id_stay) REFERENCES [BOBBY_TABLES].STAYS(id_stay),
	FOREIGN KEY(id_extra) REFERENCES [BOBBY_TABLES].EXTRAS(id_extra);

ALTER TABLE [BOBBY_TABLES].GUEST_BOOKINGS
ADD FOREIGN KEY(id_booking) REFERENCES [BOBBY_TABLES].BOOKINGS(id_booking),
	FOREIGN KEY(id_person) REFERENCES [BOBBY_TABLES].PERSONS(id_person);
	
ALTER TABLE [BOBBY_TABLES].USER_ROLES
ADD FOREIGN KEY(id_user) REFERENCES [BOBBY_TABLES].USERS(id_user),
	FOREIGN KEY(id_role) REFERENCES [BOBBY_TABLES].ROLES(id_role);
	

/* ADDING ONE TO MANY RELATIONS */
ALTER TABLE [BOBBY_TABLES].MANT_HISTORY
ADD FOREIGN KEY(id_history) REFERENCES [BOBBY_TABLES].HOTELS(id_hotel);

ALTER TABLE [BOBBY_TABLES].CANCELED_BOOKINGS
ADD FOREIGN KEY(id_user) REFERENCES [BOBBY_TABLES].USERS(id_user);

ALTER TABLE [BOBBY_TABLES].BOOKINGS
ADD FOREIGN KEY(id_roomtype) REFERENCES [BOBBY_TABLES].ROOM_TYPE(id_roomtype);


/* ADDING ONE TO ONE RELATIONS */
ALTER TABLE [BOBBY_TABLES].BILLS
ADD FOREIGN KEY(id_stay) REFERENCES [BOBBY_TABLES].STAYS(id_stay);

ALTER TABLE [BOBBY_TABLES].BILLS_ITEMS
ADD FOREIGN KEY(id_bill) REFERENCES [BOBBY_TABLES].BILLS(id_bill);

ALTER TABLE [BOBBY_TABLES].USERS
ADD FOREIGN KEY(id_person) REFERENCES [BOBBY_TABLES].PERSONS(id_person);

ALTER TABLE [BOBBY_TABLES].ROOMS
ADD FOREIGN KEY(id_hotel) REFERENCES [BOBBY_TABLES].HOTELS(id_hotel),
	FOREIGN KEY(id_roomtype) REFERENCES [BOBBY_TABLES].ROOM_TYPE(id_roomtype),
	FOREIGN KEY(id_location) REFERENCES [BOBBY_TABLES].ROOM_LOCATION(id_location);

ALTER TABLE [BOBBY_TABLES].STAYS
ADD FOREIGN KEY(id_stay) REFERENCES [BOBBY_TABLES].BOOKINGS(id_booking),
	FOREIGN KEY(id_room) REFERENCES [BOBBY_TABLES].ROOMS(id_room);
	
ALTER TABLE [BOBBY_TABLES].CANCELED_BOOKINGS
ADD FOREIGN KEY(id_booking) REFERENCES [BOBBY_TABLES].BOOKINGS(id_booking);


/* ----------------------- */
/* DEFAULT DATA LOAD ZONE  */
/* ----------------------- */

/* Adding new Status */
BEGIN TRANSACTION
	INSERT INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (301, 'Active Person');
	INSERT INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (302, 'Inactive Person');
	INSERT INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (303, 'Deleted Person');
	INSERT INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (304, 'Blocked Person');
COMMIT
BEGIN TRANSACTION
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (401, 'Active Hotel');
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (402, 'Hotel in Mantenience');
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (403, 'Closed Hotel');
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (404, 'Mantenience Proggramed');
COMMIT
BEGIN TRANSACTION
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (501, 'Active Regimen');
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (502, 'Inactive Regimen');
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (503, 'Deleted Regimen');
COMMIT
BEGIN TRANSACTION
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (601, 'Active Room');
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (602, 'Inactive Room');
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (603, 'Deleted Room');
COMMIT
BEGIN TRANSACTION
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (701, 'Active Booking');
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (702, 'Inactive Booking');
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (703, 'Deleted Booking');
COMMIT
BEGIN TRANSACTION
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (801, 'Pending');
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (802, 'Checked In');
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (803, 'Checked Out');
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (804, 'Unkown');
COMMIT
BEGIN TRANSACTION
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (901, 'Pending');
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (902, 'Checked In');
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (903, 'Checked Out');
	INSERT	INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (904, 'Unkown');
COMMIT

/* Adding new Roles */
BEGIN TRANSACTION
	INSERT	INTO [BOBBY_TABLES].ROLES(name)
			VALUES ('admin');
	INSERT	INTO [BOBBY_TABLES].ROLES(name)
			VALUES ('guest');
	INSERT	INTO [BOBBY_TABLES].ROLES(name)
			VALUES ('receptionist');
COMMIT

/* Adding new Features */
BEGIN TRANSACTION
	INSERT INTO BOBBY_TABLES.FEATURES(descr) 
				VALUES ('Admin');
	INSERT INTO BOBBY_TABLES.FEATURES(descr) 
				VALUES ('Guest');
	INSERT INTO BOBBY_TABLES.FEATURES(descr) 
				VALUES ('Receptionist');
COMMIT

/* Adding relations Roles-Features */
BEGIN TRANSACTION
	INSERT INTO BOBBY_TABLES.FEATURES_ROLES (id_role, id_feature)
		VALUES (1, 1);
	INSERT INTO BOBBY_TABLES.FEATURES_ROLES (id_role, id_feature)
		VALUES (2, 2);
	INSERT INTO BOBBY_TABLES.FEATURES_ROLES (id_role, id_feature)
		VALUES (3, 3);
COMMIT

/* Adding new Admin */  
-- Password: 'maximilianofelice' 
-- HASH: 53acbedaad48d8d482fe1a9bf8cd8b8e329ff8033c5c1dc81dcccdff38dd197f
BEGIN TRANSACTION
	INSERT	INTO [BOBBY_TABLES].PERSONS (name, lastname, mail, stat)
			VALUES ('Maximiliano', 'Felice', 'maximilianofelice@gmail.com', 301);
	INSERT	INTO [BOBBY_TABLES].USERS (id_person, username, pass)
			VALUES ((SELECT id_person FROM [BOBBY_TABLES].PERSONS WHERE name = 'Maximiliano' AND lastname = 'Felice'), 'MaximilianoFelice', '53acbedaad48d8d482fe1a9bf8cd8b8e329ff8033c5c1dc81dcccdff38dd197f');
COMMIT

/* Adding new Receptionist */  
-- Password: 'recept' 
-- HASH: 2e28ec6123cdea7edf950d6e594a0ae289ac531265c1e6a38a2815076eead077
BEGIN TRANSACTION
	INSERT	INTO [BOBBY_TABLES].PERSONS (name, lastname, mail, stat)
			VALUES ('Julian', 'Noziglia', 'julian@gmail.com', 301);
	INSERT	INTO [BOBBY_TABLES].USERS (id_person, username, pass)
			VALUES ((SELECT id_person FROM [BOBBY_TABLES].PERSONS WHERE name = 'Julian' AND lastname = 'Noziglia'), 'Receptionist', '2e28ec6123cdea7edf950d6e594a0ae289ac531265c1e6a38a2815076eead077');
COMMIT

/* Adding Guest user */  
-- Password: 'guest' 
-- HASH: 84983c60f7daadc1cb8698621f802c0d9f9a3c3c295c810748fb048115c186ec
BEGIN TRANSACTION
	INSERT	INTO [BOBBY_TABLES].PERSONS (name, lastname, mail, stat)
			VALUES ('Guest', 'Person', 'guest@guests.com', 301);
	INSERT	INTO [BOBBY_TABLES].USERS (id_person, username, pass)
			VALUES ((SELECT id_person FROM [BOBBY_TABLES].PERSONS WHERE name = 'Guest' AND lastname = 'Person'), 'Guest', '84983c60f7daadc1cb8698621f802c0d9f9a3c3c295c810748fb048115c186ec');
COMMIT

/* Adding Roles to Users */
BEGIN TRANSACTION
	INSERT	INTO [BOBBY_TABLES].USER_ROLES (id_role, id_user)
			VALUES (1, 1);
	INSERT	INTO [BOBBY_TABLES].USER_ROLES (id_role, id_user)
			VALUES (2, 3);
	INSERT	INTO [BOBBY_TABLES].USER_ROLES (id_role, id_user)
			VALUES (3, 2);
COMMIT

/* Adding Doc Types */
BEGIN TRANSACTION
	INSERT INTO [BOBBY_TABLES].DOC_TYPE (doc_type) VALUES ('Passport');
COMMIT


/* -------------------------------------- */
/*        MIGRATION ZONE HERE             */
/*             ...(SUCH IMPORTANCE, WOW!) */
/* -------------------------------------- */
BEGIN TRANSACTION

	/* Migrating countries */
	BEGIN TRANSACTION
		INSERT INTO [BOBBY_TABLES].COUNTRIES (country)
		SELECT DISTINCT Cliente_Nacionalidad FROM gd_esquema.Maestra;
	COMMIT 
	
	/* Migrating Hotel Data */
	BEGIN TRANSACTION
	
		INSERT	INTO [BOBBY_TABLES].HOTELS (name, city, street, street_num, stars, recharge_by_star, stat, country)
				SELECT DISTINCT RTRIM(Hotel_Ciudad)+' '+Hotel_Calle+' '+CAST(Hotel_Nro_Calle AS VARCHAR(18))+' - '+CAST(Hotel_CantEstrella AS VARCHAR(1)), Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, 401, 'ARGENTINO' FROM gd_esquema.Maestra;
	
	COMMIT
	
	/* Migrating Regimen Data */
	BEGIN TRANSACTION
	
		INSERT	INTO [BOBBY_TABLES].REGIMENS (descr, price, stat)
				SELECT DISTINCT Regimen_Descripcion, Regimen_Precio, 501 FROM gd_esquema.Maestra;
	
	COMMIT
	
	/* Migrating Room Type Data */
	BEGIN TRANSACTION
	
		SET IDENTITY_INSERT [BOBBY_TABLES].ROOM_TYPE ON
		
		INSERT	INTO [BOBBY_TABLES].ROOM_TYPE (id_roomtype, descr, perc)
				SELECT DISTINCT Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual FROM gd_esquema.Maestra;
	
		SET IDENTITY_INSERT [BOBBY_TABLES].ROOM_TYPE OFF
		
	COMMIT
	
	/* Migrating Extras */
	BEGIN TRANSACTION
		
		SET IDENTITY_INSERT [BOBBY_TABLES].EXTRAS ON
		
		INSERT	INTO [BOBBY_TABLES].EXTRAS (id_extra, descr, price)
				SELECT DISTINCT Consumible_Codigo, Consumible_Descripcion, Consumible_Precio FROM gd_esquema.Maestra
				WHERE Consumible_Codigo IS NOT NULL;
	
		SET IDENTITY_INSERT [BOBBY_TABLES].EXTRAS OFF
		
	COMMIT
	
	/* Migrating Existing Room Locations */
	BEGIN TRANSACTION 
	
		INSERT	INTO [BOBBY_TABLES].ROOM_LOCATION (descr)
				SELECT DISTINCT Habitacion_Frente FROM gd_esquema.Maestra;
	
	COMMIT
	
	/* Migrating People Data */
	BEGIN TRANSACTION
	
		/* Using GROUP BY statement for selecting distinct clients (rows are FK), and MIN() to get the rest of the fields as aggregate
		More info:
		http://www.devx.com/dbzone/Article/30149
		https://periscope.io/blog/use-subqueries-to-count-distinct-50x-faster.html
		http://stackoverflow.com/questions/11937206/sql-query-multiple-columns-using-distinct-on-one-column-only
		*/
		INSERT INTO [BOBBY_TABLES].PERSONS (name, lastname, doc_type, doc_number, mail, birthdate, street, street_num, dir_floor, dir_dpt, nationality, stat)
		SELECT MIN(Cliente_Nombre), MIN(Cliente_Apellido), 'Passport', Cliente_Pasaporte_Nro, MIN(Cliente_Mail), Cliente_Fecha_Nac, MIN(Cliente_Dom_Calle), MIN(Cliente_Nro_Calle), MIN(Cliente_Piso), MIN(Cliente_Depto), MIN(Cliente_Nacionalidad), 301
		FROM gd_esquema.Maestra
		GROUP BY Cliente_Pasaporte_Nro, Cliente_Fecha_Nac;
		
	COMMIT
	
	/* Created Joined Master Table for intermediate results */
	BEGIN TRANSACTION
		
		SELECT ma.Habitacion_Numero, ma.Habitacion_piso, ma.Reserva_Fecha_Inicio, ma.Reserva_Codigo, ma.Reserva_Cant_Noches, ma.Estadia_Fecha_Inicio, ma.Estadia_Cant_Noches, ma.Item_Factura_Cantidad, ma.Item_Factura_Monto, ma.Factura_Nro, ma.Factura_Fecha, ma.Factura_Total, hot.id_hotel, rt.id_roomtype, rl.id_location, rgs.id_regimen, ext.id_extra, per.id_person
		INTO #Joined_Master
		FROM gd_esquema.Maestra ma	LEFT OUTER JOIN [BOBBY_TABLES].HOTELS hot ON (ma.Hotel_Ciudad = hot.city AND
																				ma.Hotel_Calle = hot.street AND
																				ma.Hotel_Nro_Calle = hot.street_num)
									LEFT OUTER JOIN [BOBBY_TABLES].ROOM_TYPE rt ON (ma.Habitacion_Tipo_Codigo = rt.id_roomtype)
									LEFT OUTER JOIN [BOBBY_TABLES].ROOM_LOCATION rl ON (ma.Habitacion_Frente = rl.descr)
									LEFT OUTER JOIN [BOBBY_TABLES].REGIMENS rgs ON (ma.Regimen_Descripcion = rgs.descr AND
																				ma.Regimen_Precio = rgs.price)
									LEFT OUTER JOIN [BOBBY_TABLES].EXTRAS ext ON (ma.Consumible_Codigo = ext.id_extra)
									LEFT OUTER JOIN [BOBBY_TABLES].PERSONS per ON (ma.Cliente_Pasaporte_Nro = per.doc_number AND
																				ma.Cliente_Apellido = per.lastname AND
																				ma.Cliente_Nombre = per.name AND
																				ma.Cliente_Fecha_Nac = per.birthdate);
		CREATE INDEX Reserva_Codigo_Migration_Index
		ON #Joined_Master (Reserva_Codigo);

	COMMIT

	/* Migrating Existing Rooms */
	BEGIN TRANSACTION
					
		INSERT INTO [BOBBY_TABLES].ROOMS (number, room_floor, id_hotel, id_roomtype, id_location, stat)
		SELECT DISTINCT Habitacion_Numero, Habitacion_Piso, id_hotel, id_roomtype, id_location, 601 FROM #Joined_Master;
							
	COMMIT
	
	/* Migrating Existing Bookings */
	BEGIN TRANSACTION
	
		SET IDENTITY_INSERT [BOBBY_TABLES].BOOKINGS ON
		
		INSERT INTO [BOBBY_TABLES].BOOKINGS (id_booking, booking_start, nights, guests, id_hotel, id_regimen, regimen_price, stat, id_roomtype)
		SELECT DISTINCT Reserva_Codigo, Reserva_Fecha_Inicio, Reserva_Cant_Noches, 1, id_hotel, id_regimen, 
				(SELECT price FROM [BOBBY_TABLES].REGIMENS reg WHERE reg.id_regimen = jm.id_regimen),
				701, jm.id_roomtype
		FROM #Joined_Master jm;
		
		SET IDENTITY_INSERT [BOBBY_TABLES].BOOKINGS OFF
		
	COMMIT
	
	/* Migrating Clients registered to Bookings */
	BEGIN TRANSACTION
		
		INSERT INTO [BOBBY_TABLES].GUEST_BOOKINGS (id_booking, id_person, stat)
		SELECT DISTINCT Reserva_Codigo, id_person, 804 FROM #Joined_Master;
	
	COMMIT
	
	/* Migrating Stayings */
	BEGIN TRANSACTION
	
		INSERT INTO [BOBBY_TABLES].STAYS (id_stay, id_room, stay_start, nights, stat)
		SELECT DISTINCT jm.Reserva_Codigo, roo.id_room, jm.Estadia_Fecha_Inicio, jm.Estadia_Cant_Noches, 904
		FROM #Joined_Master jm INNER JOIN [BOBBY_TABLES].ROOMS roo ON	(roo.number = jm.Habitacion_Numero AND
																		roo.room_floor = jm.Habitacion_piso AND
																		roo.id_hotel = jm.id_hotel)
		WHERE jm.Estadia_Fecha_Inicio IS NOT NULL AND jm.Estadia_Cant_Noches IS NOT NULL;
		
	COMMIT
	
	/* Migrating Existing Bills */ 
	BEGIN TRANSACTION
	
		SET IDENTITY_INSERT [BOBBY_TABLES].BILLS ON 
		
		INSERT INTO [BOBBY_TABLES].BILLS (id_bill, payment_date, id_stay, stay_price)
		SELECT DISTINCT Factura_Nro, Factura_Fecha, Reserva_Codigo, Factura_Total 
		FROM #Joined_Master
		WHERE Factura_Nro IS NOT NULL;
	
		SET IDENTITY_INSERT [BOBBY_TABLES].BILLS OFF
		
	COMMIT
	
	/* Creating Auxiliary table to migrate Extras by Stay and Items by Bills */
	BEGIN TRANSACTION
	
		SELECT Reserva_Codigo, Factura_Nro, id_extra, Item_Factura_Monto, Item_Factura_Cantidad INTO #Billing_Extras_Info
		FROM #Joined_Master
		GROUP BY Reserva_Codigo, Factura_Nro, id_extra, Item_Factura_Monto, Item_Factura_Cantidad
		HAVING Factura_Nro IS NOT NULL;
	
	COMMIT 
	
	/* Migrating Existing Extras Per Stay */
	BEGIN TRANSACTION
		
		INSERT INTO [BOBBY_TABLES].STAY_EXTRAS (id_stay, id_extra, price, quantity)
		SELECT DISTINCT Reserva_Codigo, id_extra, Item_Factura_Monto, Item_Factura_Cantidad FROM #Billing_Extras_Info
		WHERE id_extra IS NOT NULL;
	
	COMMIT 
	
	/* Migrating Bills Items */
	BEGIN TRANSACTION
		
		INSERT INTO [BOBBY_TABLES].BILLS_ITEMS (id_bill, price, quantity)
		SELECT DISTINCT Factura_Nro, Item_Factura_Monto, Item_Factura_Cantidad FROM #Billing_Extras_Info
		WHERE Factura_Nro IS NOT NULL;
		
	COMMIT 
	
	/* Dropping auxiliary tables */
	DROP TABLE [BOBBY_TABLES].#Billing_Extras_Info;
	DROP TABLE [BOBBY_TABLES].#Joined_Master;
COMMIT


/* --------------------------- */
/* PROCEDURES DEFINITION ZONE  */
/* --------------------------- */

/* Creating Procedure to get features by roles */
GO
CREATE PROCEDURE [BOBBY_TABLES].GetRoleFeatures(
@Role INT = NULL, @RoleName VARCHAR(100) = NULL
)
AS
	SELECT * FROM [BOBBY_TABLES].ACTIVE_FEATURES feat 
			INNER JOIN [BOBBY_TABLES].FEATURES_ROLES fr ON (feat.id_feature = fr.id_feature)
			INNER JOIN [BOBBY_TABLES].ACTIVE_ROLES roles ON (roles.id_role = fr.id_role)
	WHERE (@Role IS NULL OR roles.id_role = @Role) AND (@RoleName IS NULL OR roles.name = @RoleName);
GO

/* Creating Procedure to get roles by username */
GO
CREATE PROCEDURE [BOBBY_TABLES].GetUserRoles(
@username VARCHAR(50)
)
AS
	SELECT * FROM BOBBY_TABLES.ACTIVE_USERS u
			INNER JOIN BOBBY_TABLES.USER_ROLES ur ON (ur.id_user = u.id_user)
			INNER JOIN BOBBY_TABLES.ACTIVE_ROLES r ON (ur.id_role = r.id_role)
	WHERE (u.username = @username);
GO

/* Creating procedure that validate user login */
GO
CREATE PROCEDURE [BOBBY_TABLES].validateUserPass (
@User VARCHAR(50), 
@Pass VARCHAR(64),
@Login_Attempts INTEGER = -1 OUTPUT,
@RESULT BIT = 0x0 OUTPUT )
AS
	DECLARE @Current_Pass VARCHAR(64);
	
	/* Checking if Username Exists */
	
	SET @Login_Attempts = -1;
	
	SELECT @Current_Pass=u.pass, @Login_Attempts=u.login_attempts FROM [BOBBY_TABLES].ACTIVE_USERS u WHERE username = @User;
	
	SET @RESULT = 0x0;
	
	IF @@ROWCOUNT > 0
	BEGIN
		IF @Pass = @Current_Pass
			BEGIN
				UPDATE [BOBBY_TABLES].ACTIVE_USERS	
				SET login_attempts = 0
				WHERE username = @User;
				SET @RESULT = 0x1;
				SET @Login_Attempts = 0;
				EXEC [BOBBY_TABLES].GetUserRoles @User;
			END
		ELSE
			BEGIN
				SET @Login_Attempts = @Login_Attempts + 1;
				UPDATE [BOBBY_TABLES].ACTIVE_USERS	
				SET login_attempts = @Login_Attempts
				WHERE username = @User;
			END
	END
	ELSE
		SET @Login_Attempts = -1;
	
GO

--=======================================
--FILTER HOTELS
--=======================================
GO
CREATE PROCEDURE [BOBBY_TABLES].SP_FILTER_HOTELS
(@Name VARCHAR(50) = NULL,
@Stars INTEGER = NULL,
@City VARCHAR(255) = NULL,
@Country VARCHAR(255) = NULL)
AS
	BEGIN
		SELECT * FROM [BOBBY_TABLES].HOTELS 
		WHERE
			((@Name IS NULL)  OR (name LIKE '%' + @Name + '%')) AND
			((@Stars IS NULL) OR (stars = @Stars)) AND
			((@City IS NULL) OR (city LIKE '%' + @City + '%')) AND
			((@Country IS NULL) OR (country LIKE '%' + @Country + '%'))
		ORDER BY name
    
    END
    
GO


--=======================================
--INSERT HOTEL_MANTEINANCE
--=======================================
GO
CREATE FUNCTION [BOBBY_TABLES].HotelIsEmptyBetween(
@id_hotel INT,
@s_date DATETIME,
@e_date DATETIME)
RETURNS BIT
AS
	BEGIN
		DECLARE @res INT;
		IF NOT EXISTS(	SELECT * FROM BOBBY_TABLES.BOOKINGS 
							WHERE id_hotel = @id_hotel AND
								booking_start >= (@s_date-nights) AND
								booking_start <= @e_date) SET @res = 0x0;
		ELSE SET @res = 0x1;
		
		RETURN @res;
	END
GO

GO
CREATE PROCEDURE [BOBBY_TABLES].CheckHotelsInMantenience(
@date DATETIME)
AS	
	SELECT DISTINCT h.id_hotel INTO #hotels FROM BOBBY_TABLES.HOTELS h
		INNER JOIN BOBBY_TABLES.MANT_HISTORY mh ON (h.id_hotel = mh.id_hotel)
		WHERE (mh.mant_end >= @date) AND (mh.mant_start <= @date);
	
	UPDATE BOBBY_TABLES.HOTELS
	SET stat = 402
	FROM BOBBY_TABLES.HOTELS h
	WHERE EXISTS(SELECT hot.id_hotel FROM #hotels hot WHERE hot.id_hotel = h.id_hotel) ;

GO

GO
CREATE PROCEDURE [BOBBY_TABLES].CheckHotelsAlreadyMantained(
@date DATETIME)
AS
	SELECT DISTINCT h.* INTO #hotels FROM BOBBY_TABLES.HOTELS h
				INNER JOIN BOBBY_TABLES.MANT_HISTORY mh ON (h.id_hotel = mh.id_hotel)
				WHERE (mh.mant_end < @date);
	
	UPDATE BOBBY_TABLES.HOTELS
	SET stat = 401
	FROM BOBBY_TABLES.HOTELS h
	WHERE EXISTS(SELECT hot.id_hotel FROM #hotels hot WHERE hot.id_hotel = h.id_hotel) ;
GO

GO
CREATE PROCEDURE [BOBBY_TABLES].CheckHotelsForMantenience(
@date DATETIME)
AS
	SELECT DISTINCT h.* INTO #hotels FROM BOBBY_TABLES.HOTELS h
			INNER JOIN BOBBY_TABLES.MANT_HISTORY mh ON (h.id_hotel = mh.id_hotel)
			WHERE (mh.mant_start > @date);
			
	UPDATE BOBBY_TABLES.HOTELS
	SET stat = 401
	FROM BOBBY_TABLES.HOTELS h
	WHERE EXISTS(SELECT hot.id_hotel FROM #hotels hot WHERE hot.id_hotel = h.id_hotel) ;
GO


GO
CREATE PROCEDURE [BOBBY_TABLES].SP_HOTEL_MANTEINANCE(
@IdHotel INTEGER,
@Start DATETIME,
@End DATETIME,
@Descr VARCHAR(255),
@Manteined BIT = 0x1 OUTPUT)
AS
	IF ([BOBBY_TABLES].HotelIsEmptyBetween(@IdHotel, @Start, @End) = 0x0)
	BEGIN
		--Updating hotel status, setting for mantenience
		UPDATE BOBBY_TABLES.HOTELS 
		SET stat = 404
		WHERE id_hotel = @IdHotel;
		SET @Manteined = 0x0;
	END
	SET @Manteined = 0x1;
GO

GO
CREATE PROCEDURE [BOBBY_TABLES].CheckMantenienceStatus(
@date DATETIME)
AS
	EXEC BOBBY_TABLES.CheckHotelsAlreadyMantained @date;
	EXEC BOBBY_TABLES.CheckHotelsForMantenience @date;
	EXEC BOBBY_TABLES.CheckHotelsInMantenience @date;
GO