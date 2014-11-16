SELECT * FROM BOBBY_TABLES.ACTIVE_ROLES;

SELECT * FROM BOBBY_TABLES.ACTIVE_FEATURES;

SELECT * FROM BOBBY_TABLES.FEATURES_ROLES;


INSERT INTO BOBBY_TABLES.FEATURES(descr) VALUES ('Admin');
INSERT INTO BOBBY_TABLES.FEATURES(descr) VALUES ('Other');
INSERT INTO BOBBY_TABLES.FEATURES(descr) VALUES ('Another');
INSERT INTO BOBBY_TABLES.FEATURES(descr) VALUES ('Then');
INSERT INTO BOBBY_TABLES.FEATURES(descr) VALUES ('Recepcionista');

INSERT INTO BOBBY_TABLES.FEATURES_ROLES (id_role, id_feature)
VALUES (1, 1);
INSERT INTO BOBBY_TABLES.FEATURES_ROLES (id_role, id_feature)
VALUES (1, 2);
INSERT INTO BOBBY_TABLES.FEATURES_ROLES (id_role, id_feature)
VALUES (3, 5);
INSERT INTO BOBBY_TABLES.FEATURES_ROLES (id_role, id_feature)
VALUES (3, 2);

EXEC BOBBY_TABLES.GetRoleFeatures 3;