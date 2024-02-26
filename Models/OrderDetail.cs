﻿using System.IO.Pipelines;

namespace MusicStore.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }
        public decimal? Price { get; set; }
        public Item Item { get; set; } = default!;
        public Order Order { get; set; } = default!;
    }
}
