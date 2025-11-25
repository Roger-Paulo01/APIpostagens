using CommunityToolkit.Mvvm.ComponentModel;
using ExercicioHttpClient.Models;
using ExercicioHttpClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHttpClient.ViewModels
{
    public class PostagensViewModel : ObservableObject
    {
        [ObservableProperty]
        public int id;
        [ObservableProperty]
        public string title;
        [ObservableProperty]
        public string body;

        public async void CarregaPostagens()
        {
            List<Postagem> Listar = new List<Postagem>();
            Listar = await new PostagensService().GetPostagens();
        }
    }
}
