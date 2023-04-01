using System.Text.Json.Serialization;

// defines the TodoItem class, and associated JSON attributes
public class TodoItem
{
    public long Id { get; set; }

    public string? Name { get; set; }
    
    public bool IsComplete { get; set; } = false;
}