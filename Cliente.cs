class Cliente
{
    private string? nombre;
    private string? direccion;
    private string? telefono;
    private string? datosReferenciaDireccion;


    public Cliente(string nomb, string dir, string tel, string dat)
    {
        nombre = nomb;
        direccion = dir;
        telefono = tel;
        datosReferenciaDireccion = dat;
    }
    public string Nombre { get => nombre; }
    public string Direccion { get => direccion; }
    public string Telefono { get => telefono; }
    public string DatosReferenciaDireccion { get => datosReferenciaDireccion; }
}