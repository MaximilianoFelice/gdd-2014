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
addr VARCHAR(100),
street VARCHAR(100),
street_num INTEGER,
dir_floor INTEGER,
dir_dpt VARCHAR(5),
nationality VARCHAR(50),
stat INTEGER NOT NULL,
PRIMARY KEY (id_person),
UNIQUE (doc_type, doc_number, lastname, name, birthdate)
);

CREATE TABLE [BOBBY_TABLES].ROLES (
id_role INTEGER NOT NULL IDENTITY(1,1),
name VARCHAR(100) NOT NULL,
stat INTEGER NOT NULL,
PRIMARY KEY (id_role)
);

CREATE TABLE [BOBBY_TABLES].USER_ROLES (
id_user INTEGER NOT NULL,
id_role INTEGER NOT NULL,
PRIMARY KEY(id_user, id_role)
);

CREATE TABLE [BOBBY_TABLES].FEATURES (
id_feature INTEGER NOT NULL,			-- Handles it's own codification system
descr VARCHAR(255),
stat INTEGER NOT NULL,
PRIMARY KEY (id_feature)
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
pass VARCHAR(32) NOT NULL,
login_attempts NUMERIC(1,0) NOT NULL DEFAULT(0),
stat INTEGER NOT NULL,
PRIMARY KEY(id_user)
);

CREATE TABLE [BOBBY_TABLES].USER_HOTELS (
id_hotel INTEGER NOT NULL,
id_user INTEGER NOT NULL,
PRIMARY KEY (id_hotel, id_user)
);

