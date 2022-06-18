class Personaje
{
    private Caracteristicas Caract;
    private Datos Dat;

    internal Datos Dat1 { get => Dat; set => Dat = value; }
    internal Caracteristicas Caract1 { get => Caract; set => Caract = value; }
    public Personaje(){
        Caract1=new Caracteristicas();
        Dat1=new Datos();
    }

}
