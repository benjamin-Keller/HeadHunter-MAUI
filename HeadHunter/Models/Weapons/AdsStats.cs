using Newtonsoft.Json;

namespace HeadHunter.Models.Weapons;

public class AdsStats
{
    [JsonProperty("zoomMultiplier")]
    public double ZoomMultiplier { get; set; }

    [JsonProperty("fireRate")]
    public double FireRate { get; set; }

    [JsonProperty("runSpeedMultiplier")]
    public double RunSpeedMultiplier { get; set; }

    [JsonProperty("burstCount")]
    public int BurstCount { get; set; }

    [JsonProperty("firstBulletAccuracy")]
    public double FirstBulletAccuracy { get; set; }
}
