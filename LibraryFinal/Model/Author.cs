using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryFinal.Model;

public class Author
{
    public int Id { get; set; } //Primary Key Identificador numerico unico.

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }

    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
    public DateOnly? BirthDate { get; set; }

    public string? Email { get; set; }
}

