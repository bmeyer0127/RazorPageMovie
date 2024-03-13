using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models;

public class Movie
{
  public int Id { get; set; }
  public string Title { get; set; } = string.Empty;
  [Display(Name = "Release Date")]        //Adds the space between the words in what is displayed
  [DataType(DataType.Date)]               //Removes the time, keeps the date
  public DateTime ReleaseDate { get; set; }
  public string? Genre { get; set; }
  [Column(TypeName = "decimal(18, 2)")]   //Maps Price to the currency in the database
  public decimal Price { get; set; }
}