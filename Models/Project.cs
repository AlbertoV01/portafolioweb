public class Project
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public string? ImageUrl { get; set; } 
    public required List<string>  Technologies { get; set; }
    public string? Link { get; set; }
}