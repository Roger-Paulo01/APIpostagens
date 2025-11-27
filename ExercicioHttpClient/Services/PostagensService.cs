using ExercicioHttpClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHttpClient.Services
{
    public class PostagensService
    {
        async public Task <List<Postagem>>GetPostagens()
        {
            //Pedir uma informação para a API
            //Pegar o dado, que veio da API
            //Formatar o dado para que ele seja um objeto

            List<Postagem> postagems = new List<Postagem>();
            string URI = "https://jsonplaceholder.typicode.com/posts";
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync(URI);

            if (responseMessage.IsSuccessStatusCode)
            {
                //É necessário Serializar e Desserializar a informação
                string conteudo = await responseMessage.Content.ReadAsStringAsync();
                postagems = JsonConvert.DeserializeObject<List<Postagem>>(conteudo);
            }
            return postagems;
        }
    }
}
