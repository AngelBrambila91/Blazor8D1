using System.ComponentModel.DataAnnotations;

namespace TazosStore.Server.Models;

public class Tazo
{
    public int Id { get; set; }
    // DataAnnotation
    [Required][StringLength (50)]
    public required string Name { get; set; }
    [Required][StringLength (20)]
    public required string Material { get; set; }
    [Required][StringLength (20)]
    public required string SerialNumber { get; set; }
    [Required][StringLength (20)]
    public required string Theme { get; set; }
    [Required]
    public required string Size { get; set; }
    [Required][Range (1, 100)]
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }

}