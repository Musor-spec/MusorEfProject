using System;
using System.Collections.Generic;

namespace WebApiMusor.Entities;

public partial class GuestDto
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Email { get; set; }

    public int? RoleId { get; set; }

    public static explicit operator GuestDto(Guest guest)
    {
        return new GuestDto
        {
            Id = guest.Id,
            FirstName = guest.FirstName,
            LastName = guest.LastName,
            Email = guest.Email,
            RoleId = guest.RoleId
        };
    }
}
