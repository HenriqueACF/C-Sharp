using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationApp.Interface;
using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceService;
using Entities.Entities;

namespace ApplicationApp.OpenApp
{
    public class AppProduct: InterfaceProduct
    {
        IProduct _IProduct;
        IServiceProduct _IServiceProduct;
        public AppProduct(IProduct IProduct, IServiceProduct IServiceProduct)
        {
            _IProduct = IProduct;
            _IServiceProduct = IServiceProduct;
        }
        
        //METODOS CUSTOMIZADOS
        public async Task AddProduct(Product product)
        {
            await _IServiceProduct.AddProduct(product);
        }

        public async Task UpdateProduct(Product product)
        {
            await _IServiceProduct.UpdateProduct(product);
        }
        //------------------------------------------------------
        public async Task Add(Product Object)
        {
            await _IProduct.Add(Object);
        }

        public async Task Update(Product Object)
        {
            await _IProduct.Update(Object);
        }

        public async Task Delete(Product Object)
        {
            await _IProduct.Delete(Object);
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