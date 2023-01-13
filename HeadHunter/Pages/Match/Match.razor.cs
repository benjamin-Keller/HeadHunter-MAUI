using Blazored.LocalStorage;
using HeadHunter.Data;
using HeadHunter.Models.Pregame;
using Microsoft.AspNetCore.Components;

namespace HeadHunter.Pages.Match;

public partial class Match
{
    [Inject] private PregameService _pregameService { get; set; }
    [Inject] private ILocalStorageService _localStorage { get; set; }
    private SessionMetadata Session { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        var puuid = await _localStorage.GetItemAsStringAsync("puuid");
        Session = await _pregameService.GetPlayerSessionAsync(puuid);
    }
}