using System;
using System.Collections.Generic;

namespace WebApiMusor.Entities;

public partial class PassDto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public int Duration { get; set; }

    public static explicit operator PassDto(Pass pass)
    {
        return new PassDto
        {
            Id = pass.Id,
            Name = pass.Name,
            Price = pass.Price,
            Duration = pass.Duration
        };
    }
}
