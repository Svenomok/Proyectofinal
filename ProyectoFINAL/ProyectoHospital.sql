create database ProyectoHospital;

CREATE TABLE tbl_Citas
(
CodigoCita INT PRIMARY key identity (1,1) not null, 
CodigoPasciente INT, 
CodigoEmpleado INT, 
FechaIngreso DATETIME, 
FechaEgreso DATETIME, 
CostoTratamientos DECIMAL(10,2), 
Observacoines VARCHAR(100), 
UsuarioAuditoria VARCHAR(100),
FechaAuditoria DATETIME 
);


CREATE TABLE tbl_PagoCita(
PagoCita INT PRIMARY KEY,
CodigoCita INT, 
MontoCita DECIMAL(10,2),
Impuesto DECIMAL(10,2), 
Descuento DECIMAL(10,2),
TotalPago DECIMAL(10,2),
FechaPago DATETIME, 
TipoPago VARCHAR(50), 
UsuarioAuditoria VARCHAR(100), 
FechaAuditoria  DATETIME, 
FOREIGN KEY (CodigoCita) REFERENCES	tbl_Citas(CodigoCita)
);

CREATE TABLE tbl_Medicamentos(
CodigoMedicamento INT PRIMARY KEY identity (1,1) not null, 
Nombre VARCHAR(100), 
TipoMedicamento VARCHAR(100),
Precio DECIMAL(10,2), 
stock INT, 
FechaVencimiento DATETIME, 
Estado VARCHAR(10),
UsuarioAuditoria VARCHAR(100),
FechaAuditoria DATETIME

);


CREATE TABLE tbl_Tratamientos(
CodigoTratamiento INT PRIMARY KEY identity (1,1) not null, 
CodigoCita INT, 
CodigoMedicamento INT, 
Costo DECIMAL(10,2), 
FechaTratamiento DATETIME, 
Estado VARCHAR(20),
UsuarioAuditoria VARCHAR(100),
FechaAuditoria DATETIME, 
FOREIGN KEY(CodigoCita) REFERENCES tbl_Citas(CodigoCita),
FOREIGN KEY(CodigoMedicamento) REFERENCES tbl_Medicamentos(CodigoMedicamento)	
);
create table tbl_Habitaciones 
( 
CodigoHabitacion int primary key identity (1,1) not null,
Numero varchar(10)not null,
Ubicacion varchar(100) not null,
TipoHabitacion varchar(50)not null,
Costo Decimal (10,2) not null,
Estado varchar(20),
UsuarioAuditoria varchar(100)not null,
FechaAuditoria datetime not null
);

create table tbl_Paciente 
(
CodigoPaciente Int primary Key identity (1,1) not null,
CodigoHabitacion int not null,
Nombres varchar (100) not null,
NIT varchar(50)not null,
FechaNacimiento datetime not null,
TipoPaciente varchar(50)not null,
Estado varchar(20),
UsuarioAuditoria varchar(100)not null,
FechaAuditoria datetime not null,
FOREIGN KEY (CodigoHabitacion) REFERENCES tbl_Habitaciones (CodigoHabitacion)
);


create table tbl_Empleados
(
    CodigoEmpleado int primary key identity (1,1) NOT NULL,
	Nombres varchar(100),
	TipoTrabajo varchar(100),
	Especialidad varchar(100),
	Sueldo decimal(10,2),
	FechaAlta Datetime,
	Estado varchar(20),
	UsuarioAuditoria varchar(100),
	FechaAuditoria Datetime,
);
create table tbl_GestionHabitaciones
(
CodigoGestion int Primary key identity (1,1) not null,
CodigoEmpleado int not null,
CodigoHabitacion int not null,
Tipogestion varchar(50)not null,
FechaGestion datetime not null,
Estado varchar(20),
UsuarioAuditoria varchar(100)not null,
FechaAuditoria datetime not null,
FOREIGN KEY (CodigoEmpleado) REFERENCES tbl_Empleados(CodigoEmpleado),
FOREIGN KEY (CodigoHabitacion) REFERENCES tbl_Habitaciones (CodigoHabitacion)
);
create table tbl_usuarios 
(
    CodigoUsuario int primary key identity (1,1) not null,
    CodigoEmpleado int,
    Usuario varchar(50),
    Clave varchar(256),
    TipoUsuario varchar(20),
    Estado varchar(20),
    UsuarioAuditoria varchar(100),
    FechaAuditoria DATETIME,
    Foreign key (CodigoEmpleado) References tbl_Empleados(CodigoEmpleado)
);


create table tbl_PagoEmpleados
(
    CodigoPago int primary key identity (1,1) not null,
	CodigoEmpleado int,
	FechaPago Datetime,
	Sueldo Decimal(10,2),
	Bono Decimal(10,2),
	MontoHorasE decimal(10,2),
	TotalMonto decimal(10,2),
	Estado varchar(20),
	UsuarioAuditoria varchar(100),
	FechaAuditoria datetime,
	Foreign key (codigoEmpleado) References tbl_Empleados(CodigoEmpleado)
);