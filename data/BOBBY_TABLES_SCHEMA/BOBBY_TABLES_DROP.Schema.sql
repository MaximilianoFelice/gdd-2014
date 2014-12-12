USE [GD2C2014]
GO

/* FUNCTION DROPPING */
DROP FUNCTION [BOBBY_TABLES].HotelIsEmptyBetween;

/* PROCEDURE DROPPING */
DROP PROCEDURE [BOBBY_TABLES].validateUserPass;
DROP PROCEDURE [BOBBY_TABLES].GetRoleFeatures;
DROP PROCEDURE [BOBBY_TABLES].GetUserRoles;
DROP PROCEDURE [BOBBY_TABLES].SP_BOOKING_PRICE;
DROP PROCEDURE [BOBBY_TABLES].SP_DELETE_PERSON;
DROP PROCEDURE [BOBBY_TABLES].SP_EMAIL_EXISTS;
DROP PROCEDURE [BOBBY_TABLES].SP_EMAIL_EXISTS_UPDATE;
DROP PROCEDURE [BOBBY_TABLES].SP_HOTEL_MANTEINANCE;
DROP PROCEDURE [BOBBY_TABLES].SP_INSERT_PERSON;
DROP PROCEDURE [BOBBY_TABLES].SP_INSERT_HOTEL;
DROP PROCEDURE [BOBBY_TABLES].SP_INSERT_REGIMENS_HOTEL;
DROP PROCEDURE [BOBBY_TABLES].SP_INSERT_ROOM;
DROP PROCEDURE [BOBBY_TABLES].SP_PERSON_EXISTS;
DROP PROCEDURE [BOBBY_TABLES].SP_ROOM_EXISTS;
DROP PROCEDURE [BOBBY_TABLES].SP_STATISTICS_EXTRA_BILLED;
DROP PROCEDURE [BOBBY_TABLES].SP_STATISTICS_OCCUPIED_ROOMS;
DROP PROCEDURE [BOBBY_TABLES].SP_STATISTICS_OUT_SERVICE;
DROP PROCEDURE [BOBBY_TABLES].SP_UPDATE_PERSON;
DROP PROCEDURE [BOBBY_TABLES].SP_UPDATE_ROOM;
DROP PROCEDURE [BOBBY_TABLES].SP_FILTER_HOTELS;
DROP PROCEDURE [BOBBY_TABLES].SP_HOTEL_MANTEINANCE;
DROP PROCEDURE [BOBBY_TABLES].CheckHotelsInMantenience;
DROP PROCEDURE [BOBBY_TABLES].CheckHotelsAlreadyMantained;
DROP PROCEDURE [BOBBY_TABLES].CheckHotelsForMantenience;
DROP PROCEDURE [BOBBY_TABLES].CheckMantenienceStatus;
DROP FUNCTION [BOBBY_TABLES].HotelIsEmptyBetween;

/* TRIGGERS DROPPING */
DROP TRIGGER [BOBBY_TABLES].CHECK_USER_ATTEMPTS;
DROP TRIGGER [BOBBY_TABLES].DELETE_FEATURE;
DROP TRIGGER [BOBBY_TABLES].DELETE_ROLE;
DROP TRIGGER [BOBBY_TABLES].DELETE_FEATURE_PROT;
DROP TRIGGER [BOBBY_TABLES].DELETE_ROLE_PROT;

/* VIEW DROPPING */
DROP VIEW [BOBBY_TABLES].ACTIVE_USERS;
DROP VIEW [BOBBY_TABLES].INACTIVE_USERS;
DROP VIEW [BOBBY_TABLES].DELETED_USERS;
DROP VIEW [BOBBY_TABLES].ACTIVE_FEATURES;
DROP VIEW [BOBBY_TABLES].ACTIVE_ROLES;
DROP VIEW [BOBBY_TABLES].ACTIVE_HOTELS;

/* TABLE DROPPING */
/* Many To Many Relations */
DROP TABLE [BOBBY_TABLES].FEATURES_ROLES;
DROP TABLE [BOBBY_TABLES].USER_HOTELS;
DROP TABLE [BOBBY_TABLES].REGIMEN_HOTEL;
DROP TABLE [BOBBY_TABLES].GUEST_BOOKINGS;
DROP TABLE [BOBBY_TABLES].STAY_EXTRAS;
DROP TABLE [BOBBY_TABLES].USER_ROLES;
/* One To Many Single Relations */
DROP TABLE [BOBBY_TABLES].CANCELED_BOOKINGS;
DROP TABLE [BOBBY_TABLES].BILLS_ITEMS;
DROP TABLE [BOBBY_TABLES].ROLES;
DROP TABLE [BOBBY_TABLES].BILLS;
DROP TABLE [BOBBY_TABLES].STAYS;
DROP TABLE [BOBBY_TABLES].MANT_HISTORY;
DROP TABLE [BOBBY_TABLES].ROOMS;
DROP TABLE [BOBBY_TABLES].USERS;
DROP TABLE [BOBBY_TABLES].PERSONS;
/* Non Referencing tables */
DROP TABLE [BOBBY_TABLES].DOC_TYPE;
DROP TABLE [BOBBY_TABLES].FEATURES;
DROP TABLE [BOBBY_TABLES].HOTELS;
DROP TABLE [BOBBY_TABLES].ROOM_LOCATION;
DROP TABLE [BOBBY_TABLES].REGIMENS;
DROP TABLE [BOBBY_TABLES].BOOKINGS;
DROP TABLE [BOBBY_TABLES].ROOM_TYPE;
DROP TABLE [BOBBY_TABLES].EXTRAS;
DROP TABLE [BOBBY_TABLES].COUNTRIES;
/* Deleting at last */
DROP TABLE [BOBBY_TABLES].STAT;
GO

/* SCHEMA DELETING */
DROP SCHEMA [BOBBY_TABLES];
GO