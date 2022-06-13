using Domain.Interfaces.InterfaceProducts;
using Entities.Entities;
using Infra.Repository.Generics;

namespace Infra.Repository.Repositories
{
    public class RepositoryProduct: RepositoryGenerics<Product>, IProduct
    {
        
    }
}