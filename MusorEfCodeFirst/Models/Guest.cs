using System.ComponentModel.DataAnnotations;

namespace MusorEfCodeFirst.Models;

public class Guest
{
    [Key]
    public int Id { get; set; }
    [MaxLength(50)]
    public string FirstName { get; set; }
    [MaxLength(50)]
    public string LastName { get; set; }
    [MaxLength(150)]
    public string? Email { get; set; }
    
    
    public Role? Role { get; set; }
}