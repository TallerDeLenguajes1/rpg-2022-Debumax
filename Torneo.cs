class Torneo
{
    public Torneo(){}

    public List<Personaje> eliminaciones(List<Personaje> listado){//entrara una lista con los participantes que quedan y devolvera una nueva lista de participantes que quedaron
        int cantParticipante =listado.Count();
        int a=0;
        int b=a+1;
        List<Personaje> nuevoListado = new List<Personaje>();
        Combate batallando=new Combate();

        for (int i = 0; i < cantParticipante/2; i++)
        {
            nuevoListado.Add(batallando.GanaPelea(listado[a],listado[b]));
            a=b+1;
            b=a+1;            
        }


        return nuevoListado;

    }
}