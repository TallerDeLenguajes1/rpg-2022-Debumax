class Combate
{   
    public Combate(){}

    public Personaje GanaPelea(Personaje _Pj1, Personaje _Pj2){//gana el mejor de las 3 pega o el que quede en pie , no hay empate
        int cantidad_de_ataques=1;
        Personaje Ganador=new Personaje();
        while (_Pj1.Dat.Salud >0  &&_Pj2.Dat.Salud >0 && cantidad_de_ataques!=3)
        {
            int danio1=_Pj1.Pega();
            int danio2=_Pj2.Pega();
           _Pj1.Dat.ModificaSalud(danio2);
           _Pj2.Dat.ModificaSalud(danio1);
           cantidad_de_ataques++;

        }
        if (_Pj1.Dat.Salud>_Pj2.Dat.Salud)
        {
            Ganador=_Pj1;
            
        }
        else
        {
            if (_Pj1.Dat.Salud<_Pj2.Dat.Salud)
            {
                Ganador=_Pj2;
               
            }
            else
            {// desempate
                int danio1=_Pj1.Pega();
                int danio2=_Pj2.Pega();
                _Pj1.Dat.ModificaSalud(danio2);
                _Pj2.Dat.ModificaSalud(danio1);
                if (_Pj1.Dat.Salud>_Pj2.Dat.Salud)
                {
                    Ganador=_Pj1;
                    
                }else Ganador=_Pj2; 
                
            }
        }
        
        return Ganador;
    }
   




}