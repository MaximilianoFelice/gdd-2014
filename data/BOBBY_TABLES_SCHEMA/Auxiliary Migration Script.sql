---------------- HOTELES ----------------
SELECT DISTINCT Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella INTO #Hotels FROM gd_esquema.Maestra;
SELECT * FROM #Hotels;

/* No hay inconsistencias en las direcciones de hoteles */
SELECT Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, COUNT(*) Cantidad_De_Repeticiones FROM #Hotels
GROUP BY Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle;

---------------- CLIENTES ----------------
SELECT DISTINCT Cliente_Pasaporte_Nro, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac, Cliente_Mail, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, Cliente_Nacionalidad INTO #Clientes FROM gd_esquema.Maestra;
SELECT * FROM #Clientes;

/* Se puede ver que hay clientes con el mismo numero de pasaporte */
SELECT Cliente_Pasaporte_Nro, COUNT(Cliente_Pasaporte_Nro) Cantidad_De_Repeticiones FROM #Clientes 
GROUP BY Cliente_Pasaporte_Nro
HAVING COUNT(Cliente_Pasaporte_Nro) > 1;

/* Buscamos un unique ID para Personas, con 100740 filas */
SELECT DISTINCT Cliente_Pasaporte_Nro, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac FROM #Clientes;



---------------- REGIMENES ---------------- /* No Problems */
SELECT DISTINCT Regimen_Descripcion, Regimen_Precio INTO #Regimens FROM gd_esquema.Maestra;
SELECT * FROM #Regimens;


---------------- ROOM TYPES ---------------- /* No Problems */
SELECT DISTINCT Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual INTO #Room_Type FROM gd_esquema.Maestra;
SELECT * FROM #Room_Type;



---------------- EXTRAS ---------------- /* NULL REGISTERED, MUST BE CLEANED */
SELECT DISTINCT Consumible_Codigo, Consumible_Descripcion, Consumible_Precio INTO #Extras FROM gd_esquema.Maestra;
SELECT * FROM #Extras;
SELECT * FROM #Extras WHERE Consumible_Codigo IS NULL;


---------------- ROOM LOCATION ----------------
SELECT DISTINCT Habitacion_Frente  INTO #Room_Loc FROM gd_esquema.Maestra;
SELECT * FROM #Room_Loc;


---------------- JOINED MASTER TABLE ----------------
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
SELECT * FROM #Joined_Master;

---------------- ROOMS ----------------
SELECT DISTINCT Habitacion_Numero, Habitacion_Piso, id_hotel, id_roomtype, id_location FROM #Joined_Master;

/* No hay habitaciones duplicadas en un mismo hotel */ --TODO: Rehacer para Joined_Master
SELECT COUNT(*) Cant_Habitaciones FROM (SELECT DISTINCT Reserva_Fecha_Inicio, Reserva_Codigo, Reserva_Cant_Noches, id_hotel, id_regimen FROM #Joined_Master)
GROUP BY Habitacion_Numero, Habitacion_Piso, id_hotel
HAVING COUNT(*) > 1; 


---------------- RESERVAS ----------------
SELECT DISTINCT Reserva_Fecha_Inicio, Reserva_Codigo, Reserva_Cant_Noches FROM #Joined_Master;

/* No hay inconsistencias de nombres de reserva */ --TODO: Rehacer para #Joined_Master
SELECT COUNT(*) FROM (SELECT DISTINCT Reserva_Fecha_Inicio, Reserva_Codigo, Reserva_Cant_Noches FROM #Joined_Master)
GROUP BY Reserva_Codigo
HAVING COUNT(*) > 1;

---------------- GUEST BOOKINGS ----------------
/* Para una misma reserva, no hay distintos clientes (solo uno, el que reservó)*/
SELECT DISTINCT Reserva_Codigo, id_person INTO #BOOKING_GUEST FROM #Joined_Master;
SELECT Reserva_Codigo, COUNT(*) FROM #BOOKING_GUEST
GROUP BY Reserva_Codigo, id_person
HAVING COUNT(*) > 1;
DROP TABLE #BOOKING_GUEST;


---------------- STAYINGS ---------------- /* Hay valores NULL */
SELECT DISTINCT Reserva_Codigo, Estadia_Fecha_Inicio, Estadia_Cant_Noches FROM #Joined_Master
WHERE Estadia_Fecha_Inicio IS NOT NULL OR Estadia_Cant_Noches IS NOT NULL
ORDER BY Reserva_Codigo;

/* No hay estadias duplicadas para una misma reserva */
SELECT DISTINCT Reserva_Codigo, Estadia_Fecha_Inicio, Estadia_Cant_Noches INTO #staying_dup FROM #Joined_Master
WHERE Estadia_Fecha_Inicio IS NOT NULL OR Estadia_Cant_Noches IS NOT NULL
ORDER BY Reserva_Codigo;

SELECT DISTINCT Reserva_Codigo, COUNT(*) FROM #staying_dup
GROUP BY  Reserva_Codigo
HAVING COUNT(*) > 1;

DROP TABLE #staying_dup

SELECT DISTINCT Reserva_Codigo, Estadia_Fecha_Inicio, Estadia_Cant_Noches INTO #Stayings
FROM #Joined_Master
WHERE Estadia_Fecha_Inicio IS NOT NULL OR Estadia_Cant_Noches IS NOT NULL
ORDER BY Reserva_Codigo;

SELECT * FROM #Stayings;

SELECT DISTINCT sta.Reserva_Codigo, sta.Estadia_Fecha_Inicio, sta.Estadia_Cant_Noches, 904
FROM #Stayings sta  LEFT OUTER JOIN #Joined_Master jm ON (sta.Reserva_Codigo = jm.Reserva_Codigo)
					LEFT OUTER JOIN [BOBBY_TABLES].ROOMS roo ON (roo.number = jm.Habitacion_Numero AND
															roo.room_floor = jm.Habitacion_piso AND
															roo.id_hotel = jm.id_hotel);
																	
																	
---------------- BILLING ----------------
SELECT DISTINCT id_person, Factura_Nro, Factura_Fecha, Factura_Total FROM #Joined_Master
WHERE Factura_Nro IS NOT NULL;


DROP TABLE #Hotels;
DROP TABLE #Clientes;
DROP TABLE #Regimens;
DROP TABLE #Room_Type;
DROP TABLE #Extras;
DROP TABLE #Room_Loc;
DROP TABLE #Joined_Master;

SELECT * FROM gd_esquema.Maestra;