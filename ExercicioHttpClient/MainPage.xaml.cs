using ExercicioHttpClient.Models;
//using System.Text.Json;
using Newtonsoft.Json;

namespace ExercicioHttpClient
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        async private void BuscarBtn_Clicked(object sender, EventArgs e)
        {
            //Pedir uma informação para a API
            //Pegar o dado, que veio da API
            //Formatar o dado para que ele seja um objeto
            //Exibir o dado na tela
            Usuario meuUsuario = new Usuario();
            Postagem minhaPostagem = new Postagem();
            //string URI = "http://has.azure-api.net/teste";
            string URI = "https://jsonplaceholder.typicode.com/posts";
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync(URI);

            List<Postagem> postagens = new List<Postagem>();

            if (responseMessage.IsSuccessStatusCode)
            {
                //É necessário Serializar e Desserializar a informação
                string conteudo = await responseMessage.Content.ReadAsStringAsync();
                //meuUsuario = JsonConvert.DeserializeObject<Usuario>(conteudo);
                postagens = JsonConvert.DeserializeObject<List<Postagem>>(conteudo);
                //CPFLbl.Text = meuUsuario.CPF;
                NomeLbl.Text = postagens[0].Title;
            }
        }
    }
}
