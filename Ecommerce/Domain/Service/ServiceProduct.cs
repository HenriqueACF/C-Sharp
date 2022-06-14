using System.Threading.Tasks;
using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceService;
using Entities.Entities;

namespace Domain.Service
{
    public class ServiceProduct: IServiceProduct
    {
        private readonly IProduct _IProduct;    
        public ServiceProduct(IProduct IProduct)
        {
            _IProduct = IProduct;
        }
        
        public async Task AddProduct(Product product)
        {
            var validaNome = product.ValidarPropriedadeString(product.Nome, "Nome");
            var validaValor = product.ValidarPropriedadeDecimal(product.Valor, "Valor");

            if (validaNome && validaValor)
            {
                product.Estado = true;
                await _IProduct.Add(product);
            }
        }

        public async Task UpdateProduct(Product product)
        {
            var validaNome = product.ValidarPropriedadeString(product.Nome, "Nome");
            var validaValor = product.ValidarPropriedadeDecimal(product.Valor, "Valor");

            if (validaNome && validaValor)
            {
                await _IProduct.Update(product);
            }
        }
    }
}