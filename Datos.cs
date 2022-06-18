class Datos
{
    private string Tipo;
    private string Nombre;
    private string Apodo;
    private string Descripcion;
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

    public string EligePersonaje(){
        
        List<TipoNomApo> Listado=new List<TipoNomApo>();
        var rand=new Random();

        TipoNomApo NA0=new TipoNomApo("Carol Danvers","capitana Marvel");
        TipoNomApo NA1=new TipoNomApo("Natasha Romanoff","Black Widow");
        TipoNomApo NA2=new TipoNomApo("Wanda Maximoff","Scarlett Witch");
        TipoNomApo NA3=new TipoNomApo("Gamora","Gamora");
        TipoNomApo NA4=new TipoNomApo("Jessica Campbell","Jessica Jones");
        TipoNomApo NA5=new TipoNomApo("Laura Kynney ","X-23");
        TipoNomApo NA6=new TipoNomApo("Jean Grey","Phoenix");
        TipoNomApo NA7=new TipoNomApo("Ororo Munroe","Storm");
        TipoNomApo NA8=new TipoNomApo("Shuri de Wakanda","Shuri");
        TipoNomApo NA9=new TipoNomApo("Nadia Pym","Wasp");
        TipoNomApo NA10=new TipoNomApo("Kitty Pryde ","Shadowcat");
        TipoNomApo NA11=new TipoNomApo("Jubilation Lee "," Jubilee");
        TipoNomApo NA12=new TipoNomApo("Anna Marie","Rogue");
        TipoNomApo NA13=new TipoNomApo("Susan Storm","La mujer invisible");
        TipoNomApo NA14=new TipoNomApo("Kamala Khan","Ms. Marvel");
        TipoNomApo NA15=new TipoNomApo("Doreen Green","Squirrel Girl");

        Listado.Add(NA0);
        Listado.Add(NA1);
        Listado.Add(NA2);
        Listado.Add(NA3);
        Listado.Add(NA4);
        Listado.Add(NA5);
        Listado.Add(NA6);
        Listado.Add(NA7);
        Listado.Add(NA8);
        Listado.Add(NA9);
        Listado.Add(NA10);
        Listado.Add(NA11);
        Listado.Add(NA12);
        Listado.Add(NA13);
        Listado.Add(NA14);
        Listado.Add(NA15);



        return "";
    }

}
