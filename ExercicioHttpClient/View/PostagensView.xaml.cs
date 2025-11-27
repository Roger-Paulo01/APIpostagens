using ExercicioHttpClient.ViewModels;

namespace ExercicioHttpClient.View;

public partial class PostagensView : ContentPage
{
	public PostagensView()
	{
		InitializeComponent();
		this.BindingContext =  new PostagensViewModel();
	}
}