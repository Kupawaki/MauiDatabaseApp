using System.Diagnostics;
using MauiDatabaseApp.Models;

namespace MauiDatabaseApp.Pages;

public partial class DetailPage : ContentPage
{
    private readonly string url = "http://127.0.0.1:5000";
    private readonly Book book;

    public DetailPage(Book incoming)
	{
		InitializeComponent();
        book = incoming;

		titleLB.Text = "Title: " + book.title;
		authorLB.Text = "Author: " + book.author;
		publisherLB.Text = "Publisher: " + book.publisher;
	}

    private async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        HttpClient http = new();

        //Build the modified URL
        var urlMod = url + $"/query/one?title={book.title}&author={book.author}&publisher={book.publisher}";

        Debug.WriteLine(urlMod);

        //POST it
        await http.DeleteAsync(urlMod);

        await Navigation.PopAsync();
    }

    private async void OnUpdateButtonClicked(object sender, EventArgs e)
    {
        HttpClient http = new();

        var urlMod = url + $"/?title={book.title}&author={book.author}&publisher={book.publisher}&titleN=TU&authorN=AU&publisherN=PU";

        StringContent sc = new StringContent("");

        await http.PutAsync(urlMod, sc);

        await Navigation.PopAsync();
    }
}
