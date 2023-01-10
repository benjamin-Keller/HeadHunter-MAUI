using Newtonsoft.Json;

namespace HeadHunter.Models.Weapons;

public class AirBurstStats
{
    [JsonProperty("shotgunPelletCount")]
    public int ShotgunPelletCount { get; set; }

    [JsonProperty("burstDistance")]
    public double BurstDistance { get; set; }
}