using BooksWeb.Models;

public class BookReader
{
    public int BookId { get; set; }
    public int ReaderId { get; set; }
    public int Score { get; set; }
    public string Status { get; set; }

    public Reader Reader { get; set; }
    public Book Book { get; set; }
}