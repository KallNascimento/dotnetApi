using MacorattiCurso.Context;
using MacorattiCurso.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MacorattiCurso.Controllers;

[Route("[controller]")]
[ApiController]
public class CategoriasController : Controller
{
    public readonly AppDbContext _Context;

    public CategoriasController(AppDbContext context)
    {
        _Context = context;
    }

    [HttpDelete("{id:int}")]
    public ActionResult Delete(int id)
    {
        var categoria = _Context.Categorias.FirstOrDefault(c => c.Id == id);
        if (categoria is null) return NotFound("Esta categoria não foi encontrada");
        _Context.Categorias.Remove(categoria);
        _Context.SaveChanges();
        return Ok(categoria);
    }

    [HttpGet]
    public ActionResult<IEnumerable<Categoria>> Get()

    {
        try
        {
            return _Context.Categorias.AsNoTracking().ToList();
        }
        catch (Exception e)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao buscar as categorias.");
        }
    }

    [HttpGet("produtos")]
    public ActionResult<IEnumerable<Categoria>> GetCategoriasProdutos()
    {
        return _Context.Categorias.AsNoTracking().Take(10).Include(p => p.Produtos).ToList();
    }

    [HttpGet("{id:int}", Name = "GetCategoria")]
    public ActionResult<Categoria> Get(int id)
    {
        var categoria = _Context.Categorias.AsNoTracking().FirstOrDefault(c => c.Id == id);
        if (categoria is null)
        {
            return NotFound($"Categoria com o id: {id} não encontrada");
        }

        return categoria;
    }

    [HttpPost]
    public ActionResult Post(Categoria? categoria)
    {
        if (categoria is null) return BadRequest("Não foi possivel inserir os dados");
        _Context.Categorias.Add(categoria);
        _Context.SaveChanges();

        return new CreatedAtRouteResult("GetCategoria", new { id = categoria.Id }, categoria);
    }

    [HttpPut]
    public ActionResult Put(int id, Categoria categoria)
    {
        if (id != categoria.Id) return new BadRequestResult();
        _Context.Entry(categoria).State = EntityState.Modified;
        _Context.SaveChanges();
        return Ok(categoria);
    }
}