/*
 * ER/Studio 8.0 SQL Code Generation
 * Company :      Entara
 * Project :      BDPruebas.DM1
 * Author :       Adrian Cox
 *
 * Date Created : Friday, June 30, 2017 14:43:49
 * Target DBMS : Microsoft SQL Server 2008
 */

USE master
go
CREATE DATABASE BDPruebas
go
USE BDPruebas
go
/* 
 * TABLE: ALUMNOS 
 */

CREATE TABLE ALUMNOS(
    Matricula          varchar(10)    NOT NULL,
    NombreAlumno       varchar(50)    NOT NULL,
    ApellidoPaterno    varchar(25)    NOT NULL,
    ApellidoMaterno    varchar(25)    NOT NULL,
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
    Cuatrimestre    char(2)    NOT NULL,
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

/*************************************************************************************
VISTAS	VISTAS	VISTAS	VISTAS	VISTAS	VISTAS	VISTAS	VISTAS	VISTAS	VISTAS	VISTAS
*************************************************************************************/

CREATE VIEW VistaDivisiones
AS
SELECT * FROM DIVISIONES D;

GO

CREATE VIEW VistaGrupos
AS
SELECT * FROM GRUPOS;

GO

CREATE VIEW VistaCarreras
AS
SELECT C.IDCarrera, C.NombreCarrera, D.NombreDivision
FROM CARRERAS C
INNER JOIN DIVISIONES D ON C.IDDivision = D.IDDivision;

GO

CREATE VIEW VistaAlumnos
AS
SELECT A.Matricula, CONCAT(LTRIM(RTRIM(A.NombreAlumno)), ' ',
						   LTRIM(RTRIM(A.ApellidoPaterno)), ' ',
						   LTRIM(RTRIM(A.ApellidoMaterno))) AS 'NombreCompleto',
	   A.Telefono, c.NombreCarrera, CONCAT(LTRIM(RTRIM(G.Cuatrimestre)),
										   LTRIM(RTRIM(G.Grupo))) AS 'GradoGrupo'
FROM ALUMNOS A
INNER JOIN CARRERAS C ON A.IDCarrera = C.IDCarrera
INNER JOIN GRUPOS G ON A.IDGrupo = G.IDGrupo

GO

/*************************************************************************************
PROCEDURES	PROCEDURES	PROCEDURES	PROCEDURES	PROCEDURES	PROCEDURES	PROCEDURES
*************************************************************************************/

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