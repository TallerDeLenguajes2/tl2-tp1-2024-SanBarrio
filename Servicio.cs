public class Cadete{
    private int id;
    private string nombre;
    private string direccion;
   private string telefono;
    List<Pedidos> listadoPedidos;



}

public class Cadeteria{
    private string nombre;
    private string telefono;
    List<Cadete> ListadoCadetes;

}
public class Cliente{
    private string nombre;
    private string direccion;
    private string telefono;
    private string datosReferenciaDireccion;

}
public class Pedidos{
    private int nro;
    private string obs;
    string cliente;
    private int estado;
    public void VerDireccionCliente(){

    }
    public void VerDatosCliente(){

    }

}