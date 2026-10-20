using System.ComponentModel.DataAnnotations;

namespace MusorEfCodeFirst.Models;

public class Payments
{
    [Key]
    public int Id { get; set; }
    public bool IsPayment { get; set; }
    
    public Guest GuestPayment { get; set; }
}