using System;
using System.Threading.Tasks;
using Domain.Interfaces.IProduct;
using Domain.Interfaces.IServices;
using Entities.Entities;

namespace Domain.Services
{
    public class IServicesProduct : IServiceProduct
    {
        private readonly IProduct _IProduct;

        public IServicesProduct(IProduct IProduct)
        {
            _IProduct = IProduct;
        }

        public  async Task AddProduct(Product product)
        {
            var validaNome = product.ValidarPropriedadeString(product.NomePropriedade, "Nome");
            var validaValor = product.ValidarPropriedadeDecimal(product.Valor, "Valor");

            if (validaNome && validaValor)
            {
                product.Estado = true;
                await _IProduct.Add(product);
            }
        }

        public async Task UpdateProduct(Product product)
        {
            var validaNome = product.ValidarPropriedadeString(product.NomePropriedade, "Nome");
            var validaValor = product.ValidarPropriedadeDecimal(product.Valor, "Valor");

            if (validaNome && validaValor)
            {
                await _IProduct.Update(product);
            }
        }
    }
}