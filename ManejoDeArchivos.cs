using System.Net;
using System.Text.Json;

class ManejoDeArchivos
{

    private string creaAllJsonHeroes(){
        
        var url=$"https://akabab.github.io/superhero-api/api/all.json";
        var request =(HttpWebRequest)WebRequest.Create(url);
        request.Method="GET";
        request.ContentType="application/json";
        request.Accept="application/json";

        try
        {
            using ( WebResponse response = request.GetResponse() )// respuesta de la api
            {
                using (Stream sr = response.GetResponseStream() )// lo convierte en un steam
                {
                    if (sr ==null) return " es vacio";
                    using (StreamReader objReader=new StreamReader(sr)) // luego lo convierte en un steamReader
                    {
                        string responseBody=objReader.ReadToEnd();// luego al SR lo convierte en un string (bloque de texto o json resultante)
                        return responseBody;                       
                    }

                }

            }
            
        }    
        catch (System.Exception)
        {
            
            throw;
        }
        

    }

    public void CraeArchivoJson(){
        string bloqueTexto=creaAllJsonHeroes();
            FileStream mijson= new FileStream("Heroes.json",FileMode.Create);
            using (StreamWriter sw = new StreamWriter(mijson))
            {
                sw.WriteLine(bloqueTexto);//escribo la lista en el archivo
                sw.Close();
            }
    }
    public List<Heroe> heroes(){
        string archivoJson;

        using ( FileStream openArchivoJson= new FileStream("Heroes.json",FileMode.Open)) // abro el archivo 
        {
            using (StreamReader sreader= new StreamReader(openArchivoJson))// lo convierto en algo
            {
                archivoJson= sreader.ReadToEnd(); // lo copio en el archivo ya 
                openArchivoJson.Close();
            }
        }
        List<Heroe>? listaDelJson = JsonSerializer.Deserialize<List<Heroe>>(archivoJson); 
        
        return listaDelJson;

    }
    

}