using System.ComponentModel.DataAnnotations;

namespace MusorEfCodeFirst.Models;

public class BlackList
{
    [Key]
    public int Id { get; set; }
    public string Reason { get; set; }
    public DateTime EnteredAt { get; set; }
    public bool IsActive { get; set; }
    
    public Guest Guest { get; set; }
}