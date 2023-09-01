using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MacorattiCurso.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.Sql("Insert into Produtos(Name,Description,Price,ImageUrl,Stock,RegistrationDate,CategoriaId) values ('Coca-Trolla','Refrescante de Cola 350ml',2.45,'cocatrola.jpg',50,now(),1)");
           migrationBuilder.Sql("Insert into Produtos(Name,Description,Price,ImageUrl,Stock,RegistrationDate,CategoriaId) values ('Baurú','Lanche assado com queijo,presunto e tomate',1.60,'bauru.jpg',50,now(),2)");
           migrationBuilder.Sql("Insert into Produtos(Name,Description,Price,ImageUrl,Stock,RegistrationDate,CategoriaId) values ('Bebe-se','Refrescante de Cola 1l',7.45,'bebese.jpg',50,now(),3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Produtos");
        }
    }
}
