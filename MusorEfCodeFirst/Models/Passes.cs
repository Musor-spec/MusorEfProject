using System.ComponentModel.DataAnnotations;

namespace MusorEfCodeFirst.Models;

public class Passes
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Duration { get; set; }
    
    public List<Payments> Payments { get; set; }
}