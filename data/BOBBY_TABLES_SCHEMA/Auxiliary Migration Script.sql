---------------- HOTELES ----------------
SELECT DISTINCT Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella INTO #Hotels FROM gd_esquema.Maestra;
SELECT * FROM #Hotels;

/* No hay inconsistencias en las direcciones de hoteles */
SELECT Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, COUNT(*) Cantidad_De_Repeticiones FROM #Hotels
GROUP BY Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle;

---------------- CLIENTES ----------------
SELECT DISTINCT Cliente_Pasaporte_Nro, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac, Cliente_Mail, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, Cliente_Nacionalidad INTO #Clientes FROM gd_esquema.Maestra;
SELECT * FROM #Clientes;

/* Se puede ver que hay clientes con el mismo numero de pasaporte repetidos */
SELECT Cliente_Pasaporte_Nro, COUNT(Cliente_Pasaporte_Nro) Cantidad_De_Repeticiones FROM #Clientes 
GROUP BY Cliente_Pasaporte_Nro
HAVING COUNT(Cliente_Pasaporte_Nro) > 1;



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


---------------- ROOMS ----------------
SELECT DISTINCT ma.Habitacion_Numero, ma.Habitacion_Piso, hot.id_hotel, rt.id_roomtype, rl.id_location INTO #Rooms
FROM gd_esquema.Maestra ma	INNER JOIN [BOBBY_TABLES].HOTELS hot ON (ma.Hotel_Ciudad = hot.city AND
																	ma.Hotel_Calle = hot.street AND
																	ma.Hotel_Nro_Calle = hot.street_num)
							INNER JOIN [BOBBY_TABLES].ROOM_TYPE rt ON (ma.Habitacion_Tipo_Codigo = rt.id_roomtype)
							INNER JOIN [BOBBY_TABLES].ROOM_LOCATION rl ON (ma.Habitacion_Frente = rl.descr);
SELECT * FROM #Rooms;

/* No hay habitaciones duplicadas en un mismo hotel */ 
SELECT COUNT(*) Cant_Habitaciones FROM #Rooms
GROUP BY Habitacion_Numero, Habitacion_Piso, id_hotel
HAVING COUNT(*) > 1; 



DROP TABLE #Hotels;
DROP TABLE #Clientes;
DROP TABLE #Regimens;
DROP TABLE #Room_Type;
DROP TABLE #Extras;
DROP TABLE #Room_Loc;
DROP TABLE #Rooms;

SELECT * FROM gd_esquema.Maestra;