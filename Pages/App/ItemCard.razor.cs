using MusicStore.Models;
using Microsoft.AspNetCore.Components;
using System.IO.Pipelines;

namespace MusicStore.Pages.App
{
    public partial class ItemCard
    {
        [Parameter]
        public Item? Item { get; set; }
    }
}
