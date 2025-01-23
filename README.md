# Proyecto: API REST para la Gestión de Libros

Este proyecto es una API REST que implementa un sistema de gestión de libros. Está desarrollada en **.NET 8** y utiliza **Entity Framework Core** para la persistencia de datos y **CQRS** (Command Query Responsibility Segregation) con la librería **MediatR** para manejar las operaciones de comandos y consultas.

---

## **Características del Proyecto**

- **CQRS**:
  - Separación de responsabilidades entre operaciones de escritura (comandos) y operaciones de lectura (consultas).
  - Uso de **MediatR** para implementar el manejo de comandos y consultas.

- **Entity Framework Core**:
  - Gestión de las entidades y acceso a la base de datos.
  - Base de datos SQL Server como backend de almacenamiento.

- **.NET 8**:
  - Implementado en la última versión de .NET para aprovechar sus mejoras y características modernas.

- **Swagger**:
  - Documentación interactiva para probar las rutas de la API.

---

## **Requisitos Previos**

Antes de instalar y ejecutar el proyecto, asegúrate de tener instalados los siguientes componentes:

1. **.NET 8 SDK**  
   Puedes descargarlo desde la [página oficial de .NET](https://dotnet.microsoft.com/download/dotnet/8.0).

2. **SQL Server**  
   Asegúrate de tener acceso a un servidor SQL para la base de datos.

3. **Visual Studio 2022** o **Visual Studio Code**  
   Cualquier IDE que soporte .NET 8.

4. **Postman** (opcional)  
   Para probar los endpoints de la API.
