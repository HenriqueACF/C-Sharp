namespace VShop.ProductApi.Repositories.Product;

public interface IProductRepository
{
    //TODO -> Nao quer importar Product
    Task<IEnumerable<Models.Product>> GetAll();
    Task<Models.Product> GetById(int id);
    Task<Models.Product> Create(Models.Product product);
    Task<Models.Product> Update(Models.Product product);
    Task<Models.Product> Delete(int id);
}