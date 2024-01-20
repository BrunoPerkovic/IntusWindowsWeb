using IntusWindowsAPI.BL.Data;
using IntusWindowsAPI.BL.Dto;
using IntusWindowsWeb.Models;

namespace IntusWindowsWeb.Services;

public class ProductService : IProductService
{
    public async Task<ProductData> CreateProductAsync(ProductDto productDto)
    {
        throw new NotImplementedException();
    }

    public async Task<ProductData> GetProductAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ProductData>> GetProductsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<List<ProductData>> GetProductsByTypeAsync(ProductType type)
    {
        throw new NotImplementedException();
    }

    public async Task<ProductData> UpdateProductAsync(int id, ProductDto productDto)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteProductAsync(int id)
    {
        throw new NotImplementedException();
    }
}