using AutoMapper;
using VShop.ProductApi.DTOs;
using VShop.ProductApi.Repositories.Product;

namespace VShop.ProductApi.Service.Product;

public class ProductService: IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ProductDTO>> GetProducts()
    {
        var productEntity = await _productRepository.GetAll();
        return _mapper.Map<IEnumerable<ProductDTO>>(productEntity);
    }

    public async Task<ProductDTO> GetProductById(int id)
    {
        var productEntity = await _productRepository.GetById(id);
        return _mapper.Map<ProductDTO>(productEntity);
    }
    
    public async Task AddProduct(ProductDTO productDto)
    {
        // TODO -> Não encontrou o namespace de product
        var productEntity = _mapper.Map<Models.Product>(productDto);
        await _productRepository.Create(productEntity);
        productDto.Id = productEntity.Id;
    }

    public async Task UpdateProduct(ProductDTO productDto)
    {
        var productEntity = _mapper.Map<Models.Product>(productDto);
        await _productRepository.Update(productEntity);
    }

    public async Task DeleteProduct(int id)
    {
        var productEntity = await  _productRepository.GetById(id);
        await _productRepository.Delete(productEntity.Id);
    }
}