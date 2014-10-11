USE [GD2C2014]
GO

/* TABLE DROPPING */
/* Many To Many Relations */
DROP TABLE [BOBBY_TABLES].FEATURES_ROLES;
DROP TABLE [BOBBY_TABLES].USER_HOTELS;
DROP TABLE [BOBBY_TABLES].REGIMEN_HOTEL;
DROP TABLE [BOBBY_TABLES].GUEST_BOOKINGS;
DROP TABLE [BOBBY_TABLES].STAY_EXTRAS;
DROP TABLE [BOBBY_TABLES].USER_ROLES;
/* One To Many Single Relations */
DROP TABLE [BOBBY_TABLES].ROLES;
DROP TABLE [BOBBY_TABLES].BILLS;
DROP TABLE [BOBBY_TABLES].STAYS;
DROP TABLE [BOBBY_TABLES].MANT_HISTORY;
DROP TABLE [BOBBY_TABLES].ROOMS;
DROP TABLE [BOBBY_TABLES].USERS;
/* Non Referencing tables */
DROP TABLE [BOBBY_TABLES].PERSONS;
DROP TABLE [BOBBY_TABLES].FEATURES;
DROP TABLE [BOBBY_TABLES].HOTELS;
DROP TABLE [BOBBY_TABLES].ROOM_LOCATION;
DROP TABLE [BOBBY_TABLES].ROOM_TYPE;
DROP TABLE [BOBBY_TABLES].REGIMENS;
DROP TABLE [BOBBY_TABLES].BOOKINGS;
DROP TABLE [BOBBY_TABLES].EXTRAS;
/* Deleting at last */
DROP TABLE [BOBBY_TABLES].STAT;
GO

/* SCHEMA DELETING */
DROP SCHEMA [BOBBY_TABLES];
GO