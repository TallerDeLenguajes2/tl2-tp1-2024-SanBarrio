class Pedido {
    private int numero;
    private string observacion;
    private Cliente cliente;
    private Estado estado;
    

    public int Numero { get => numero; }
    public string Observacion { get => observacion; }
    public Cliente Cliente { get => cliente; }
    public Estado Estado { get => estado; set => estado = value; }

    public string VerDireccionCliente() {
        return Cliente.Direccion;
    }
    public string VerDatosCliente() {
        return Cliente.DatosReferenciaDireccion;
    }
}

public enum Estado {
    Entregado,
    Pendiente
}