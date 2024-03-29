﻿namespace MusicStore.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public List<Item>? Items { get; set; }
        public string? ImageUrl { get; set; }
    }
}
