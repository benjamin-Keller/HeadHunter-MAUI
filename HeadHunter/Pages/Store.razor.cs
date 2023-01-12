using HeadHunter.Data;
using HeadHunter.Models.Auth;
using HeadHunter.Models.Store;
using HeadHunter.Models.Weapons;
using HeadHunter.Resources;
using Microsoft.AspNetCore.Components;

namespace HeadHunter.Pages;

public partial class Store
{
    [Inject] private StateContainer _stateContainer { get; set; }
    [Inject] private StoreService _storeService { get; set; }
    [Inject] private WeaponsService _weaponsService { get; set; }
    private IEnumerable<string> _promotedBundle { get; set; }
    private IEnumerable<Level> _levels { get; set; } = new List<Level>();
    private Level _selectedWeapon { get; set; } = new();
    private bool _showItem { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (!string.IsNullOrWhiteSpace(_stateContainer.Username))
            (_promotedBundle, _levels) = await _storeService.GetStoreItemsAsync();
    }

    private void SelectWeaponLevel(Level selectedWeapon)
    {
        _selectedWeapon = selectedWeapon;
        _showItem = true;
    }

    private void HideDrilldown() => _showItem = false;
}