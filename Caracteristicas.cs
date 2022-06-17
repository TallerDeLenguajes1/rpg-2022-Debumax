class Caracteristicas
{
    private int velocidad;//1-10
    private int desteza;//1-5
    private int fuerza;//1-10
    private int nivel;//1-10
    private int armadura;//1-10

    public int Velocidad { get => velocidad; set => velocidad = value; }
    public int Desteza { get => desteza; set => desteza = value; }
    public int Fuerza { get => fuerza; set => fuerza = value; }
    public int Nivel { get => nivel; set => nivel = value; }
    public int Armadura { get => armadura; set => armadura = value; }

    public Caracteristicas(){

        //Asigno los valores de forma aleatoria 
        var rand=new Random();
        Velocidad=rand.Next(1,11);
        Desteza=rand.Next(1,6);
        Fuerza=rand.Next(1,11);
        Nivel=rand.Next(1,11);
        Armadura=rand.Next(1,11);
    }

    public void MostrarCaracteristicas(){
        Console.WriteLine($"Velocidad: {Velocidad}");
        Console.WriteLine($"Desteza: {Desteza}");
        Console.WriteLine($"fuerza: {fuerza}");
        Console.WriteLine($"Nivel: {Nivel}");
        Console.WriteLine($"Armadura: {Armadura}");
    }
}