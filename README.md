# VentasNEXUS
VENTAS VIDEOGAMES 
*Esta pagina web de ASP.NET trata acerca de el  **Registro de Ventas** de videojuegos.

<h1 align="center"> NEXUS CODE</h1>

<p align="center"><img src="https://github.com/Marselo203/VentasNEXUS/raw/master/READ/Captura%20de%20pantalla%20(641).png"/></p> 

## Tabla de contenidos:
---
- [Integrantes](#integrantes)
- [Descripcion](#descripcion)
- [Diagrama de Base de Datos](#diagrama-de-base-de-datos)
- [Diagrama de Clases](#diagrama-de-clases)
- [Imagenes de Funcionamiento](#imagenes-de-funcionamiento)
  
### Integrantes:
- Angola Larico Israel Cristhian
- Conde Quispe Yoselin Maciel
- Coria Torres Esteban Ismael
- Vargas Yujra Brayan Marcelo

#### Descripcion
--
Este proyecto de ASP.NET es una página web dedicada a la venta de videojuegos, que ofrece funcionalidades clave para administrar usuarios, productos y registros de ventas. 
Permite a los usuarios crear cuentas, agregar nuevos productos al catálogo y mantener un registro de las ventas realizadas


### Diagrama de Base de Datos
    +------------------+    +------------------+    +------------------+
    |      Usuarios    |    |     Productos    |    |       Ventas     |
    +------------------+    +------------------+    +------------------+
    |   - ID (PK)      |    |   - ID (PK)      |    |   - ID (PK)      |
    |   - Nombre       |    |   - Nombre       |    |   - ID_Producto  |
    |   - Apellido     |    |   - Descripción  |    |   - ID_Usuario   |
    |   - NIT          |    |   - Precio       |    |   - Fecha        |
    |                  |    |   -Stock         |    |                  |
    +------------------+    +------------------+    +------------------+
### Diagrama de Clases
Clase: Usuario
- ID
- Nombre
- Correo
- Contraseña

Clase: Venta
- ID
- Fecha
- ID_Usuario

Clase: Producto
- ID
- Nombre
- Descripción
- Precio
-Stock

Relaciones:
- Usuario (1) ---- (n) Venta
- Venta (1) ---- (n) Producto



### IMAGENES DE FUNCIONAMIENTO: 

## USUARIOS

![Captura de Pantalla](https://github.com/Marselo203/VentasNEXUS/raw/master/READ/Captura%20de%20pantalla%20(642).png)

## CREAR UN NUEVO USUARIO

![Captura de Pantalla](https://github.com/Marselo203/VentasNEXUS/raw/master/READ/Captura%20de%20pantalla%20(643).png)

## DETALLES DEL REGISTRO

![Captura de Pantalla](https://github.com/Marselo203/VentasNEXUS/raw/master/READ/Captura%20de%20pantalla%20(644).png)

## ELIMINACION DEL USUARIO

![Captura de Pantalla](https://github.com/Marselo203/VentasNEXUS/raw/master/READ/Captura%20de%20pantalla%20(645).png)

## PRODUCTOS

![Captura de Pantalla](https://github.com/Marselo203/VentasNEXUS/raw/master/READ/Captura%20de%20pantalla%20(646).png)

## CREACION DE PRODUCTO

![Captura de Pantalla](https://github.com/Marselo203/VentasNEXUS/raw/master/READ/Captura%20de%20pantalla%20(647).png)

## DETALLES DEL PRODUCTO

![Captura de Pantalla](https://github.com/Marselo203/VentasNEXUS/raw/master/READ/Captura%20de%20pantalla%20(650).png)

## REGISTRO DE VENTAS

![Captura de Pantalla](https://github.com/Marselo203/VentasNEXUS/raw/master/READ/Captura%20de%20pantalla%20(649).png)


