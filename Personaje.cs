class Personaje
{
    private Caracteristicas caract;
    private Datos dat;

    internal Datos Datos { get => dat; }
    internal Caracteristicas Caracteristicas { get => caract; }
    public Personaje(){
        caract=new Caracteristicas();
        dat=new Datos();
    }

}
