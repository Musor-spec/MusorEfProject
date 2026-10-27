using System;
using System.Collections.Generic;

namespace WebApiMusor.Entities;

public partial class Trener
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<Day> Days { get; set; } = new List<Day>();
}
