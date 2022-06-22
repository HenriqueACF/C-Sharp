using Entities.Entities;

namespace Domain.Interface.InterfaceService;

public interface IServiceProduct
{
    Task AddProduct(Product product);
    Task UpdateProduct(Product product);
}