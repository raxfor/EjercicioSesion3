Cliente miCliente = new Cliente("Jhon Alexander Herrera", 7852554, "cra 19 # 56-06 colombia", "jhonalex@example.com", false);
Console.WriteLine("Datos Cliente");
Console.WriteLine("nombre: " + miCliente._nombreCompleto);
Console.WriteLine("Telefono: " + miCliente._telefono);
Console.WriteLine("Direccion: " + miCliente._direccion);
Console.WriteLine("Email: " + miCliente._email);
Console.WriteLine("Cliente Nuevo: " + miCliente._esNuevoCliente);

public struct Cliente
{
  public Cliente(String nombreCompleto, int telefono, String direccion, String email, Boolean esNuevoCliente)
  {
    _nombreCompleto = nombreCompleto;
    _telefono = telefono;
    _direccion = direccion;
    _email = email;
    _esNuevoCliente = esNuevoCliente;
  }

  public String _nombreCompleto { get; set; }

  public int _telefono  { get; set;}

  public String _direccion { get; set; }

  public String _email { get; set; }

  public Boolean _esNuevoCliente { get; set; }

  public override string ToString() => $"({_nombreCompleto}, {_telefono}, {_direccion}, {_email}, {_esNuevoCliente})";

}
