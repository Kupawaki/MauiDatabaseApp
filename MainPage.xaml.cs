using System.Diagnostics;
using System.Text;
using System.Text.Json;
using MauiDatabaseApp.Models;

namespace MauiDatabaseApp;

public partial class MainPage : ContentPage
{
	private string url = "http://127.0.0.1:5000";

	public MainPage()
	{
		InitializeComponent();
		//BooksCollectionView.ItemsSource = async list
	}

	private async void OnGetAllButtonClicked(object sender, EventArgs e)
	{
		List<Book> books = new List<Book>();

		HttpClient http = new();
		var response = await http.GetAsync(url);
		string content = await response.Content.ReadAsStringAsync();

		Debug.WriteLine(content);

		//string json_content = "{\"id\":\"99\",\"title\":\"thing\",\"author\":\"person\",\"publisher\":\"org\"}";


        books = JsonSerializer.Deserialize<List<Book>>(content);

		BooksCollectionView.ItemsSource = books;
	}

    private async void OnCreateDocumentButtonClicked(object sender, EventArgs e)
    {
        HttpClient http = new();

		//The PostAsync method wants a uri and something called
		//StringContent, thing is - flask does not like whatever data
		//type StringContent is.

		//Simply put, StringContent is more problematic to use
		//vs string modification

		//Empty StringContent to shut the PostAsync method up
		StringContent sc = new StringContent("");

		//TODO - probably should set some catches here, or things might explode

		//Build the modified URL or URI or whatever
		var urlMod = url + $"/?title={titleET.Text}&author={authorET.Text}&publisher={publisherET.Text}";

		//POST it
		await http.PostAsync(urlMod, sc);
    }
}


