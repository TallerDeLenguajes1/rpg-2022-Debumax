class Datos
{
    private string? tipos;
    private string? nombre;
    private string? apodo;
    private string? descripcion;
    private DateTime fecha_Nac;
    private int edad;
    private int salud;

    public string? Tipo { get => tipos; set => tipos = value; }
    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apodo { get => apodo; set => apodo = value; }
    public DateTime Fecha_Nac { get => fecha_Nac; set => fecha_Nac = value; }
    public int Edad { get => edad; set => edad = value; }
    public int Salud { get => salud; set => salud = value; }
    public string? Descripcion { get => descripcion; set => descripcion = value; }

    public Datos(){
        ApiHeroes mda = new ApiHeroes();
        mda.CraeArchivoJson();
        List<Heroe> hrs=mda.heroes();//listado de heroes sacsados del json , creo listado de los heroes para luego filtrarlos 
        List<HeroesFiltrados> heroesMujeres;
        Heroe hr=new Heroe();
        heroesMujeres=hr.ListaFiltrada(hrs);//152 elementos

        var rand=new Random();
        int index=rand.Next(0,152);//identificacion del heroe 
        Tipo=heroesMujeres[index].Tipo;
        Nombre=heroesMujeres[index].Nombre;
        Apodo=heroesMujeres[index].Apodo;
        descripcion=heroesMujeres[index].Descripcion;
        
        Fecha_Nac=new DateTime(rand.Next(1722,2023),rand.Next(1,13),rand.Next(1,31));
        Edad=DateTime.Today.AddTicks(-fecha_Nac.Ticks).Year - 1;
        Salud = rand.Next(1,101);
    }
    public void MostrarDatos(){
        Console.WriteLine($"Tipo: {Tipo}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Apodo1: {Apodo}");
        Console.WriteLine($"Fecha de Nacimiento: {Fecha_Nac.ToShortDateString()}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Salud: {Salud}");

    }
    public int ModificaSalud(int danio){
        Salud=Salud-danio;
        return Salud;
    } 
}
