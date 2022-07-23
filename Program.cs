//listado de heroes a participar
List<Personaje> participantes= new List<Personaje>();
for (int i = 0; i < 8; i++)//12 seran siempre los participantes
{
    Personaje unPj=new Personaje();
    participantes.Add(unPj);
}

//guarda los participantes que salieron 
ManejoDeArchivo Participantesjson= new ManejoDeArchivo();
Participantesjson.creaJsonParticipantes(participantes,"elegidos.json");//los 8 participantes
List<Personaje> participantesCopia=Participantesjson.leerArchivoJsonParticipantes("elegidos.json");


Torneo T1=new Torneo();


Console.WriteLine("-----------!!!!!! Ganador primera Ronda \n");

List<Personaje> ganadoresPrimeraRonda=new List<Personaje>();
ganadoresPrimeraRonda =T1.eliminaciones(participantesCopia);//ganadores de ronda
List<Personaje> listaGanadoraPrimeraRondaOriginal;
listaGanadoraPrimeraRondaOriginal =T1.ParticipantesOriginales(ganadoresPrimeraRonda);
T1.MuestraGanadoresDeRonda(listaGanadoraPrimeraRondaOriginal);



Console.WriteLine("SEGUNDA RONDA GANADORES \n");
ManejoDeArchivo ParticipantesSegundaRondajson= new ManejoDeArchivo();

//creo archivo de los participantes que quedaron de la primera ronda
ParticipantesSegundaRondajson.creaJsonParticipantes(listaGanadoraPrimeraRondaOriginal,"PrimeraRonda.json");//los 4 participantes
List<Personaje> listaSegundaRonda=ParticipantesSegundaRondajson.leerArchivoJsonParticipantes("PrimeraRonda.json");

//pelea y ganadores de la 2da ronda

List<Personaje> ganadoresSegundaRonda=new List<Personaje>();
ganadoresSegundaRonda =T1.eliminaciones(listaSegundaRonda);
List<Personaje> ganadoresSegundaRondaOriginales =new List<Personaje>();
ganadoresSegundaRondaOriginales =T1.ParticipantesOriginales(ganadoresSegundaRonda);
T1.MuestraGanadoresDeRonda(ganadoresSegundaRondaOriginales);




