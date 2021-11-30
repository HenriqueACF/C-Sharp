using System.Threading.Tasks;
using Domain.Interfaces.IServices;
using Entities.Entities;

namespace Domain.Services
{
    public interface ServiceProduct : IServiceProduct
    {
        public Task AddProduct
    }
}