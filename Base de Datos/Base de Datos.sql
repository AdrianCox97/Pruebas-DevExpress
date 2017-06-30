/*
 * ER/Studio 8.0 SQL Code Generation
 * Company :      Entara
 * Project :      BDPruebas.DM1
 * Author :       Adrian Cox
 *
 * Date Created : Friday, June 30, 2017 14:04:26
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
    Matricula          int            IDENTITY(1,1),
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


