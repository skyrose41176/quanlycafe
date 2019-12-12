using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using GoCafe.Interfaces;
using GoCafe.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoCafe.Services
{
    public class ProductIndexVmService : IProductIndexVmService
    {
        private int pageSize = 5;
        private readonly IProductService _service;

        public ProductIndexVmService(IProductService ProductService)
        {
            _service = ProductService;
        }

        public ProductIndexVm GetProductListVm(string searchString,int category, int pageIndex)
        {
            int count;
            var Products = _service.GetProducts(searchString,category, pageIndex, pageSize, out count);
            var genres = _service.GetProduct();
            return new ProductIndexVm
            {
                Genres = new SelectList(genres),
                Products = new PaginatedList<ProductDto>(Products, pageIndex, pageSize, count)
            };
        }
        public ProductIndexVm GetProductListVm1(string searchString,string category, int pageIndex)
        {
            int count;
            var Products = _service.GetProducts1(searchString,category, pageIndex, pageSize, out count);
            var genres1 = _service.GetProduct1();
            return new ProductIndexVm
            {
                Genres1 = new SelectList(genres1),
                Products = new PaginatedList<ProductDto>(Products, pageIndex, pageSize, count)
            };
        }
    }
}