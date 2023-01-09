using Newtonsoft.Json;

namespace HeadHunter.Models.Weapons;

public class Weapon
{
    [JsonProperty("uuid")]
    public string Uuid { get; set; }

    [JsonProperty("displayName")]
    public string DisplayName { get; set; }

    [JsonProperty("category")]
    public string Category { get; set; }

    [JsonProperty("defaultSkinUuid")]
    public string DefaultSkinUuid { get; set; }

    [JsonProperty("displayIcon")]
    public string DisplayIcon { get; set; }

    [JsonProperty("killStreamIcon")]
    public string KillStreamIcon { get; set; }

    [JsonProperty("assetPath")]
    public string AssetPath { get; set; }

    [JsonProperty("weaponStats")]
    public WeaponStats WeaponStats { get; set; }

    [JsonProperty("shopData")]
    public ShopData ShopData { get; set; }

    [JsonProperty("skins")]
    public List<Skin> Skins { get; set; }

}