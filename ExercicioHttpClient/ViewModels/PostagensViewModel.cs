using CommunityToolkit.Mvvm.ComponentModel;
using ExercicioHttpClient.Models;
using ExercicioHttpClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExercicioHttpClient.ViewModels
{
    public  partial class PostagensViewModel : ObservableObject
    {
        [ObservableProperty]
        public int id;
        [ObservableProperty]
        public int userid;
        [ObservableProperty]
        public string title;
        [ObservableProperty]    
        public string body;
        public ICommand CarregarPostagensCommand => new Command(async () => CarregaPostagens());

        public async void CarregaPostagens()
        {
            List<Postagem> Listar = new List<Postagem>();
            Listar = await new PostagensService().GetPostagens();
            Id = Listar[0].Id;
            Title = Listar[0].Title;
            Body = Listar[0].Body;
        }
    }
}
