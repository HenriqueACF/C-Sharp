using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VShop.ProductApi.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Products" +
                   "(Name," +
                   " Price," +
                   " Description," +
                   " Stock," +
                   " ImageURL," +
                   " CategoryId)" +
                   " VALUES(" +
                   "'Caderno'," +
                   " 7.55," +
                   "'Caderno'," +
                   " 10," +
                   "'Caderno.jpg'" +
                   ",1)");
            
            mb.Sql("Insert into Products" +
                   "(Name," +
                   " Price," +
                   " Description," +
                   " Stock," +
                   " ImageURL," +
                   " CategoryId)" +
                   " VALUES(" +
                   "'Lapis'," +
                   " 8.5," +
                   "'Lapis'," +
                   " 100," +
                   "'Lapis.jpg'" +
                   ",1)");
            
            mb.Sql("Insert into Products" +
                   "(Name," +
                   " Price," +
                   " Description," +
                   " Stock," +
                   " ImageURL," +
                   " CategoryId)" +
                   " VALUES(" +
                   "'Clips'," +
                   " 1.8," +
                   "'Clips para papel'," +
                   " 200," +
                   "'clips.jpg'" +
                   ",2)");
        }
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Products");
        }
    }
}
