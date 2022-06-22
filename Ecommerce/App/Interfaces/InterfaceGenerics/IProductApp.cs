using Entities.Entities;

namespace App.Interfaces.InterfaceGenerics;

public interface IProductApp: IGenericApp<Product>
{
    Task AddProduct(Product product);
    Task UpdateProduct(Product product);
}