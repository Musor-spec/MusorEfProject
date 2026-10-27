using System;
using System.Collections.Generic;

namespace WebApiMusor.Entities;

public partial class TrenerDto
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public decimal Price { get; set; }

    public static explicit operator TrenerDto(Trener trener)
    {
        return new TrenerDto
        {
            Id = trener.Id,
            FirstName = trener.FirstName,
            LastName = trener.LastName,
            Email = trener.Email,
            Price = trener.Price,
        };
    }
}
