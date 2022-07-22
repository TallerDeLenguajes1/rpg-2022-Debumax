//listado de heroes a participar
List<Personaje> participantes= new List<Personaje>();
for (int i = 0; i < 8; i++)//12 seran siempre los participantes
{
    Personaje unPj=new Personaje();
    participantes.Add(unPj);
}


ManejoDeArchivo archivos= new ManejoDeArchivo();
archivos.creaJsonParticipantes(participantes,"elegidos.json");//los 8 participantes
List<Personaje> otralista=archivos.leerArchivoJsonParticipantes("elegidos.json");

foreach (Personaje pj in otralista)
{
    pj.Dat.MostrarDatos();
    pj.Caract.MostrarCaracteristicas();
    Console.WriteLine("\n");
}