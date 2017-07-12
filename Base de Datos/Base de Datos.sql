/*
 * ER/Studio 8.0 SQL Code Generation
 * Company :      Entara
 * Project :      BDPruebas.DM1
 * Author :       Adrian Cox
 *
 * Date Created : Wednesday, July 12, 2017 13:57:02
 * Target DBMS : Microsoft SQL Server 2008
 */

USE master
go
CREATE DATABASE BDPruebas
go
USE BDPruebas
go

/********************************************************************/
/****************************** TABLAS ******************************/
/********************************************************************/

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
    USUARIO          nvarchar(max)    NOT NULL,
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


/********************************************************************/
/****************************** VISTAS ******************************/
/********************************************************************/

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

/********************************************************************/
/**************************** PROCEDURES ****************************/
/********************************************************************/

/* PROCEDURES ALUMNOS */
CREATE PROCEDURE dbo.AgregarAlumno
(
	@Matricula           varchar(10),
    @NombreAlumno        varchar(50),
    @ApellidoPaterno     varchar(25),
    @ApellidoMaterno     varchar(25),
    @Correo              varchar(75),
    @Contrasenia         varchar(75),
    @Telefono            varchar(10),
    @Status              bit,
    @IDCarrera           int,
    @IDGrupo             int
)
AS
INSERT INTO ALUMNOS
(
	Matricula,
	NombreAlumno,
	ApellidoPaterno,
	ApellidoMaterno,
	Correo,
	Contrasenia,
	Telefono,
	Status,
	IDCarrera,
	IDGrupo
)
VALUES (@Matricula, @NombreAlumno, @ApellidoPaterno, @ApellidoMaterno, @Correo, @Contrasenia, @Telefono, @Status, @IDCarrera, @IDGrupo);

GO

CREATE PROCEDURE dbo.ModificarAlumno
(
	@Matricula           varchar(10),
    @NombreAlumno        varchar(50),
    @ApellidoPaterno     varchar(25),
    @ApellidoMaterno     varchar(25),
    @Correo              varchar(75),
    @Contrasenia         varchar(75),
    @Telefono            varchar(10),
    @Status              bit,
    @IDCarrera           int,
    @IDGrupo             int
)
AS
UPDATE ALUMNOS
SET
	NombreAlumno = @NombreAlumno,
	ApellidoPaterno = @ApellidoPaterno,
	ApellidoMaterno = @ApellidoMaterno,
	Correo = @Correo,
	Contrasenia = @Contrasenia,
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
    @Cuatrimestre     char(1),
    @Grupo            char(1),
    @Status           bit
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
	@IDGrupo          int,
    @Cuatrimestre     char(1),
    @Grupo            char(1),
    @Status           bit
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
GO

/********************************************************************/
/***************************** TRIGGERS *****************************/
/********************************************************************/

