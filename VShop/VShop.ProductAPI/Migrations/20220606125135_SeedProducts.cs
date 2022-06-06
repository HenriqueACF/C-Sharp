using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VShop.ProductAPI.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Products(Name, Price, Description, Stock, ImageUrl, CategoryId)" +
                   "Values('Produto1', 8.99, 'Produto1', 10, 'produto1.jpg', 1)");
            
            mb.Sql("Insert into Products(Name, Price, Description, Stock, ImageUrl, CategoryId)" +
                   "Values('Produto2', 9.29, 'Produto2', 10, 'produto2.jpg', 1)");
            
            mb.Sql("Insert into Products(Name, Price, Description, Stock, ImageUrl, CategoryId)" +
                   "Values('Material1', 48.99, 'Material1', 10, 'material1.jpg', 2)");
            
            mb.Sql("Insert into Products(Name, Price, Description, Stock, ImageUrl, CategoryId)" +
                   "Values('Material2', 86.25, 'Material2', 10, 'material2.jpg', 2)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("delete from Products");
        }
    }
}
