using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationApp.Interfaces;
using Domain.Interfaces.IProduct;
using Domain.Interfaces.IServices;
using Entities.Entities;

namespace ApplicationApp.OpenApp
{
    public class AppProduct : InterfaceProduct
    {
        IProduct _IProduct;
        IServiceProduct _IServiceProduct;
        public AppProduct(IProduct IProduct, IServiceProduct IServiceProduct)
        {
            _IProduct = IProduct;
            _IServiceProduct = IServiceProduct;
        }
        
        //Metodos customizaveis
        public async Task AddProduct(Product product)
        {
            await _IServiceProduct.AddProduct(product);
        }

        public async Task UpdateProduct(Product product)
        {
            await _IServiceProduct.UpdateProduct(product);
        }
        
        public async Task Add(Product Objeto)
        {
            await _IProduct.Add(Objeto);
        }

        public async  Task Update(Product Objeto)
        {
            await _IProduct.Update(Objeto);
        }

        public async Task Delete(Product Objeto)
        {
            await _IProduct.Delete(Objeto);
        }

        public async Task<Product> GetEntityById(int Id)
        {
            return await _IProduct.GetEntityById(Id);
        }

        public async Task<List<Product>> List()
        {
            return await _IProduct.List();
        }

    }
}