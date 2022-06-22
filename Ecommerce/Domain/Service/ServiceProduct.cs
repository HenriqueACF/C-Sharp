using Domain.Interface.InterfaceProduct;
using Domain.Interface.InterfaceService;
using Entities.Entities;

namespace Domain.Service;

public class ServiceProduct:IServiceProduct
{
    private readonly IProduct _IProduct;
    public ServiceProduct(IProduct IProduct)
    {
        _IProduct = IProduct;
    }
    public async Task AddProduct(Product product)
    {
        var validaNome = product.ValidarPropString(product.Name, "Name");
        var validaValor = product.ValidarPropDecimal(product.Value, "Value");

        if (validaNome && validaValor)
        {
            product.Estado = true;
            await _IProduct.Add(product);
        }
        
    }

    public async Task UpdateProduct(Product product)
    {
        var validaNome = product.ValidarPropString(product.Name,"Name");
        var validaValor = product.ValidarPropDecimal(product.Value, "Value");

        if (validaNome && validaValor)
            await _IProduct.Update(product);
    }
}