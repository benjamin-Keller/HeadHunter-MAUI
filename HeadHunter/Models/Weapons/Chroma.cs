using Newtonsoft.Json;

namespace HeadHunter.Models.Weapons;

public class Chroma
{
    [JsonProperty("uuid")]
    public string Uuid { get; set; }

    [JsonProperty("displayName")]
    public string DisplayName { get; set; }

    [JsonProperty("displayIcon")]
    public string DisplayIcon { get; set; }

    [JsonProperty("fullRender")]
    public string FullRender { get; set; }

    [JsonProperty("swatch")]
    public string Swatch { get; set; }

    [JsonProperty("streamedVideo")]
    public string StreamedVideo { get; set; }

    [JsonProperty("assetPath")]
    public string AssetPath { get; set; }
}
