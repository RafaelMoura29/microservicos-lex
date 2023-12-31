﻿using System;

namespace AwesomeShop.Services.Customers.Core.Entities
{
    public class OrderItem
    {
        public OrderItem(Guid id, Guid productId, int quantity, decimal price)
        {
            Id = id;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }

        public Guid Id { get; private set; }
        public Guid ProductId { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
    }
}
