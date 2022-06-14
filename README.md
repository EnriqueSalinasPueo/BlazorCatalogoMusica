# BlazorCatalogoMusica

## Proyecto Blazor.Server con entityFramework.

Al utilizar entityFramework se pude simplificar la arquitectura del proyecto

## Agragar paquete nuget al proyecto 

Agregaremos hata cuatro paquetes nuget al proyecto BlazorCatalogoMusica.Data

Haremos click derecho sobre el proyecto y administrar paquetes NuGet

Buscamos y añadimos :

	- Microsoft.EntityFrameworkCore
	- Microsoft.EntityFrameworkCore.SqlServer
	- Microsoft.EntityFrameworkCore.Tools
	- Microsoft.EntityFrameworkCore.Design

Hay que tener en cuenta de instalar los paquetes con la misma versión, en mi caso 5.0.17 ya que estoy usando la version .NET 5.0

## Migracion y creacion bade de datos 

Una vez tenemos definido el DbContext podemos ejecutar los siguientes comandos en la consola de administrador de paquetes:

	- Add-Migration NombreQueQueramos --> esto genera un archivo de migración con una referencia y el nombre que hayamos puesto dentro de un carpeta Migrations. 
					Basicamente escribe en código c# lo que se va a ejecutar al actualizar la base de datos.

	- Update-Database --> Actuliza la base de datos en base al ultimo archivo de migracion generado anteriormente.

Con estos pasos desde nuestra clases de la app entityFramework genera la estructura de base de datos que necesitamos para funcionar.

