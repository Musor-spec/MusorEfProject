using System;
using System.Collections.Generic;

namespace WebApiMusor.Entities;

public partial class Payment
{
    public int Id { get; set; }

    public bool IsPayment { get; set; }

    public int GuestPaymentId { get; set; }

    public int? PassesId { get; set; }

    public virtual Guest GuestPayment { get; set; } = null!;

    public virtual Pass? Passes { get; set; }
}
