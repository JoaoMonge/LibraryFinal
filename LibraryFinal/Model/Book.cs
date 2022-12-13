using System;
namespace LibraryFinal.Model;
using System.ComponentModel.DataAnnotations.Schema;

public class Book
{
    public int Id { get; set; } //Primary key
    public string? Isbn { get; set; }
    public string? Name { get; set; }
    public Author? Author { get; set; }
    public decimal Price { get; set; }

    // CRUD - Create Read Update Delete

}

