namespace TazosStore.Client.Models;

public class Tazo
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Material { get; set; }
    public required string SerialNumber { get; set; }
    public required string Theme { get; set; }
    public required string Size { get; set; }
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }

}