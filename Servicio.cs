public class Cadete
{
    private int id;
    private string nombre;
    private string direccion;
    private string telefono;
    List<Pedidos> listadoPedidos;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public List<Pedidos> ListadoPedidos { get => ListadoPedidos; set => ListadoPedidos = value; }

}

public class Cadeteria
{
    private string nombre;
    private string telefono;
    List<Cadete> listadoCadetes;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public List<Cadete> ListadoCadetes { get => ListadoCadetes; set => ListadoCadetes = value; }

}
public class Cliente
{
    private string nombre;
    private string direccion;
    private string telefono;
    private string datosReferenciaDireccion;

}
public class Pedidos
{
    public enum Estados
    {
        Preparacion,
        EnViaje,
        Entregado
    }
    private int nro;
    private string obs;
    private string cliente;
    private Estados estado;
    public void VerDireccionCliente()
    {

    }
    public void VerDatosCliente()
    {

    }

    public int Nro { get => nro; set => nro = value; }
    public string Obs { get => Obs; set => Obs = value; }
    public Estados Estado{ get => estado; set => estado = value; }
    public string Cliente { get => cliente; set => cliente = value; }

}