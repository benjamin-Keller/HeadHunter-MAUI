using Blazored.LocalStorage;
using HeadHunter.Models.Auth;
using HeadHunter.Resources;
using Microsoft.AspNetCore.Components;
using System.Net;

namespace HeadHunter.Shared;

public partial class AppBar
{
    [Inject] NavigationManager _navigationManager { get; set; }
    [Inject] StateContainer _stateContainer { get; set; }
    [Inject] private ILocalStorageService _localStorage { get; set; }
    private string _userName { get; set; }
    private void OpenLoginManagerAsync() => _navigationManager.NavigateTo("/login");
    private async Task StateContainer_OnChangeAsync() => StateHasChanged();

    protected override async Task OnInitializedAsync()
    {
        _userName = await _localStorage.GetItemAsync<string>("username");
        var _settings = new UserProfileSettings
        {
            Puuid = await _localStorage.GetItemAsync<string>("puuid"),
            AccessToken = await _localStorage.GetItemAsync<string>("access_token"),
            Entitlement = await _localStorage.GetItemAsync<string>("entitlement_token"),
            Region = await _localStorage.GetItemAsync<string>("region"),
        };

        await _stateContainer.InitAsync(settings: _settings, username: _userName);
        await StateContainer_OnChangeAsync();
    }

    private async Task HandleLogoutAsync()
    {
        var _username = await _localStorage.GetItemAsync<string>("username");
        if (!string.IsNullOrWhiteSpace(_username))
        {
            await _localStorage.RemoveItemsAsync(new[] { "username", "puuid", "access_token", "entitlement_token", "region" });
            _navigationManager.NavigateTo("/", true);
            await StateContainer_OnChangeAsync();
        }
    }
}