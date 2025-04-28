using System.Text.Json.Serialization;

public class SharePointListResponse
{
    [JsonPropertyName("value")]
    public List<ContentSchedulerItem> Value { get; set; }
}

public class ContentSchedulerItem
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }


}