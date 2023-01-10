using HeadHunter.Models.Weapons;
using System.Net.Http.Json;

namespace HeadHunter.Data;

public class WeaponsService
{
    private readonly HttpClient _httpClient;
    private IEnumerable<WeaponMetadata> _weaponCache { get; set; }

    public WeaponsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Weapon> GetWeaponAsync(string uuid)
    {
        var weapon = await _httpClient.GetFromJsonAsync<WeaponMetadata>("https://valorant-api.com/v1/weapons");

        return weapon.Data.FirstOrDefault(e => e.Uuid == uuid);
    }

    public async Task<IEnumerable<Weapon>> GetWeaponsAsync()
    {
        var weapons = await _httpClient.GetFromJsonAsync<WeaponMetadata>("https://valorant-api.com/v1/weapons/skins");

        return weapons.Data;
    }

    public async Task<IEnumerable<Level>> GetWeaponLevelsAsync()
    {
        var levels = await _httpClient.GetFromJsonAsync<LevelMetadata>("https://valorant-api.com/v1/weapons/skinlevels");

        return levels.Data;
    }

    public async Task<List<Level>> GetWeaponSkinByUuidAsync(List<string> skinUuids)
    {
        var _levels = await GetWeaponLevelsAsync();

        var _weaponLevels = new List<Level>();

        foreach(var level in _levels)
        {
            foreach(var uuid in skinUuids)
            {
                _weaponLevels.Add(_levels.SingleOrDefault(e => e.Uuid == uuid));
                continue;
            }
            break;
        }

        return _weaponLevels;
    }
}
