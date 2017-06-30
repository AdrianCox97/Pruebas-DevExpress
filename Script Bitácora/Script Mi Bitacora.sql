CREATE DATABASE MIBITACORA;

GO

USE MIBITACORA;

GO

CREATE TABLE BITACORA
(
	ACCION CHAR(1),
	FECHA DATE,
	USUARIO VARCHAR(1500)
);

GO

CREATE TRIGGER TR_BITACORA
ON CLIENTE
FOR INSERT, UPDATE, DELETE
AS
DECLARE
	@ACCION CHAR (1),
	@FECHA DATE,
	@USUARIO VARCHAR (1500)
if exists (SELECT * FROM inserted) 
  if exists (SELECT * FROM deleted) --Si es un update
    SET @ACCION = 'U'
  else                              --Si es un insert
    SET @ACCION = 'I'
else                                --si es un delete
    SET @ACCION = 'D'

	BEGIN
	INSERT INTO BITACORA (ACCION) VALUES (@ACCION)
	END

INSERT INTO Cliente (Nombres, Apellidos, NumeroDocumento, TipoDocumento) VALUES ('JESUS', 'TORRES', 6818, 'DNI');
UPDATE CLIENTE SET Nombres = 'MARIA', Apellidos = 'ESTEFANIA' WHERE IdCliente = 6;
DELETE FROM CLIENTE WHERE IdCliente = 5;
SELECT * FROM Cliente;
TRUNCATE TABLE CLIENTE;
SELECT * FROM BITACORA;