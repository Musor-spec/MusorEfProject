using System;
using System.Collections.Generic;

namespace WebApiMusor.Entities;

public partial class BlackList
{
    public int Id { get; set; }

    public string Reason { get; set; } = null!;

    public DateTime EnteredAt { get; set; }

    public bool IsActive { get; set; }

    public int GuestId { get; set; }

    public virtual Guest Guest { get; set; } = null!;
}
