using Domain.Interfaces.IProduct;
using Entities.Entities;
using Infra.Repository.Generics;

namespace Infra.Repository.Repositories
{
    public class RepositoryProduct:RepositoryGenerics<Product>, IProduct
    {
        
    }
}