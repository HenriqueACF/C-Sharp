using VShop.Web.Models;

namespace VShop.Web.Services.Contracts;

public interface ICategoryService
{
    Task<IEnumerable<CategoryVM>> GetAllCategories(string token);
}