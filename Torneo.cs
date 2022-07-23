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
    public void MuestraGanadoresDeRonda(List<Personaje> listaParticipantes){
        
        foreach (Personaje pj in listaParticipantes)
        {
            pj.Dat.MostrarDatos();
            pj.Caract.MostrarCaracteristicas();
            Console.WriteLine("\n");
        }
    }

    public List<Personaje> ParticipantesOriginales(List<Personaje> participantesCopia){
        List<Personaje> listaGanadoraPrimeraRondaOriginal=new List<Personaje>();//info original de los ganadores

        foreach (var participante in participantesCopia)
        {
            string? fullname=participante.Dat.Nombre;
            foreach (var ganador in participantesCopia)
            {
                if (fullname==ganador.Dat.Nombre)
                {
                    listaGanadoraPrimeraRondaOriginal.Add(participante);
                }
            }

        }
        return listaGanadoraPrimeraRondaOriginal;

    }

}