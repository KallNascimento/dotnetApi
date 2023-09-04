using System.Collections.ObjectModel;

namespace MacorattiCurso.Domain;

public class Categoria : Model
{
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }

    public ICollection<Produto>? Produtos { get; set; } //propriedade de navegação
}