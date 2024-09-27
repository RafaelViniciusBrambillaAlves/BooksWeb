using BooksWeb.Models;
using Microsoft.EntityFrameworkCore;

public class BookDatabase: DbContext{

     public BookDatabase(DbContextOptions options) : base(options) {}

    public DbSet<Book> Books { get; set; }   
    public DbSet<Reader> Readers { get; set; }
}