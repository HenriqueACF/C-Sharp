using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Interfaces.InterfaceProducts;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;

namespace Application.OpenApp
{
    public class AppProduct: InterfaceProductApp
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
            await _IServiceProduct.AddProduct(product);
        }
        //----------------------------------------------
        
        public async Task Add(Product Objeto)
        {
            await _IProduct.Add(Objeto);
        }
        
        public async Task Update(Product Objeto)
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