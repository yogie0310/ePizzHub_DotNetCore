﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ePizzaHub.Entities.Entities;

public partial class OrderItem
{
    public int Id { get; set; }

    public int ItemId { get; set; }

    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    public decimal Total { get; set; }

    public string OrderId { get; set; }

    public virtual Item Item { get; set; }

    public virtual Order Order { get; set; }
}