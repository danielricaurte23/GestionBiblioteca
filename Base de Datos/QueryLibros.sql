USE BibliotecaUsers;
CREATE TABLE Libros (
    ISBN NVARCHAR(20) PRIMARY KEY,
    Titulo NVARCHAR(255) NOT NULL,
    Autor NVARCHAR(255) NOT NULL,
    Genero NVARCHAR(100),
    Descripcion NVARCHAR(MAX),
    Publicacion DATE,
    Editor NVARCHAR(255),
    Paginas INT,
    Disponibilidad BIT
);

CREATE TABLE DestinatarioMensaje (
    ID INT PRIMARY KEY IDENTITY,
    Destinatario VARCHAR(100),
    Mensaje VARCHAR(100),
    Fecha DATETIME
);

CREATE TABLE SolicitudesLibros (
    Titulo VARCHAR(100) PRIMARY KEY,
    FechaInicio DATE,
    FechaFin DATE,
    Precio DECIMAL(10,2),
	CorreoUsuario VARCHAR(100),
	FOREIGN KEY (CorreoUsuario) REFERENCES Usuarios(Correo)
);

SELECT * FROM SolicitudesLibros;