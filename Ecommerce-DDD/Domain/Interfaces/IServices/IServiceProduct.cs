using System.Threading.Tasks;
using Entities.Entities;

namespace Domain.Interfaces.IServices
{
    public interface IServiceProduct
    {
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
    }
}