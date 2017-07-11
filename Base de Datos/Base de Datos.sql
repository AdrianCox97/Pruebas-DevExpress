/*
 * ER/Studio 8.0 SQL Code Generation
 * Company :      Entara
 * Project :      BDPruebas.DM1
 * Author :       Adrian Cox
 *
 * Date Created : Tuesday, July 11, 2017 13:07:31
 * Target DBMS : Microsoft SQL Server 2008
 */

USE master
go
CREATE DATABASE BDPruebas
go
USE BDPruebas
go

/****************************** TABLAS ******************************/

/* 
 * TABLE: ALUMNOS 
 */

CREATE TABLE ALUMNOS(
    Matricula          varchar(10)    NOT NULL,
    NombreAlumno       varchar(50)    NOT NULL,
    ApellidoPaterno    varchar(25)    NOT NULL,
    ApellidoMaterno    varchar(25)    NOT NULL,
    Correo             varchar(75)    NOT NULL,
    Contrasenia        varchar(75)    NOT NULL,
    Telefono           varchar(10)    NULL,
    Status             bit            NOT NULL,
    IDCarrera          int            NOT NULL,
    IDGrupo            int            NOT NULL,
    CONSTRAINT PK1 PRIMARY KEY NONCLUSTERED (Matricula)
)
go

IF OBJECT_ID('ALUMNOS') IS NOT NULL
    PRINT '<<< CREATED TABLE ALUMNOS >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE ALUMNOS >>>'
go

/* 
 * TABLE: BITACORA 
 */

CREATE TABLE BITACORA(
    CLAVE            int              IDENTITY(1,1),
    PK               nvarchar(max)    NOT NULL,
    ACCION           char(1)          NOT NULL,
    TABLA            nvarchar(max)    NOT NULL,
    CAMPO            nvarchar(max)    NOT NULL,
    VALORORIGINAL    nvarchar(max)    NOT NULL,
    VALORNUEVO       nvarchar(max)    NOT NULL,
    FECHA            datetime2(7)     NOT NULL,
    IDUSUARIO        nvarchar(max)    NOT NULL,
    CONSTRAINT PK6 PRIMARY KEY NONCLUSTERED (CLAVE)
)
go

IF OBJECT_ID('BITACORA') IS NOT NULL
    PRINT '<<< CREATED TABLE BITACORA >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE BITACORA >>>'
go

/* 
 * TABLE: CARRERAS 
 */

CREATE TABLE CARRERAS(
    IDCarrera        int            IDENTITY(1,1),
    NombreCarrera    varchar(70)    NOT NULL,
    Status           bit            NOT NULL,
    IDDivision       int            NOT NULL,
    CONSTRAINT PK2 PRIMARY KEY NONCLUSTERED (IDCarrera)
)
go

IF OBJECT_ID('CARRERAS') IS NOT NULL
    PRINT '<<< CREATED TABLE CARRERAS >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE CARRERAS >>>'
go

/* 
 * TABLE: DIVISIONES 
 */

CREATE TABLE DIVISIONES(
    IDDivision        int            IDENTITY(1,1),
    NombreDivision    varchar(70)    NOT NULL,
    Status            bit            NOT NULL,
    CONSTRAINT PK3 PRIMARY KEY NONCLUSTERED (IDDivision)
)
go

IF OBJECT_ID('DIVISIONES') IS NOT NULL
    PRINT '<<< CREATED TABLE DIVISIONES >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE DIVISIONES >>>'
go

/* 
 * TABLE: GRUPOS 
 */

CREATE TABLE GRUPOS(
    IDGrupo         int        IDENTITY(1,1),
    Cuatrimestre    char(1)    NOT NULL,
    Grupo           char(1)    NOT NULL,
    Status          bit        NOT NULL,
    CONSTRAINT PK5 PRIMARY KEY NONCLUSTERED (IDGrupo)
)
go

IF OBJECT_ID('GRUPOS') IS NOT NULL
    PRINT '<<< CREATED TABLE GRUPOS >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE GRUPOS >>>'
go

/* 
 * TABLE: ALUMNOS 
 */

ALTER TABLE ALUMNOS ADD CONSTRAINT RefCARRERAS4 
    FOREIGN KEY (IDCarrera)
    REFERENCES CARRERAS(IDCarrera)
go

ALTER TABLE ALUMNOS ADD CONSTRAINT RefGRUPOS5 
    FOREIGN KEY (IDGrupo)
    REFERENCES GRUPOS(IDGrupo)
go

/* 
 * TABLE: CARRERAS 
 */

ALTER TABLE CARRERAS ADD CONSTRAINT RefDIVISIONES7 
    FOREIGN KEY (IDDivision)
    REFERENCES DIVISIONES(IDDivision)
go

/****************************** VISTAS ******************************/

/*VISTA ALUMNOS*/
CREATE VIEW VISTAALUMNOS
AS
SELECT	A.Matricula,
			RTRIM(LTRIM(A.NombreAlumno)) +
			RTRIM(LTRIM(A.ApellidoPaterno)) +
			RTRIM(LTRIM(A.ApellidoPaterno)) AS [NombreCompleto],
		A.Correo, A.Contrasenia, A.Telefono, C.NombreCarrera,
			RTRIM(LTRIM(G.CUATRIMESTRE)) +
			RTRIM(LTRIM(G.Grupo)) AS [GradoGrupo], A.Status
FROM ALUMNOS A
INNER JOIN CARRERAS C ON A.IDCarrera = C.IDCarrera
INNER JOIN GRUPOS G ON A.IDGrupo = G.IDGrupo
go

