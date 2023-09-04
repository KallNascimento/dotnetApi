using MacorattiCurso.Context;
using MacorattiCurso.Domain;
using Microsoft.AspNetCore.Mvc;

namespace MacorattiCurso.Controllers;

[Route("[controller]")]
[ApiController]
public class ProdutosController : Controller
{
    public readonly AppDbContext _Context;

    public ProdutosController(AppDbContext context)
    {
        _Context = context;
    }

    [HttpGet("{id:int}", Name = "GetProduto")]
    public ActionResult<Produto> Get(int id)
    {
        var produto = _Context.Produtos.FirstOrDefault(p => p.Id == id);
        if (produto is null) return NotFound("Produto não foi encontrado");

        return produto;
    }

    [HttpPost]
    public ActionResult Post(Produto produto)
    {
        if (produto is null) return BadRequest();
        _Context.Produtos.Add(produto);
        _Context.SaveChanges();

        return new CreatedAtRouteResult("GetProduto", new { id = produto.Id }, produto);
    }
}