using System;
using System.Collections.Generic;

namespace WebApiMusor.Entities;

public partial class RoleDto
{
    public int Id { get; set; }

    public string RoleName { get; set; } = null!;

    public static explicit operator RoleDto(Role role)
    {
        return new RoleDto
        {
            Id = role.Id,
            RoleName = role.RoleName
        };
    }
}
