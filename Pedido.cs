class Pedido
{
    private int numero;
    private string observacion;
    private Cliente cliente;
    private Estado estado;

     public Pedido(string nom, string dir, string tel, string datosRef, string obs)
    {
        
        this.observacion = obs;
        cliente = new Cliente()
        {
            Nombre = nom,
            Direccion = dir,
            Telefono = tel,
            DatosReferenciaDireccion = datosRef
        };
        estado = Estado.Pendiente;

    }






    public string VerDatosCliente()
    {
        return $"Nombre: {cliente.Nombre} | Direccion: {cliente.Direccion} | Telefono: {cliente.Telefono} | Referencia: {cliente.DatosReferenciaDireccion}";
    }
    public string VerDireccionCliente()
    {
        return cliente.DatosReferenciaDireccion;
    }
}

public enum Estado
{
    Entregado,
    Pendiente
}