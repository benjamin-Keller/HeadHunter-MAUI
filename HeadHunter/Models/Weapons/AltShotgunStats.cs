using Newtonsoft.Json;

namespace HeadHunter.Models.Weapons;

public class AltShotgunStats
{
    [JsonProperty("shotgunPelletCount")]
    public int ShotgunPelletCount { get; set; }

    [JsonProperty("burstRate")]
    public double BurstRate { get; set; }
}