CREATE TABLE [BOBBY_TABLES].HOTELS (
id_hotel INTEGER NOT NULL IDENTITY(1,1),
name VARCHAR(50),
city VARCHAR(255),
street VARCHAR(255),
street_num INTEGER,
stars INTEGER NOT NULL,
recharge_by_star INTEGER NOT NULL,
stat INTEGER NOT NULL,
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
regimen_price FLOAT NOT NULL,
guests INTEGER NOT NULL DEFAULT(0),
booking_start DATETIME NOT NULL,
nights INTEGER,
stat INTEGER NOT NULL
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
id_stay INTEGER NOT NULL,
id_extra INTEGER NOT NULL, 
price FLOAT NOT NULL,
quantity INTEGER NOT NULL,
PRIMARY KEY (id_stay, id_extra)
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


/* -------------------------- */
/* RELATIONS DEFINITION ZONE  */
/* -------------------------- */

/* ADDING FOREIGN KEYS TO STATUS */
ALTER TABLE [BOBBY_TABLES].PERSONS
ADD FOREIGN KEY(stat) REFERENCES [BOBBY_TABLES].STAT(id_stat);

ALTER TABLE [BOBBY_TABLES].ROLES
ADD FOREIGN KEY(stat) REFERENCES [BOBBY_TABLES].STAT(id_stat);

ALTER TABLE [BOBBY_TABLES].FEATURES
ADD FOREIGN KEY(stat) REFERENCES [BOBBY_TABLES].STAT(id_stat);

ALTER TABLE [BOBBY_TABLES].HOTELS
ADD FOREIGN KEY(stat) REFERENCES [BOBBY_TABLES].STAT(id_stat);

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

ALTER TABLE [BOBBY_TABLES].USERS
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
ALTER TABLE [BOBBY_TABLES].USERS
ADD FOREIGN KEY(id_person) REFERENCES [BOBBY_TABLES].PERSONS(id_person);

ALTER TABLE [BOBBY_TABLES].ROOMS
ADD FOREIGN KEY(id_hotel) REFERENCES [BOBBY_TABLES].HOTELS(id_hotel),
	FOREIGN KEY(id_roomtype) REFERENCES [BOBBY_TABLES].ROOM_TYPE(id_roomtype),
	FOREIGN KEY(id_location) REFERENCES [BOBBY_TABLES].ROOM_LOCATION(id_location);

ALTER TABLE [BOBBY_TABLES].MANT_HISTORY
ADD FOREIGN KEY(id_history) REFERENCES [BOBBY_TABLES].HOTELS(id_hotel);

ALTER TABLE [BOBBY_TABLES].STAYS
ADD FOREIGN KEY(id_stay) REFERENCES [BOBBY_TABLES].BOOKINGS(id_booking),
	FOREIGN KEY(id_room) REFERENCES [BOBBY_TABLES].ROOMS(id_room);
	
ALTER TABLE [BOBBY_TABLES].BILLS
ADD FOREIGN KEY(id_stay) REFERENCES [BOBBY_TABLES].STAYS(id_stay);



/* ----------------------- */
/* DEFAULT DATA LOAD ZONE  */
/* ----------------------- */

/* Adding new Status */
BEGIN TRANSACTION
	INSERT INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (101, 'Active User');
	INSERT INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (102, 'Inactive User');
	INSERT INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (103, 'Deleted User');
	INSERT INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (104, 'Blocked User');
COMMIT
BEGIN TRANSACTION
	INSERT INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (201, 'Active Role');
	INSERT INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (202, 'Inactive Role');
	INSERT INTO [BOBBY_TABLES].STAT (id_stat, descr)
			VALUES (203, 'Deleted Role');
COMMIT
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
	INSERT	INTO [BOBBY_TABLES].ROLES(name, stat)
			VALUES ('admin', 201);
	INSERT	INTO [BOBBY_TABLES].ROLES(name, stat)
			VALUES ('guest', 201);
	INSERT	INTO [BOBBY_TABLES].ROLES(name, stat)
			VALUES ('recepcionista', 201);
COMMIT

/* Adding new Admin */  
-- BEWARE!! It should be using SHA2_256 algorithm but it's not supportted by SQLSERVER 2008 R2 or under (http://msdn.microsoft.com/en-us/library/ms174415%28v=sql.105%29.aspx)
-- Using MD5 instead...
BEGIN TRANSACTION
	INSERT	INTO [BOBBY_TABLES].PERSONS (name, lastname, mail, stat)
			VALUES ('Maximiliano', 'Felice', 'maximilianofelice@gmail.com', 301);
	INSERT	INTO [BOBBY_TABLES].USERS (id_person, username, pass, stat)
			VALUES ((SELECT id_person FROM [BOBBY_TABLES].PERSONS WHERE name = 'Maximiliano' AND lastname = 'Felice'), 'MaximilianoFelice', HASHBYTES('MD5', 'maximilianofelice'), 101);
COMMIT

/* Adding Roles to Users */
BEGIN TRANSACTION
	INSERT	INTO [BOBBY_TABLES].USER_ROLES (id_role, id_user)
			VALUES (1, 1);
COMMIT


/* -------------------------------------- */
/*        MIGRATION ZONE HERE             */
/*             ...(SUCH IMPORTANCE, WOW!) */
/* -------------------------------------- */
BEGIN TRANSACTION

	/* Migrating Hotel Data */
	BEGIN TRANSACTION
	
		SELECT DISTINCT Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella INTO [BOBBY_TABLES].#Hotels FROM gd_esquema.Maestra;
		INSERT	INTO [BOBBY_TABLES].HOTELS (city, street, street_num, stars, recharge_by_star, stat)
				SELECT Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, 401 FROM [BOBBY_TABLES].#Hotels;
	
	COMMIT
	
	/* Migrating Regimen Data */
	BEGIN TRANSACTION
	
		SELECT DISTINCT Regimen_Descripcion, Regimen_Precio INTO #Regimens FROM gd_esquema.Maestra;
		INSERT	INTO [BOBBY_TABLES].REGIMENS (descr, price, stat)
				SELECT Regimen_Descripcion, Regimen_Precio, 501 FROM #Regimens;
	
	COMMIT
	
	/* Migrating Room Type Data */
	BEGIN TRANSACTION
	
		SET IDENTITY_INSERT [BOBBY_TABLES].ROOM_TYPE ON
		
		SELECT DISTINCT Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual INTO #Room_Type FROM gd_esquema.Maestra;
		INSERT	INTO [BOBBY_TABLES].ROOM_TYPE (id_roomtype, descr, perc)
				SELECT Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual FROM #Room_Type;
	
		SET IDENTITY_INSERT [BOBBY_TABLES].ROOM_TYPE OFF
		
	COMMIT
	
	/* Migrating Extras */
	BEGIN TRANSACTION
		
		SET IDENTITY_INSERT [BOBBY_TABLES].EXTRAS ON
		
		SELECT DISTINCT Consumible_Codigo, Consumible_Descripcion, Consumible_Precio INTO #Extras FROM gd_esquema.Maestra WHERE Consumible_Codigo IS NOT NULL;
		INSERT	INTO [BOBBY_TABLES].EXTRAS (id_extra, descr, price)
				SELECT Consumible_Codigo, Consumible_Descripcion, Consumible_Precio FROM #Extras;
	
		SET IDENTITY_INSERT [BOBBY_TABLES].EXTRAS OFF
	COMMIT
	
	/* Migrating Existing Room Locations */
	BEGIN TRANSACTION 
	
		SELECT DISTINCT Habitacion_Frente  INTO #Room_Loc FROM gd_esquema.Maestra;
		INSERT	INTO [BOBBY_TABLES].ROOM_LOCATION (descr)
				SELECT Habitacion_Frente FROM #Room_Loc;
	
	COMMIT
	
	/* Migrating People Data */
	BEGIN TRANSACTION
	
		SELECT DISTINCT Cliente_Pasaporte_Nro, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac, Cliente_Mail, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, Cliente_Nacionalidad INTO #Persons FROM gd_esquema.Maestra;
		
		INSERT INTO [BOBBY_TABLES].PERSONS (name, lastname, doc_type, doc_number, mail, birthdate, street, street_num, dir_floor, dir_dpt, nationality, stat)
		SELECT Cliente_Nombre, Cliente_Apellido, 'Passport', Cliente_Pasaporte_Nro, Cliente_Mail, Cliente_Fecha_Nac, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, Cliente_Nacionalidad, 301
		FROM #Persons;

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

	COMMIT

	/* Migrating Existing Rooms */
	BEGIN TRANSACTION
	
		SELECT DISTINCT Habitacion_Numero, Habitacion_Piso, id_hotel, id_roomtype, id_location INTO #Rooms
		FROM #Joined_Master;
									
		INSERT INTO [BOBBY_TABLES].ROOMS (number, room_floor, id_hotel, id_roomtype, id_location, stat)
		SELECT Habitacion_Numero, Habitacion_Piso, id_hotel, id_roomtype, id_location, 601 FROM #Rooms;
							
	COMMIT
	
	/* Migrating Existing Bookings */
	BEGIN TRANSACTION
	
		SET IDENTITY_INSERT [BOBBY_TABLES].BOOKINGS ON
		
		SELECT DISTINCT Reserva_Codigo, Reserva_Fecha_Inicio, Reserva_Cant_Noches, id_hotel, id_regimen INTO #Bookings
		FROM #Joined_Master;
		
		INSERT INTO [BOBBY_TABLES].BOOKINGS (id_booking, booking_start, guests, id_hotel, id_regimen, regimen_price, stat)
		SELECT Reserva_Codigo, Reserva_Fecha_Inicio, 1, id_hotel, id_regimen, 
				(SELECT price FROM [BOBBY_TABLES].REGIMENS reg WHERE reg.id_regimen = jm.id_regimen),
				701
		FROM #Bookings jm;
		
		SET IDENTITY_INSERT [BOBBY_TABLES].BOOKINGS OFF
		
	COMMIT
	
	/* Migrating Clients registered to Bookings */
	BEGIN TRANSACTION
		
		INSERT INTO [BOBBY_TABLES].GUEST_BOOKINGS (id_booking, id_person, stat)
		SELECT DISTINCT Reserva_Codigo, id_person, 804 FROM #Joined_Master;
	
	COMMIT
	
	/* Migrating Stayings */
	BEGIN TRANSACTION
	
		SELECT DISTINCT Reserva_Codigo, Estadia_Fecha_Inicio, Estadia_Cant_Noches INTO #Stayings
		FROM #Joined_Master
		WHERE Estadia_Fecha_Inicio IS NOT NULL OR Estadia_Cant_Noches IS NOT NULL
		ORDER BY Reserva_Codigo;
		
		INSERT INTO [BOBBY_TABLES].STAYS (id_stay, id_room, stay_start, nights, stat)
		SELECT DISTINCT sta.Reserva_Codigo, roo.id_room, sta.Estadia_Fecha_Inicio, sta.Estadia_Cant_Noches, 904
		FROM #Stayings sta  INNER JOIN #Joined_Master jm ON (sta.Reserva_Codigo = jm.Reserva_Codigo)
							INNER JOIN [BOBBY_TABLES].ROOMS roo ON (roo.number = jm.Habitacion_Numero AND
																	roo.room_floor = jm.Habitacion_piso AND
																	roo.id_hotel = jm.id_hotel);
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
	
	/* Dropping auxiliary tables */
	DROP TABLE [BOBBY_TABLES].#Hotels;
	DROP TABLE [BOBBY_TABLES].#Regimens;
	DROP TABLE [BOBBY_TABLES].#Room_Type;
	DROP TABLE [BOBBY_TABLES].#Extras;
	DROP TABLE [BOBBY_TABLES].#Room_Loc;
	DROP TABLE [BOBBY_TABLES].#Persons;
	DROP TABLE [BOBBY_TABLES].#Rooms;
	DROP TABLE [BOBBY_TABLES].#Bookings;
	DROP TABLE [BOBBY_TABLES].#Stayings;
	DROP TABLE [BOBBY_TABLES].#Joined_Master;
COMMIT