using System.ComponentModel.DataAnnotations;

namespace MusorEfCodeFirst.Models;

public class Treners
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public decimal Price { get; set; }
}