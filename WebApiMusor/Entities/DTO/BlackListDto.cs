using System;
using System.Collections.Generic;

namespace WebApiMusor.Entities;

public partial class BlackListDto
{
    public int Id { get; set; }

    public string Reason { get; set; } = null!;

    public DateTime EnteredAt { get; set; }

    public bool IsActive { get; set; }

    public int GuestId { get; set; }

    public static explicit operator BlackListDto(BlackList blackList)
    {
        return new BlackListDto()
        {
            Id = blackList.Id,
            Reason = blackList.Reason,
            EnteredAt = blackList.EnteredAt,
            IsActive = blackList.IsActive,
            GuestId = blackList.GuestId,
        };
    }
}
