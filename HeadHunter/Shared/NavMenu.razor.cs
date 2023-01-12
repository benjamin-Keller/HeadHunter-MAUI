using Blazored.LocalStorage;
using HeadHunter.Resources;
using Microsoft.AspNetCore.Components;

namespace HeadHunter.Shared;

public partial class NavMenu
{
    [Inject] private StateContainer _stateContainer { get; set; }
    [Inject] private ILocalStorageService _localStorage { get; set; }

    private bool collapseNavMenu = true;
    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;
    private async Task StateContainer_OnChangeAsync() => StateHasChanged();

    protected override async Task OnInitializedAsync()
    {
        await StateContainer_OnChangeAsync();
    }
    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
}