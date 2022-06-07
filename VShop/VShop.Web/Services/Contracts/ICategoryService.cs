using VShop.Web.Models;

namespace VShop.Web.Services;

public interface ICategoryService
{
    Task<IEnumerable<CategoryViewModel>> GetAllCategories();
}