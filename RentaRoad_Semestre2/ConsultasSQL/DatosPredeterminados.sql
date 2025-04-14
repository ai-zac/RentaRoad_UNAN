/*
 * Poblar la base de datos 
 * con datos por defecto
 */

 USE RentaRoad_DB
 GO

/* TIPOS DE USUARIOS */
INSERT INTO Tipo_Usuario (tipo, Fecha_Creacion, Fecha_Modificacion, estado) VALUES ('Admin', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'habilitado')
GO
INSERT INTO Tipo_Usuario (tipo, Fecha_Creacion, Fecha_Modificacion, estado) VALUES ('Usuario', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'habilitado')
GO


/* CARGOS DE EMPLEADOS */
INSERT INTO Cargo_Empleado (cargo, Fecha_Creacion, Fecha_Modificacion, estado) VALUES ('Gerente', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'habilitado')
GO
INSERT INTO Cargo_Empleado (cargo, Fecha_Creacion, Fecha_Modificacion, estado) VALUES ('Cajero', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'habilitado')
GO


/* USUARIOS */
INSERT INTO Usuario (Fk_Cargo_empleado, Fk_Tipo_usuario, nombre_usuario, Telefono_Usuario, Cedula_Usuario, contraseña, correo, Fecha_Creacion, Fecha_Modificacion, estado) VALUES
(1,1,'Isaac', 66666666,'10000D', 123, 'isa@gma.co', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'Habilitado')
Go	


/* PROVEEDORES */
INSERT INTO Proveedor (nombre_Proveedor, telefono_Proveedor, correo_Proveedor, fecha_creacion, Fecha_Modificacion, estado)
VALUES ('Fulano', 111111, 'fu@la.co', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'Habilitado')
GO
INSERT INTO Proveedor (nombre_Proveedor, telefono_Proveedor, correo_Proveedor, fecha_creacion, Fecha_Modificacion, estado)
VALUES ('Maria', 222222, 'ma@la.co', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'Habilitado')
GO
INSERT INTO Proveedor (nombre_Proveedor, telefono_Proveedor, correo_Proveedor, fecha_creacion, Fecha_Modificacion, estado)
VALUES ('Juan', 111111, 'ju@la.co', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'Habilitado')
GO


/* MARCAS */
INSERT INTO Marca (marca, Fecha_Creacion, Fecha_Modificacion, Estado) VALUES ('Toyota', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'Habilitado')
GO
INSERT INTO Marca (marca, Fecha_Creacion, Fecha_Modificacion, Estado) VALUES ('Susuki', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'Habilitado')
GO
INSERT INTO Marca (marca, Fecha_Creacion, Fecha_Modificacion, Estado) VALUES ('Nissan', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'Habilitado')
GO
INSERT INTO Marca (marca, Fecha_Creacion, Fecha_Modificacion, Estado) VALUES ('Subaru', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'Habilitado')
GO
INSERT INTO Marca (marca, Fecha_Creacion, Fecha_Modificacion, Estado) VALUES ('Mitsubishu', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'Habilitado')
GO
INSERT INTO Marca (marca, Fecha_Creacion, Fecha_Modificacion, Estado) VALUES ('BMW', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'Habilitado')
GO


/* MODELOS */
INSERT INTO Modelo (modelo, Fecha_Creacion, Fecha_Modificacion, Estado) VALUES ('Yaris', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'Habilitado')
GO
INSERT INTO Modelo (modelo, Fecha_Creacion, Fecha_Modificacion, Estado) VALUES ('ZZ10', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'Habilitado')
GO
INSERT INTO Modelo (modelo, Fecha_Creacion, Fecha_Modificacion, Estado) VALUES ('Cover', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'Habilitado')
GO
INSERT INTO Modelo (modelo, Fecha_Creacion, Fecha_Modificacion, Estado) VALUES ('Blue Demon', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'Habilitado')
GO
INSERT INTO Modelo (modelo, Fecha_Creacion, Fecha_Modificacion, Estado) VALUES ('Lancer EVO', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'Habilitado')
GO
INSERT INTO Modelo (modelo, Fecha_Creacion, Fecha_Modificacion, Estado) VALUES ('M3', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'Habilitado')
GO


/* COLORES */
INSERT INTO Color (Color, Fecha_Creacion, Fecha_Modificado) VALUES ('Rojo', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5))
GO
INSERT INTO Color (Color, Fecha_Creacion, Fecha_Modificado) VALUES ('Azul', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5))
GO
INSERT INTO Color (Color, Fecha_Creacion, Fecha_Modificado) VALUES ('Verde', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5))
GO
INSERT INTO Color (Color, Fecha_Creacion, Fecha_Modificado) VALUES ('Negro', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5))
GO
INSERT INTO Color (Color, Fecha_Creacion, Fecha_Modificado) VALUES ('Blanco', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5))
GO
INSERT INTO Color (Color, Fecha_Creacion, Fecha_Modificado) VALUES ('Gris', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5))
GO


/* ADQUISICIONES */
INSERT INTO Adquisicion (Fk_Proveedor, fecha_adquisicion, precio_total, fecha_creacion, Fecha_Modificacion)
VALUES (1, convert(datetime,'18-06-12 10:34:09 PM',5), 18000.99, convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5))
GO
INSERT INTO Adquisicion (Fk_Proveedor, fecha_adquisicion, precio_total, fecha_creacion, Fecha_Modificacion)
VALUES (2, convert(datetime,'18-06-12 10:34:09 PM',5), 2000.89, convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5))
GO
INSERT INTO Adquisicion (Fk_Proveedor, fecha_adquisicion, precio_total, fecha_creacion, Fecha_Modificacion)
VALUES (3, convert(datetime,'18-06-12 10:34:09 PM',5), 70233.99, convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5))
GO


/* DETALLES DE ADQUISICIONES */
INSERT INTO Detalle_Adquisicion (Fk_Color, Fk_Marca, Fk_Modelo, Precio_Unidad_Auto, Precio_Grupal_Auto, Cantidad_Auto)
VALUES (1, 1, 1, 500.00, 500.00, 1)
GO


/* AUTOS */
INSERT INTO Auto (Fk_Detalle_Adquisicion, Fk_Color, Fk_Marca, Fk_Modelo, placa, año_salida, numero_asientos, estado_auto, costo_renta, disponibilidad, fecha_creacion, Fecha_Modficacion, verificacion_pendiente, Estado)
VALUES (1, 9, 1, 1, 'ABC', 2017, 2, 'Bueno', 500.00, 'Disponible', convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'18-06-12 10:34:09 PM',5), 'Ya verificado', 'Habilitado')
GO