using System;
using System.Collections.Generic;

namespace WebApiMusor.Entities;

public partial class DayDto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int TrenerWorkDaysId { get; set; }

    public static explicit operator DayDto(Day day)
    {
        return new DayDto()
        {
            Id = day.Id,
            Name = day.Name,
            TrenerWorkDaysId = day.TrenerWorkDaysId,
        };
    }
}
