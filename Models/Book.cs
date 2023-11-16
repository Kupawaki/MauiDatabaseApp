namespace MauiDatabaseApp.Models
{
	public class Book
	{

		public Book(string title, string author, string publisher)
		{
			this.title = title;
			this.author = author;
			this.publisher = publisher;
		}

		public string title { get; set; }
		public string author { get; set; }
		public string publisher { get; set; }
	}
}

