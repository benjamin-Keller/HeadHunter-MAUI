using HeadHunter.Data;
using HeadHunter.Models.Auth;
using HeadHunter.Models.Store;
using HeadHunter.Models.Weapons;
using Microsoft.AspNetCore.Components;

namespace HeadHunter.Pages;

public partial class Store
{
    [Inject] private AuthService _authService { get; set; }
    [Inject] private StoreService _storeService { get; set; }
    [Inject] private WeaponsService _weaponsService { get; set; }
    private IEnumerable<string> _promotedBundle { get; set; }
    private IEnumerable<Level> _levels { get; set; } = new List<Level>();
    private Level _selectedWeapon { get; set; } = new();
    private bool _showItem { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var riotUser = new RiotUser ();
        var userInfo = await _authService.AuthenticateAsync(riotUser);
        (_promotedBundle, _levels) = await _storeService.GetStoreItemsAsync(userInfo);
    }

    private void SelectWeaponLevel(Level selectedWeapon)
    {
        _selectedWeapon = selectedWeapon;
        _showItem = true;
    }

    private void HideDrilldown() => _showItem = false;
}