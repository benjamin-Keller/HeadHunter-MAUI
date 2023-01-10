using Newtonsoft.Json;

namespace HeadHunter.Models.Weapons;

public class GridPosition
{
    [JsonProperty("row")]
    public int Row { get; set; }

    [JsonProperty("column")]
    public int Column { get; set; }
}
