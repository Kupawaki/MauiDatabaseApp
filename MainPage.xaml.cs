namespace MauiDatabaseApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnGetAllButtonClicked(object sender, EventArgs e)
	{
		Console.WriteLine("Clicked Button");
		HttpClient http = new();
		var response = await http.GetAsync("http://127.0.0.1:5000/book");
	}
}


