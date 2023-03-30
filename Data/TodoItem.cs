using System.Text.Json.Serialization;

// defines the TodoItem class, and associated JSON attributes
public class TodoItem
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("isComplete")]
    public bool IsComplete { get; set; } = false;
}