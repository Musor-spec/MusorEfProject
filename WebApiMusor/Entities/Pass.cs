using System;
using System.Collections.Generic;

namespace WebApiMusor.Entities;

public partial class Pass
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public int Duration { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
