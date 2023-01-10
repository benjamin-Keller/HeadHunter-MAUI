using Newtonsoft.Json;

namespace HeadHunter.Models.Weapons;

public class LevelMetadata
{
    [JsonProperty("status")]
    public int Status { get; set; }

    [JsonProperty("data")]
    public List<Level> Data { get; set; }
}

public class Level
{
    [JsonProperty("uuid")]
    public string Uuid { get; set; }

    [JsonProperty("displayName")]
    public string DisplayName { get; set; }

    [JsonProperty("levelItem")]
    public string LevelItem { get; set; }

    [JsonProperty("displayIcon")]
    public string DisplayIcon { get; set; }

    [JsonProperty("streamedVideo")]
    public string StreamedVideo { get; set; }

    [JsonProperty("assetPath")]
    public string AssetPath { get; set; }
}