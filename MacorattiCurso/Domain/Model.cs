using System.ComponentModel.DataAnnotations;

namespace MacorattiCurso.Domain;

public class Model
{
    [Key] public int Id { get; set; }
    [Required] [MaxLength(80)] public string? Name { get; set; }
    public string? ImageUrl { get; set; }
}