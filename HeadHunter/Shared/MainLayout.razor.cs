using Blazored.LocalStorage;
using HeadHunter.Resources;
using Microsoft.AspNetCore.Components;

namespace HeadHunter.Shared;

public partial class MainLayout
{
    [Inject] private StateContainer _stateContainer { get; set; }
    [Inject] private ILocalStorageService _localStorage { get; set; }

    protected override async Task OnInitializedAsync()
    {

    }
}