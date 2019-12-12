using System.Collections.Generic;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IProductService
    {
        ProductDto GetProduct(int id);
        IEnumerable<ProductDto> GetProducts(string searchString, int category, int pageIndex, int pageSize, out int count);
        IEnumerable<int> GetProduct();
        IEnumerable<ProductDto> GetProducts1(string searchString, string category, int pageIndex, int pageSize, out int count);

        IEnumerable<string> GetProduct1();
        void CreateProduct(SaveProductDto Product);
        void UpdateProduct(SaveProductDto Product);
        void DeleteProduct(int id);
    }
}