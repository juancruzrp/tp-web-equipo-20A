


select * from Clientes


create procedure storedAltaCliente
@Documento varchar(50), 
@Nombre varchar(50), 
@Apellido varchar(50), 
@Email varchar(50), 
@Direccion varchar(50), 
@Ciudad varchar(50), 
@CodigoPostal int
as
insert into Clientes values (@Documento,@Nombre,@Apellido,@Email,@Direccion,@Ciudad,@CodigoPostal)

storedAltaCliente 2, '','','','','',2222
