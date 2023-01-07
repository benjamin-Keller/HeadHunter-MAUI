using HeadHunter.Models.Events;
using Microsoft.AspNetCore.Components;

namespace HeadHunter.Components;

public partial class Timeline
{
    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public List<EventData> Events { get; set; }
}