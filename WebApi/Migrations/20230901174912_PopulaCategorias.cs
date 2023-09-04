using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable   

namespace MacorattiCurso.Migrations
{
  
    public partial class PopulaCategorias : Migration
    {
   
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Categorias (Name,ImageUrl) Values ('Comidas','comidas.jpg')");
            migrationBuilder.Sql("Insert into  Categorias (Name,ImageUrl) Values ('Lanches','lanches.jpg')");
            migrationBuilder.Sql("Insert into  Categorias (Name,ImageUrl) Values ('Sobremesas','sobremesas.jpg')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categorias");
        }
    }
}
