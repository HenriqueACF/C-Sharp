using VShop.ProductApi.DTOs;

namespace VShop.ProductApi.Service.Category;

public interface ICategoryService
{
    Task<IEnumerable<CategoryDTO>> GetCategories();
    Task<IEnumerable<CategoryDTO>> GetCategoriesProducts();
    Task<CategoryDTO> GetCategoryById(int id);
    Task AddCategory(CategoryDTO category);
    Task UpdateCategory(CategoryDTO category);
    Task RemoveCategory(int id);
}