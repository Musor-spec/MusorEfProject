using System.ComponentModel.DataAnnotations;

namespace MusorEfCodeFirst.Models;

public class Days
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }

    public Treners TrenerWorkDays { get; set; }
}