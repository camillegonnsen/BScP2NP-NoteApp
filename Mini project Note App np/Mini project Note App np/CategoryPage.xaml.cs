using System.Collections.Generic;

namespace Mini_project_Note_App_np;

public partial class CategoryPage : ContentPage
{

    List<String> list = new List<String>() { "Navt Seals", "Memes", "top 5 porn sites", "buddy application" };

    public CategoryPage()
	{
		InitializeComponent();
	}


    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavyPage());
    }
}