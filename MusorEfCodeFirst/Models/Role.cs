using System.ComponentModel.DataAnnotations;

namespace MusorEfCodeFirst.Models;

public class Role
{
    [Key]
    public int Id { get; set; }
    [MaxLength(255)]
    public string RoleName { get; set; }
    
    public IEnumerable<Guest> Guests { get; set; }
}