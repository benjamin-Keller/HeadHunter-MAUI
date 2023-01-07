using Newtonsoft.Json;

namespace HeadHunter.Models.Events;

public class EventsModel
{
    [JsonProperty("status")]
    public int Status { get; set; }

    [JsonProperty("data")]
    public List<EventData> Data { get; set; }
}

public class EventData
{
    [JsonProperty("uuid")]
    public string Uuid { get; set; }

    [JsonProperty("displayName")]
    public string DisplayName { get; set; }

    [JsonProperty("shortDisplayName")]
    public string ShortDisplayName { get; set; }

    [JsonProperty("startTime")]
    public DateTime StartTime { get; set; }

    [JsonProperty("endTime")]
    public DateTime EndTime { get; set; }

    [JsonProperty("assetPath")]
    public string AssetPath { get; set; }
}