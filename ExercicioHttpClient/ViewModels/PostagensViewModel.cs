using CommunityToolkit.Mvvm.ComponentModel;
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
        public int Id;
        public string title;
        public string body;
    }
}
