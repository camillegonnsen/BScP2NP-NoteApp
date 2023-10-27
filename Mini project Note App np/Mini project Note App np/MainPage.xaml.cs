using System.Xml.Serialization;

namespace Mini_project_Note_App_np;

public partial class MainPage : ContentPage
{
	int count = 0;


	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new CategoryPage());
	}


}

