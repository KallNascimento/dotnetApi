using System.ComponentModel.DataAnnotations;

namespace MacorattiCurso.Domain;

public class Produto : Model
{
    [Required] [StringLength((300))] public string? Description { get; set; }
    [Required] public decimal? Price { get; set; }
    public float Stock { get; set; }
    public DateTime RegistrationDate { get; set; }
    public int CategoriaId { get; set; }
    public Categoria? Categoria { get; set; }
}