using HeadHunter.Models.Events;
using System.Net.Http.Json;

namespace HeadHunter.Data;

public class EventsService
{
    private readonly HttpClient _http;

    public EventsService(HttpClient http)
    {
        _http = http;
    }

    public async Task<EventsModel> GetEventsAsync() => await _http.GetFromJsonAsync<EventsModel>("https://valorant-api.com/v1/events");
}