/* TRIGGER ALUMNOS */
CREATE TRIGGER TR_ALUMNOS_BITACORA
ON ALUMNOS
FOR INSERT, UPDATE, DELETE
AS
DECLARE
    @COLUMNA INT,
    @COLUMNA_MAX INT,
    @CAMPO VARCHAR(150),
    @TABLA VARCHAR(150),
    @PKCOL VARCHAR(1000),
    @FECHA DATETIME2,
    @ACCION char(1) ,	
    @PKSELECT varchar(1000),
	@USUARIO varchar(10),
	@SQL VARCHAR(2000)

	--REMUEVE EL NÚMERO DE COLUMNAS AFECTADAS
	SET NOCOUNT ON

	--SE ASIGNA EL NOMBRE DE LA TABLA
	SELECT @TABLA = 'ALUMNOS'

	-- Obtenemos la lista de columnas de los cursores
	SELECT * INTO #ins FROM inserted
	SELECT * INTO #del FROM deleted

	--SE LE ASIGNA EL ID DEL USUARIO QUE REALIZÓ EL CAMBIO
	SELECT @USUARIO = SYSTEM_USER;
	
	--SE OBTIENE LA FECHA Y HORA ACTUAL
	SELECT @FECHA = TODATETIMEOFFSET(CONVERT(DATETIME2, GETDATE()), '-06:00')

	--SE OBTIENE EL NOMBRE DE LA COLUMNA QUE CONTIENE LA PK
	SELECT @PKCOL = COALESCE(@PKCOL + ' and', ' on') +
					' I.' + IS_CU.COLUMN_NAME + ' = D.' + IS_CU.COLUMN_NAME
					FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS IS_C
					JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE IS_CU
					ON IS_CU.TABLE_NAME = IS_C.TABLE_NAME
					AND IS_CU.CONSTRAINT_NAME = IS_C.CONSTRAINT_NAME
					WHERE IS_C.TABLE_NAME = @TABLA AND IS_C.CONSTRAINT_TYPE = 'PRIMARY KEY'
	
	--SE OBTIENE LA PK Y LAS COLUMNAS PARA LA INSERCIÓN DE DATOS EN LA TABLA DE BITÁCORA
	SELECT @PKSELECT = 	COALESCE(@PKSELECT + '+', '') + 
						'''<' + 
						COLUMN_NAME + 
						'='' + CONVERT(VARCHAR(100),COALESCE(I.' + 
						COLUMN_NAME +',D.' + 
						COLUMN_NAME + '))+''>''' 
						FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS IS_C
						JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE IS_CU
						ON IS_CU.TABLE_NAME = IS_C.TABLE_NAME
						AND IS_CU.CONSTRAINT_NAME = IS_C.CONSTRAINT_NAME
						WHERE IS_C.TABLE_NAME = @TABLA
						AND CONSTRAINT_TYPE = 'PRIMARY KEY'

	--SE DETERMINA LA ACCIÓN QUE ELUSUARIO ESTÁ REALIZANDO
	if exists (SELECT * FROM inserted) 
		if exists (SELECT * FROM deleted) --SI ES UN UPDATE
			SELECT @ACCION = 'U'
		else                              --SI ES UN INSERT
			SELECT @ACCION = 'I'
	--else                                  --SI ES UN DELETE
	--	SELECT @ACCION = 'D'

	--COMENTARIO
	SELECT @COLUMNA = 0;
	SELECT @COLUMNA_MAX = MAX(ORDINAL_POSITION)
						  FROM INFORMATION_SCHEMA.COLUMNS IS_C
						  WHERE IS_C.TABLE_NAME = @TABLA

	--SE INSERTA 1 REGISTRO POR CADA CAMPO AFECTADO
	WHILE @COLUMNA < @COLUMNA_MAX
	BEGIN
		SELECT @COLUMNA = MIN(ORDINAL_POSITION) 
		FROM INFORMATION_SCHEMA.COLUMNS 
		WHERE TABLE_NAME = @TABLA and ORDINAL_POSITION > @COLUMNA

			BEGIN
				SELECT @CAMPO = COLUMN_NAME 
				FROM INFORMATION_SCHEMA.COLUMNS 
				WHERE TABLE_NAME = @TABLA and ORDINAL_POSITION = @COLUMNA
				
				--SE VALIDA SI ES UN DELETE
				DECLARE @VAL_STATUS BIT
				SELECT @VAL_STATUS = STATUS FROM #ins

				IF (@VAL_STATUS = 0)
					SELECT @ACCION = 'D'

				--SELECT @sql = 'INSERT INTO BITACORA (PK, ACCION, TABLA, CAMPO, VALORORIGINAL, VALORNUEVO, FECHA)'
				SELECT @sql = 'INSERT INTO BITACORA (ACCION, TABLA, PK, CAMPO, VALORORIGINAL, VALORNUEVO, FECHA, USUARIO)'
				SELECT @sql = @sql + 	' SELECT ''' + @ACCION + ''''
				SELECT @sql = @sql + 	',''' + @TABLA + ''''
				SELECT @sql = @sql + 	',' + @PKSELECT
				SELECT @sql = @sql + 	',''' + @CAMPO + ''''
				SELECT @sql = @sql + 	',convert(varchar(1000),D.' + @CAMPO + ')'
				SELECT @sql = @sql + 	',convert(varchar(1000),I.' + @CAMPO + ')'
				SELECT @sql = @sql + 	',''' + CONVERT(VARCHAR, @FECHA) + ''''
				SELECT @sql = @sql + 	',''' + @USUARIO+ ''''
				SELECT @sql = @sql + 	' from #ins I full outer join #del D '
				SELECT @sql = @sql + 	@PKCOL
				SELECT @sql = @sql + 	' where I.' + @CAMPO + ' <> D.' + @CAMPO 
				SELECT @sql = @sql + 	' or (I.' + @CAMPO + ' is null and  D.' + @CAMPO + ' is not null)' 
				SELECT @sql = @sql + 	' or (I.' + @CAMPO + ' is not null and D.' + @CAMPO + ' is null)' 
				exec (@sql)
			END
	END

GO

/* TRIGGER CARRERAS */
CREATE TRIGGER TR_CARRERAS_BITACORA
ON CARRERAS
FOR INSERT, UPDATE, DELETE
AS
DECLARE
    @COLUMNA INT,
    @COLUMNA_MAX INT,
    @CAMPO VARCHAR(150),
    @TABLA VARCHAR(150),
    @PKCOL VARCHAR(1000),
    @FECHA DATETIME2,
    @ACCION char(1) ,	
    @PKSELECT varchar(1000),
	@USUARIO varchar(10),
	@SQL VARCHAR(2000)

	--REMUEVE EL NÚMERO DE COLUMNAS AFECTADAS
	SET NOCOUNT ON

	--SE ASIGNA EL NOMBRE DE LA TABLA
	SELECT @TABLA = 'CARRERAS'

	-- Obtenemos la lista de columnas de los cursores
	SELECT * INTO #ins FROM inserted
	SELECT * INTO #del FROM deleted

	--SE LE ASIGNA EL ID DEL USUARIO QUE REALIZÓ EL CAMBIO
	SELECT @USUARIO = SYSTEM_USER;
	
	--SE OBTIENE LA FECHA Y HORA ACTUAL
	SELECT @FECHA = TODATETIMEOFFSET(CONVERT(DATETIME2, GETDATE()), '-06:00')

	--SE OBTIENE EL NOMBRE DE LA COLUMNA QUE CONTIENE LA PK
	SELECT @PKCOL = COALESCE(@PKCOL + ' and', ' on') +
					' I.' + IS_CU.COLUMN_NAME + ' = D.' + IS_CU.COLUMN_NAME
					FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS IS_C
					JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE IS_CU
					ON IS_CU.TABLE_NAME = IS_C.TABLE_NAME
					AND IS_CU.CONSTRAINT_NAME = IS_C.CONSTRAINT_NAME
					WHERE IS_C.TABLE_NAME = @TABLA AND IS_C.CONSTRAINT_TYPE = 'PRIMARY KEY'
	
	--SE OBTIENE LA PK Y LAS COLUMNAS PARA LA INSERCIÓN DE DATOS EN LA TABLA DE BITÁCORA
	SELECT @PKSELECT = 	COALESCE(@PKSELECT + '+', '') + 
						'''<' + 
						COLUMN_NAME + 
						'='' + CONVERT(VARCHAR(100),COALESCE(I.' + 
						COLUMN_NAME +',D.' + 
						COLUMN_NAME + '))+''>''' 
						FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS IS_C
						JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE IS_CU
						ON IS_CU.TABLE_NAME = IS_C.TABLE_NAME
						AND IS_CU.CONSTRAINT_NAME = IS_C.CONSTRAINT_NAME
						WHERE IS_C.TABLE_NAME = @TABLA
						AND CONSTRAINT_TYPE = 'PRIMARY KEY'

	--SE DETERMINA LA ACCIÓN QUE ELUSUARIO ESTÁ REALIZANDO
	if exists (SELECT * FROM inserted) 
		if exists (SELECT * FROM deleted) --SI ES UN UPDATE
			SELECT @ACCION = 'U'
		else                              --SI ES UN INSERT
			SELECT @ACCION = 'I'
	--else                                  --SI ES UN DELETE
	--	SELECT @ACCION = 'D'

	--COMENTARIO
	SELECT @COLUMNA = 0;
	SELECT @COLUMNA_MAX = MAX(ORDINAL_POSITION)
						  FROM INFORMATION_SCHEMA.COLUMNS IS_C
						  WHERE IS_C.TABLE_NAME = @TABLA

	--SE INSERTA 1 REGISTRO POR CADA CAMPO AFECTADO
	WHILE @COLUMNA < @COLUMNA_MAX
	BEGIN
		SELECT @COLUMNA = MIN(ORDINAL_POSITION) 
		FROM INFORMATION_SCHEMA.COLUMNS 
		WHERE TABLE_NAME = @TABLA and ORDINAL_POSITION > @COLUMNA

			BEGIN
				SELECT @CAMPO = COLUMN_NAME 
				FROM INFORMATION_SCHEMA.COLUMNS 
				WHERE TABLE_NAME = @TABLA and ORDINAL_POSITION = @COLUMNA
				
				--SE VALIDA SI ES UN DELETE
				DECLARE @VAL_STATUS BIT
				SELECT @VAL_STATUS = STATUS FROM #ins

				IF (@VAL_STATUS = 0)
					SELECT @ACCION = 'D'

				--SELECT @sql = 'INSERT INTO BITACORA (PK, ACCION, TABLA, CAMPO, VALORORIGINAL, VALORNUEVO, FECHA)'
				SELECT @sql = 'INSERT INTO BITACORA (ACCION, TABLA, PK, CAMPO, VALORORIGINAL, VALORNUEVO, FECHA, USUARIO)'
				SELECT @sql = @sql + 	' SELECT ''' + @ACCION + ''''
				SELECT @sql = @sql + 	',''' + @TABLA + ''''
				SELECT @sql = @sql + 	',' + @PKSELECT
				SELECT @sql = @sql + 	',''' + @CAMPO + ''''
				SELECT @sql = @sql + 	',convert(varchar(1000),D.' + @CAMPO + ')'
				SELECT @sql = @sql + 	',convert(varchar(1000),I.' + @CAMPO + ')'
				SELECT @sql = @sql + 	',''' + CONVERT(VARCHAR, @FECHA) + ''''
				SELECT @sql = @sql + 	',''' + @USUARIO+ ''''
				SELECT @sql = @sql + 	' from #ins I full outer join #del D '
				SELECT @sql = @sql + 	@PKCOL
				SELECT @sql = @sql + 	' where I.' + @CAMPO + ' <> D.' + @CAMPO 
				SELECT @sql = @sql + 	' or (I.' + @CAMPO + ' is null and  D.' + @CAMPO + ' is not null)' 
				SELECT @sql = @sql + 	' or (I.' + @CAMPO + ' is not null and D.' + @CAMPO + ' is null)' 
				exec (@sql)
			END
	END

GO

/* TRIGGER DIVISIONES */
CREATE TRIGGER TR_DIVISIONES_BITACORA
ON DIVISIONES
FOR INSERT, UPDATE, DELETE
AS
DECLARE
    @COLUMNA INT,
    @COLUMNA_MAX INT,
    @CAMPO VARCHAR(150),
    @TABLA VARCHAR(150),
    @PKCOL VARCHAR(1000),
    @FECHA DATETIME2,
    @ACCION char(1) ,	
    @PKSELECT varchar(1000),
	@USUARIO varchar(10),
	@SQL VARCHAR(2000)

	--REMUEVE EL NÚMERO DE COLUMNAS AFECTADAS
	SET NOCOUNT ON

	--SE ASIGNA EL NOMBRE DE LA TABLA
	SELECT @TABLA = 'DIVISIONES'

	-- Obtenemos la lista de columnas de los cursores
	SELECT * INTO #ins FROM inserted
	SELECT * INTO #del FROM deleted

	--SE LE ASIGNA EL ID DEL USUARIO QUE REALIZÓ EL CAMBIO
	SELECT @USUARIO = SYSTEM_USER;
	
	--SE OBTIENE LA FECHA Y HORA ACTUAL
	SELECT @FECHA = TODATETIMEOFFSET(CONVERT(DATETIME2, GETDATE()), '-06:00')

	--SE OBTIENE EL NOMBRE DE LA COLUMNA QUE CONTIENE LA PK
	SELECT @PKCOL = COALESCE(@PKCOL + ' and', ' on') +
					' I.' + IS_CU.COLUMN_NAME + ' = D.' + IS_CU.COLUMN_NAME
					FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS IS_C
					JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE IS_CU
					ON IS_CU.TABLE_NAME = IS_C.TABLE_NAME
					AND IS_CU.CONSTRAINT_NAME = IS_C.CONSTRAINT_NAME
					WHERE IS_C.TABLE_NAME = @TABLA AND IS_C.CONSTRAINT_TYPE = 'PRIMARY KEY'
	
	--SE OBTIENE LA PK Y LAS COLUMNAS PARA LA INSERCIÓN DE DATOS EN LA TABLA DE BITÁCORA
	SELECT @PKSELECT = 	COALESCE(@PKSELECT + '+', '') + 
						'''<' + 
						COLUMN_NAME + 
						'='' + CONVERT(VARCHAR(100),COALESCE(I.' + 
						COLUMN_NAME +',D.' + 
						COLUMN_NAME + '))+''>''' 
						FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS IS_C
						JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE IS_CU
						ON IS_CU.TABLE_NAME = IS_C.TABLE_NAME
						AND IS_CU.CONSTRAINT_NAME = IS_C.CONSTRAINT_NAME
						WHERE IS_C.TABLE_NAME = @TABLA
						AND CONSTRAINT_TYPE = 'PRIMARY KEY'

	--SE DETERMINA LA ACCIÓN QUE ELUSUARIO ESTÁ REALIZANDO
	if exists (SELECT * FROM inserted) 
		if exists (SELECT * FROM deleted) --SI ES UN UPDATE
			SELECT @ACCION = 'U'
		else                              --SI ES UN INSERT
			SELECT @ACCION = 'I'
	--else                                  --SI ES UN DELETE
	--	SELECT @ACCION = 'D'

	--COMENTARIO
	SELECT @COLUMNA = 0;
	SELECT @COLUMNA_MAX = MAX(ORDINAL_POSITION)
						  FROM INFORMATION_SCHEMA.COLUMNS IS_C
						  WHERE IS_C.TABLE_NAME = @TABLA

	--SE INSERTA 1 REGISTRO POR CADA CAMPO AFECTADO
	WHILE @COLUMNA < @COLUMNA_MAX
	BEGIN
		SELECT @COLUMNA = MIN(ORDINAL_POSITION) 
		FROM INFORMATION_SCHEMA.COLUMNS 
		WHERE TABLE_NAME = @TABLA and ORDINAL_POSITION > @COLUMNA

			BEGIN
				SELECT @CAMPO = COLUMN_NAME 
				FROM INFORMATION_SCHEMA.COLUMNS 
				WHERE TABLE_NAME = @TABLA and ORDINAL_POSITION = @COLUMNA
				
				--SE VALIDA SI ES UN DELETE
				DECLARE @VAL_STATUS BIT
				SELECT @VAL_STATUS = STATUS FROM #ins

				IF (@VAL_STATUS = 0)
					SELECT @ACCION = 'D'

				--SELECT @sql = 'INSERT INTO BITACORA (PK, ACCION, TABLA, CAMPO, VALORORIGINAL, VALORNUEVO, FECHA)'
				SELECT @sql = 'INSERT INTO BITACORA (ACCION, TABLA, PK, CAMPO, VALORORIGINAL, VALORNUEVO, FECHA, USUARIO)'
				SELECT @sql = @sql + 	' SELECT ''' + @ACCION + ''''
				SELECT @sql = @sql + 	',''' + @TABLA + ''''
				SELECT @sql = @sql + 	',' + @PKSELECT
				SELECT @sql = @sql + 	',''' + @CAMPO + ''''
				SELECT @sql = @sql + 	',convert(varchar(1000),D.' + @CAMPO + ')'
				SELECT @sql = @sql + 	',convert(varchar(1000),I.' + @CAMPO + ')'
				SELECT @sql = @sql + 	',''' + CONVERT(VARCHAR, @FECHA) + ''''
				SELECT @sql = @sql + 	',''' + @USUARIO+ ''''
				SELECT @sql = @sql + 	' from #ins I full outer join #del D '
				SELECT @sql = @sql + 	@PKCOL
				SELECT @sql = @sql + 	' where I.' + @CAMPO + ' <> D.' + @CAMPO 
				SELECT @sql = @sql + 	' or (I.' + @CAMPO + ' is null and  D.' + @CAMPO + ' is not null)' 
				SELECT @sql = @sql + 	' or (I.' + @CAMPO + ' is not null and D.' + @CAMPO + ' is null)' 
				exec (@sql)
			END
	END

GO

/* TRIGGER GRUPOS */
CREATE TRIGGER TR_GRUPOS_BITACORA
ON GRUPOS
FOR INSERT, UPDATE, DELETE
AS
DECLARE
    @COLUMNA INT,
    @COLUMNA_MAX INT,
    @CAMPO VARCHAR(150),
    @TABLA VARCHAR(150),
    @PKCOL VARCHAR(1000),
    @FECHA DATETIME2,
    @ACCION char(1) ,	
    @PKSELECT varchar(1000),
	@USUARIO varchar(10),
	@SQL VARCHAR(2000)

	--REMUEVE EL NÚMERO DE COLUMNAS AFECTADAS
	SET NOCOUNT ON

	--SE ASIGNA EL NOMBRE DE LA TABLA
	SELECT @TABLA = 'GRUPOS'

	-- Obtenemos la lista de columnas de los cursores
	SELECT * INTO #ins FROM inserted
	SELECT * INTO #del FROM deleted

	--SE LE ASIGNA EL ID DEL USUARIO QUE REALIZÓ EL CAMBIO
	SELECT @USUARIO = SYSTEM_USER;
	
	--SE OBTIENE LA FECHA Y HORA ACTUAL
	SELECT @FECHA = TODATETIMEOFFSET(CONVERT(DATETIME2, GETDATE()), '-06:00')

	--SE OBTIENE EL NOMBRE DE LA COLUMNA QUE CONTIENE LA PK
	SELECT @PKCOL = COALESCE(@PKCOL + ' and', ' on') +
					' I.' + IS_CU.COLUMN_NAME + ' = D.' + IS_CU.COLUMN_NAME
					FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS IS_C
					JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE IS_CU
					ON IS_CU.TABLE_NAME = IS_C.TABLE_NAME
					AND IS_CU.CONSTRAINT_NAME = IS_C.CONSTRAINT_NAME
					WHERE IS_C.TABLE_NAME = @TABLA AND IS_C.CONSTRAINT_TYPE = 'PRIMARY KEY'
	
	--SE OBTIENE LA PK Y LAS COLUMNAS PARA LA INSERCIÓN DE DATOS EN LA TABLA DE BITÁCORA
	SELECT @PKSELECT = 	COALESCE(@PKSELECT + '+', '') + 
						'''<' + 
						COLUMN_NAME + 
						'='' + CONVERT(VARCHAR(100),COALESCE(I.' + 
						COLUMN_NAME +',D.' + 
						COLUMN_NAME + '))+''>''' 
						FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS IS_C
						JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE IS_CU
						ON IS_CU.TABLE_NAME = IS_C.TABLE_NAME
						AND IS_CU.CONSTRAINT_NAME = IS_C.CONSTRAINT_NAME
						WHERE IS_C.TABLE_NAME = @TABLA
						AND CONSTRAINT_TYPE = 'PRIMARY KEY'

	--SE DETERMINA LA ACCIÓN QUE ELUSUARIO ESTÁ REALIZANDO
	if exists (SELECT * FROM inserted) 
		if exists (SELECT * FROM deleted) --SI ES UN UPDATE
			SELECT @ACCION = 'U'
		else                              --SI ES UN INSERT
			SELECT @ACCION = 'I'
	--else                                  --SI ES UN DELETE
	--	SELECT @ACCION = 'D'

	--COMENTARIO
	SELECT @COLUMNA = 0;
	SELECT @COLUMNA_MAX = MAX(ORDINAL_POSITION)
						  FROM INFORMATION_SCHEMA.COLUMNS IS_C
						  WHERE IS_C.TABLE_NAME = @TABLA

	--SE INSERTA 1 REGISTRO POR CADA CAMPO AFECTADO
	WHILE @COLUMNA < @COLUMNA_MAX
	BEGIN
		SELECT @COLUMNA = MIN(ORDINAL_POSITION) 
		FROM INFORMATION_SCHEMA.COLUMNS 
		WHERE TABLE_NAME = @TABLA and ORDINAL_POSITION > @COLUMNA

			BEGIN
				SELECT @CAMPO = COLUMN_NAME 
				FROM INFORMATION_SCHEMA.COLUMNS 
				WHERE TABLE_NAME = @TABLA and ORDINAL_POSITION = @COLUMNA
				
				--SE VALIDA SI ES UN DELETE
				DECLARE @VAL_STATUS BIT
				SELECT @VAL_STATUS = STATUS FROM #ins

				IF (@VAL_STATUS = 0)
					SELECT @ACCION = 'D'

				--SELECT @sql = 'INSERT INTO BITACORA (PK, ACCION, TABLA, CAMPO, VALORORIGINAL, VALORNUEVO, FECHA)'
				SELECT @sql = 'INSERT INTO BITACORA (ACCION, TABLA, PK, CAMPO, VALORORIGINAL, VALORNUEVO, FECHA, USUARIO)'
				SELECT @sql = @sql + 	' SELECT ''' + @ACCION + ''''
				SELECT @sql = @sql + 	',''' + @TABLA + ''''
				SELECT @sql = @sql + 	',' + @PKSELECT
				SELECT @sql = @sql + 	',''' + @CAMPO + ''''
				SELECT @sql = @sql + 	',convert(varchar(1000),D.' + @CAMPO + ')'
				SELECT @sql = @sql + 	',convert(varchar(1000),I.' + @CAMPO + ')'
				SELECT @sql = @sql + 	',''' + CONVERT(VARCHAR, @FECHA) + ''''
				SELECT @sql = @sql + 	',''' + @USUARIO+ ''''
				SELECT @sql = @sql + 	' from #ins I full outer join #del D '
				SELECT @sql = @sql + 	@PKCOL
				SELECT @sql = @sql + 	' where I.' + @CAMPO + ' <> D.' + @CAMPO 
				SELECT @sql = @sql + 	' or (I.' + @CAMPO + ' is null and  D.' + @CAMPO + ' is not null)' 
				SELECT @sql = @sql + 	' or (I.' + @CAMPO + ' is not null and D.' + @CAMPO + ' is null)' 
				exec (@sql)
			END
	END

GO