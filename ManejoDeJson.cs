using System.Text.Json;

class ManejoDeArchivo
{
    public ManejoDeArchivo(){}
    public List<Personaje> leerArchivoJsonParticipantes(string archivoJson){
        //archivoJson=Movis.json

        using ( FileStream openArchivoJson= new FileStream(archivoJson,FileMode.Open)) // abro el archivo que paso por parametro
        {
            using (StreamReader sreader= new StreamReader(openArchivoJson))// lo convierto en algo
            {
                archivoJson= sreader.ReadToEnd(); // lo copio en el archivo ya 
                openArchivoJson.Close();
            }
        }
        List<Personaje>? listaDelJson = JsonSerializer.Deserialize<List<Personaje>>(archivoJson); // lo convierto en la lista de productos
        return listaDelJson;
    }

    public void creaJsonParticipantes(List<Personaje> listadoHeroes,string nombre_archivo){
        string textJson = JsonSerializer.Serialize(listadoHeroes);// pasamos a json
        FileStream mijson= new FileStream(nombre_archivo,FileMode.Create);
        using (StreamWriter sw = new StreamWriter(mijson))
        {
            sw.WriteLine(textJson);//escribo la lista en el archivo
            sw.Close();
        }
    }

}