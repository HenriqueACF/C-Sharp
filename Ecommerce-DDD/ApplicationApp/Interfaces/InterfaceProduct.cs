using System.Threading.Tasks;
using Entities.Entities;

namespace ApplicationApp.Interfaces
{
    public interface InterfaceProduct : InterfacegenericApp<Product>
    {
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
    }
}