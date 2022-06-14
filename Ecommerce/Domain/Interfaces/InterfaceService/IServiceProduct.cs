using System.Threading.Tasks;
using Entities.Entities;

namespace Domain.Interfaces.InterfaceService
{
    public interface IServiceProduct
    {
        //METODOS CUSTOMIZADOS
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
    }
}