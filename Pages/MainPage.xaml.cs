using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Text.Json;
using MauiDatabaseApp.Models;
using MauiDatabaseApp.Pages;

namespace MauiDatabaseApp;

public partial class MainPage : ContentPage
{
	private readonly string url = "http://127.0.0.1:5000";
	private HttpClient http;
    public ObservableCollection<Book> Books;

    public MainPage()
	{
		InitializeComponent();

		Books = new();
    }

    private async void OnCreateDocumentButtonClicked(object sender, EventArgs e)
    {
		http = new();

        StringContent sc = new StringContent("");

		//Build the modified URL
		var urlMod = url + $"/?title={titleET.Text}&author={authorET.Text}&publisher={publisherET.Text}";

		//POST it
		await http.PostAsync(urlMod, sc);

		RefreshCollection();
    }

	private async void RefreshCollection()
	{
		Books.Clear();

		http = new();

        var response = await http.GetAsync(url);
        string content = await response.Content.ReadAsStringAsync();
		List<Book> books = new List<Book>();
        books = JsonSerializer.Deserialize<List<Book>>(content);

		foreach(Book book in books)
		{
			Books.Add(book);
		}

        BooksCollectionView.ItemsSource = Books;
    }

    private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Book selectedItem)
        {
            Navigation.PushAsync(new DetailPage(selectedItem));

            // Clear the selection to allow selecting the same item again
            ((CollectionView)sender).SelectedItem = null;
        }
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        RefreshCollection();
    }
}


