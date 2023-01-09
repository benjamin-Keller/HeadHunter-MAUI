using Newtonsoft.Json;

namespace HeadHunter.Models.Weapons;

public class DamageRange
{
    [JsonProperty("rangeStartMeters")]
    public int RangeStartMeters { get; set; }

    [JsonProperty("rangeEndMeters")]
    public int RangeEndMeters { get; set; }

    [JsonProperty("headDamage")]
    public double HeadDamage { get; set; }

    [JsonProperty("bodyDamage")]
    public int BodyDamage { get; set; }

    [JsonProperty("legDamage")]
    public double LegDamage { get; set; }
}