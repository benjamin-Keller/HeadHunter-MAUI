using HeadHunter.Models.Weapons;
using Microsoft.AspNetCore.Components;

namespace HeadHunter.Components.Store;

public partial class FeaturedItem
{
    [Parameter] public Level Data { get; set; }

    [Parameter] public EventCallback<Level> FeaturedItemClicked { get; set; }
}