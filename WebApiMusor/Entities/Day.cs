using System;
using System.Collections.Generic;

namespace WebApiMusor.Entities;

public partial class Day
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int TrenerWorkDaysId { get; set; }

    public virtual Trener TrenerWorkDays { get; set; } = null!;
}
