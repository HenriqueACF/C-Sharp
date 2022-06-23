using Domain.Interface.InterfaceProduct;
using Entities.Entities;
using Infra.Repository.Generics;

namespace Infra.Repository.Repositories;

public class RepositoryProduct: RepositoryGeneric<Product>, IProduct
{
    
}