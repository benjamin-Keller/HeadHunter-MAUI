using Newtonsoft.Json;

namespace HeadHunter.Models.Weapons;

public class WeaponStats
{
    [JsonProperty("fireRate")]
    public double FireRate { get; set; }

    [JsonProperty("magazineSize")]
    public int MagazineSize { get; set; }

    [JsonProperty("runSpeedMultiplier")]
    public double RunSpeedMultiplier { get; set; }

    [JsonProperty("equipTimeSeconds")]
    public double EquipTimeSeconds { get; set; }

    [JsonProperty("reloadTimeSeconds")]
    public double ReloadTimeSeconds { get; set; }

    [JsonProperty("firstBulletAccuracy")]
    public double FirstBulletAccuracy { get; set; }

    [JsonProperty("shotgunPelletCount")]
    public int ShotgunPelletCount { get; set; }

    [JsonProperty("wallPenetration")]
    public string WallPenetration { get; set; }

    [JsonProperty("feature")]
    public string Feature { get; set; }

    [JsonProperty("fireMode")]
    public string FireMode { get; set; }

    [JsonProperty("altFireType")]
    public string AltFireType { get; set; }

    [JsonProperty("adsStats")]
    public AdsStats AdsStats { get; set; }

    [JsonProperty("altShotgunStats")]
    public AltShotgunStats AltShotgunStats { get; set; }

    [JsonProperty("airBurstStats")]
    public AirBurstStats AirBurstStats { get; set; }

    [JsonProperty("damageRanges")]
    public List<DamageRange> DamageRanges { get; set; }
}