/*VISTA CARRERAS*/
CREATE VIEW VISTACARRERAS
AS
SELECT C.IDCarrera, C.NombreCarrera, D.NombreDivision, C.Status
FROM CARRERAS C
INNER JOIN DIVISIONES D ON C.IDDivision = D.IDDivision
go

/*VISTA DIVISIONES*/
CREATE VIEW VISTADIVISIONES
AS
SELECT D.IDDivision, D.NombreDivision, D.Status
FROM DIVISIONES D
go

/*VISTA GRUPOS*/
CREATE VIEW VISTAGRUPOS
AS
SELECT G.IDGrupo, G.Cuatrimestre, G.Grupo, G.Status
FROM GRUPOS G
go

/**************************** PROCEDURES ****************************/

/* PROCEDURES ALUMNOS */
CREATE PROCEDURE dbo.AgregarAlumno
(
	@Matricula          varchar(10),
	@NombreAlumno       varchar(50),
	@ApellidoPaterno    varchar(25),
	@ApellidoMaterno    varchar(25),
	@Telefono           varchar(10),
	@Status             bit,
	@IDCarrera          int,
	@IDGrupo            int
)
AS
INSERT INTO ALUMNOS
(
	Matricula,
	NombreAlumno,
	ApellidoPaterno,
	ApellidoMaterno,
	Telefono,
	Status,
	IDCarrera,
	IDGrupo
)
VALUES (@Matricula, @NombreAlumno, @ApellidoPaterno, @ApellidoMaterno, @Telefono, @Status, @IDCarrera, @IDGrupo);

GO

CREATE PROCEDURE dbo.ModificarAlumno
(
	@Matricula          varchar(10),
	@NombreAlumno       varchar(50),
	@ApellidoPaterno    varchar(25),
	@ApellidoMaterno    varchar(25),
	@Telefono           varchar(10),
	@Status             bit,
	@IDCarrera          int,
	@IDGrupo            int
)
AS
UPDATE ALUMNOS
SET
	NombreAlumno = @NombreAlumno,
	ApellidoPaterno = @ApellidoPaterno,
	ApellidoMaterno = @ApellidoMaterno,
	Telefono = @Telefono,
	Status = @Status,
	IDCarrera = @IDCarrera,
	IDGrupo = @IDGrupo
WHERE
	Matricula = @Matricula;

GO

CREATE PROCEDURE dbo.EliminarAlumno
(
	@Matricula          varchar(10)
)
AS
UPDATE ALUMNOS
SET
	Status = 0
WHERE
	Matricula = @Matricula;

GO

/* PROCEDURES CARRERAS */
CREATE PROCEDURE dbo.AgregarCarrera
(
    @NombreCarrera    varchar(70),
    @Status           bit,
    @IDDivision       int
)
AS
INSERT INTO CARRERAS
(
	NombreCarrera,
	Status,
	IDDivision
)
VALUES (@NombreCarrera, @Status, @IDDivision);

GO

CREATE PROCEDURE dbo.ModificarCarrera
(
	@IDCarrera        int,
    @NombreCarrera    varchar(70),
    @Status           bit,
    @IDDivision       int
)
AS
UPDATE CARRERAS
SET
	NombreCarrera = @NombreCarrera,
	Status = @Status,
	IDDivision = @IDDivision
WHERE
	IDCarrera = @IDCarrera;

GO

CREATE PROCEDURE dbo.EliminarCarrera
(
	@IDCarrera        int
)
AS
UPDATE CARRERAS
SET
	Status = 0
WHERE
	IDCarrera = @IDCarrera;

GO

/* PROCEDURES DIVISIONES */
CREATE PROCEDURE dbo.AgregarDivision
(
    @NombreDivision    varchar(70),
    @Status            bit
)
AS
INSERT INTO DIVISIONES
(
	NombreDivision,
	Status
)
VALUES (@NombreDivision, @Status);

GO

CREATE PROCEDURE dbo.ModificarDivision
(
	@IDDivision        int,
    @NombreDivision    varchar(70),
    @Status            bit
)
AS
UPDATE DIVISIONES
SET
	NombreDivision = @NombreDivision,
	Status = @Status
WHERE
	IDDivision = @IDDivision;

GO

CREATE PROCEDURE dbo.EliminarDivision
(
	@IDDivision        int
)
AS
UPDATE DIVISIONES
SET
	Status = 0
WHERE
	IDDivision = @IDDivision;

GO

/* PROCEDURES GRUPOS*/
CREATE PROCEDURE dbo.AgregarGrupo
(
    @Cuatrimestre    char(1),
    @Grupo           char(1),
    @Status          bit
)
AS
INSERT INTO GRUPOS
(
	Cuatrimestre,
	Grupo,
	Status
)
VALUES (@Cuatrimestre, @Grupo, @Status);

GO

CREATE PROCEDURE dbo.ModificarGrupo
(
	@IDGrupo         int,
    @Cuatrimestre    char(1),
    @Grupo           char(1),
    @Status          bit
)
AS
UPDATE GRUPOS
SET
	Cuatrimestre = @Cuatrimestre,
	Grupo = @Grupo,
	Status = @Status
WHERE
	IDGrupo = @IDGrupo;

GO

CREATE PROCEDURE dbo.EliminarGrupo
(
	@IDGrupo         int
)
AS
UPDATE GRUPOS
SET
	Status = 0
WHERE
	IDGrupo = @IDGrupo;