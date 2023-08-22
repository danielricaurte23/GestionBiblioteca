USE BibliotecaUsers;

CREATE TABLE Usuarios (
    Correo VARCHAR(100) PRIMARY KEY,
    Nombres VARCHAR(50),
    Apellidos VARCHAR(50),
    Contrasena VARCHAR(100),
    Direccion VARCHAR(100),
    Telefono INT
);


CREATE TABLE Admins (
    NumeroAdmin INT PRIMARY KEY,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    Correo VARCHAR(100) UNIQUE,
    Contrasena VARCHAR(100)
);

INSERT INTO Admins(NumeroAdmin, Nombre, Apellido, Correo, Contrasena) 
	   Values(1, 'Luis Daniel' , 'Ricaurte' , 'danielricaurte875@gmail.com', '12345');

