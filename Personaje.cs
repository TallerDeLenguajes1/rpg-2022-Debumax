class Personaje
{
    private Caracteristicas caract;
    private Datos dat;

    public Caracteristicas Caract { get => caract; set => caract = value; }
    public Datos Dat { get => dat; set => dat = value; }

    public Personaje(){
        Caract=new Caracteristicas();
        Dat=new Datos();
    }
    
    public int Pega(){
        Random rand=new Random();
        int PD=Caract.Desteza * Caract.Fuerza * Caract.Nivel ; //Poder de disparo
        int ED=rand.Next(1,101);//efectividad de disparo
        int VA=PD*ED;//valor de ataque
        int MDP = rand.Next(1,50000) ;// maximo daño provocable
        int a=VA*ED;//
        int b =a-PD;
        int c=(a-PD)/MDP;
        int  DP=(((a )-PD)/MDP);
        return DP;
    }

    public int Defiende(int _DP){
        int salud =Dat.ModificaSalud(_DP);
        return salud;
    }

}
