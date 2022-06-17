class Datos
{
    private string Tipo;
    private string Nombre;
    private string Apodo;
    private DateTime Fecha_Nac;
    private int Edad;
    private int Salud;

    public string Tipo1 { get => Tipo; set => Tipo = value; }
    public string Nombre1 { get => Nombre; set => Nombre = value; }
    public string Apodo1 { get => Apodo; set => Apodo = value; }
    public DateTime Fecha_Nac1 { get => Fecha_Nac; set => Fecha_Nac = value; }
    public int Edad1 { get => Edad; set => Edad = value; }
    public int Salud1 { get => Salud; set => Salud = value; }

    public Datos(){
        Tipo1="un valor de tipo";
        Nombre1="un valor de nombres";
        Apodo1="algun apodo";
        Fecha_Nac1=DateTime.Today;
        Edad1=200;
        Salud1 = 13;
    }
    public void MostrarDatos(){
        Console.WriteLine($"Tipo: {Tipo1}");
        Console.WriteLine($"Nombre: {Nombre1}");
        Console.WriteLine($"Apodo1: {Apodo1}");
        Console.WriteLine($"Fecha de Nacimiento: {Fecha_Nac1}");
        Console.WriteLine($"Edad: {Edad1}");
        Console.WriteLine($"Salud: {Salud1}");

    }
}