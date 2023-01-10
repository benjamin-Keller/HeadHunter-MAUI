using Newtonsoft.Json;

namespace HeadHunter.Models.Weapons;

public class WeaponMetadata
{
    [JsonProperty("status")]
    public int Status { get; set; }

    [JsonProperty("data")]
    public List<Weapon> Data { get; set; }
}
