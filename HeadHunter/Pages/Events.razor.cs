using HeadHunter.Data;
using HeadHunter.Models.Events;
using Microsoft.AspNetCore.Components;

namespace HeadHunter.Pages;

public partial class Events
{
    [Inject] private EventsService eventsService { get; set; }

    private EventsModel EventsData { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        EventsData = await eventsService.GetEventsAsync();
    }
}