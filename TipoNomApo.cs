class TipoNomApo
{
    private string nom;
    private string apo;

    public TipoNomApo(string _nom,string _apo){
        Nom=_nom;
        Apo=_apo;
    }

    public string Nom { get => nom; set => nom = value; }
    public string Apo { get => apo; set => apo = value; }
}

