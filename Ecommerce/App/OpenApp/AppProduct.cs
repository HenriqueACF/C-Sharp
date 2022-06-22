using App.Interfaces.InterfaceGenerics;
using Domain.Interface.InterfaceProduct;
using Domain.Interface.InterfaceService;
using Entities.Entities;

namespace App.OpenApp;

public class AppProduct: IProductApp
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
    //-------------------
    public async Task Add(Product Obj)
    {
        await _IProduct.Add(Obj);
    }

    public async Task Update(Product Obj)
    {
        await _IProduct.Update(Obj);
    }

    public async Task Delete(Product Obj)
    {
        await _IProduct.Delete(Obj);
    }

    public async Task<Product> GetEntityById(int id)
    {
       return await _IProduct.GetEntityById(id);
    }

    public async Task<List<Product>> List()
    {
        return await _IProduct.List();
    }

   
}