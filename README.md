# tl2-tp1-2024-SanBarrio

## Punto 2:

### ¿Cual de estas relaciones considera que se realiza por composición y cual por agregación? 

*La relación **Pedidos-Cliente** es de **composición**, dado que si no existe Cliente, no existiría el pedido.* 

*La relación **Cadetes-Cadetería** es de **composición**, pues si la cadeteria no existe entonces el cadete no pertenece a ningun lugar.*

*La relación **Pedidos-Cadetes** es de **agregación**, ya que para un pedido existen muchos cadetes y el cadete puede existir sin necesidad de tener ningún pedido.* 

### ¿Qué métodos considera que debería tener la clase Cadetería y la Clase Cadete?

*La clase Cadetetería debe ser un método constructor, dado que debe crear el servicio de cadetes* 
*La clase Cadete debe ser un método constructor, ya que debe generar los datos del Cadete para ser agregado a la Cadetería.*

### Teniendo en cuenta los principios de abstracción y ocultamiento, que atributos, propiedades y métodos deberían ser públicos y cuales privados

*De la **Clase Cadetería:*** 

>Público/s: Nombre, Telefono.  
>Privado/s: ListadoCadetes. 

*De la **Clase Cadete:***

>Público/s: Nombre, Telefono, Direccion.  
>Privado/s: Id, ListadoPedidos, JornalACobrar().  

**De la Clase Pedidos:** 

>Público/s: Nro, Obs, Estado, VerDireccionCliente(), VerDatosCliente().  
>Privado/s: Cliente.  

**De la Clase Cliente:** 

>Público/s: Nombre, Telefono, Direccion, DatosReferenciaDireccion.  
>Privado/s:  