namespace TodoApi.Models;

public class Todoitem
{
    public int Id  { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public bool IsCompleated { get; set; }
    public DateTime CreatedAT { get; set; }
}

