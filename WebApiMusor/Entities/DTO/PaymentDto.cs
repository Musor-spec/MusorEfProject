using System;
using System.Collections.Generic;

namespace WebApiMusor.Entities;

public partial class PaymentDto
{
    public int Id { get; set; }

    public bool IsPayment { get; set; }

    public int GuestPaymentId { get; set; }

    public int? PassesId { get; set; }

    public static explicit operator PaymentDto(Payment payment)
    {
        return new PaymentDto
        {
            Id = payment.Id,
            IsPayment = payment.IsPayment,
            GuestPaymentId = payment.GuestPaymentId,
            PassesId = payment.PassesId,
        };
    }
}
