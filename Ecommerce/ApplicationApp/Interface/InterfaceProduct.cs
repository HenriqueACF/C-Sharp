using System.Threading.Tasks;
using Entities.Entities;

namespace ApplicationApp.Interface
{
    public interface InterfaceProduct: InterfaceGenerics<Product>
    {
        //METODOS CUSTOMIZADOS
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
    }
}