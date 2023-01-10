using Newtonsoft.Json;

namespace HeadHunter.Models.Weapons;

public class Skin
{
    [JsonProperty("uuid")]
    public string Uuid { get; set; }

    [JsonProperty("displayName")]
    public string DisplayName { get; set; }

    [JsonProperty("themeUuid")]
    public string ThemeUuid { get; set; }

    [JsonProperty("contentTierUuid")]
    public string ContentTierUuid { get; set; }

    [JsonProperty("displayIcon")]
    public string DisplayIcon { get; set; }

    [JsonProperty("wallpaper")]
    public string Wallpaper { get; set; }

    [JsonProperty("assetPath")]
    public string AssetPath { get; set; }

    [JsonProperty("chromas")]
    public List<Chroma> Chromas { get; set; }

    [JsonProperty("levels")]
    public List<Level> Levels { get; set; }
}
