using HeadHunter.Data;
using HeadHunter.Models.Auth;
using HeadHunter.Resources;
using Microsoft.AspNetCore.Components;

namespace HeadHunter.Pages.Auth;

public partial class LocalLogin : IDisposable
{
    [Inject] private AuthService _authService { get; set; }
    [Inject] private StateContainer _stateContainer { get; set; }
    [Inject] private NavigationManager _navigationManager { get; set; }
    private RiotUser _loginModel { get; set; } = new();

    private async Task HandleSubmitAsync()
    {
        var userInfo = await _authService.AuthenticateAsync(_loginModel);

        if (userInfo != null)
        {
            _stateContainer.OnStateChange += StateHasChanged;
            _navigationManager.NavigateTo("/", true);
        }
    }

    public void Dispose() => _stateContainer.OnStateChange -= StateHasChanged;
}