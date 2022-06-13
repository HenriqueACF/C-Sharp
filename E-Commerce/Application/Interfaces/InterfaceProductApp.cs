using System.Threading.Tasks;
using Entities.Entities;

namespace Application.Interfaces
{
    public interface InterfaceProductApp: InterfaceGenericApp<Product>
    {
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
    }
}