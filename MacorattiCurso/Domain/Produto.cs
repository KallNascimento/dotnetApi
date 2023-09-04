using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace MacorattiCurso.Domain;

public class Produto : Model
{
    [Required] [StringLength((300))] public string? Description { get; set; }
    [Required] public decimal? Price { get; set; }
    public float Stock { get; set; }
    public DateTime RegistrationDate { get; set; }
    public int CategoriaId { get; set; } //Propriedade de navegação
    [JsonIgnore]
    public Categoria? Categoria { get; set; } //Propriedade de navegação
}