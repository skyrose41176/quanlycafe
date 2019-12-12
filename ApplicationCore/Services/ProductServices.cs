using System.Collections.Generic;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Specifications;
using AutoMapper;

namespace ApplicationCore.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IEnumerable<int> GetProduct()
        {
            return _unitOfWork.Product.GetProduct();
        }
        public IEnumerable<string> GetProduct1()
        {
            return _unitOfWork.Product.GetProduct1();
        }
        public void CreateProduct(SaveProductDto saveProductDto)
        {
            var Product = _mapper.Map<SaveProductDto,Product>(saveProductDto);
            _unitOfWork.Product.Add(Product);
            _unitOfWork.Complete();
        }
        public void DeleteProduct(int id)
        {
            var Product = _unitOfWork.Product.GetPro(id);
            if (Product != null)
            {
                _unitOfWork.Product.Remove(Product);
                _unitOfWork.Complete();
            }
        }
        public ProductDto GetProduct(int id)
        {
            var Product = _unitOfWork.Product.GetPro(id);
            return _mapper.Map<Product, ProductDto>(Product);
        }
        public IEnumerable<ProductDto> GetProducts(string searchString, int category, int pageIndex, int pageSize, out int count)
        {
            ProductSpecification ProductFilterPaginated = new ProductSpecification(searchString, category, pageIndex, pageSize);
            ProductSpecification ProductFilter = new ProductSpecification(searchString, category);

            var Product = _unitOfWork.Product.Find(ProductFilterPaginated);
            count = _unitOfWork.Product.Count(ProductFilter);

            return _mapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(Product);

        } 
        public IEnumerable<ProductDto> GetProducts1(string searchString, string category, int pageIndex, int pageSize, out int count)
        {
            ProductSpecification ProductFilterPaginated = new ProductSpecification(searchString, category, pageIndex, pageSize);
            ProductSpecification ProductFilter = new ProductSpecification(searchString, category);

            var Product = _unitOfWork.Product.Find(ProductFilterPaginated);
            count = _unitOfWork.Product.Count(ProductFilter);

            return _mapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(Product);

        }
        public void UpdateProduct(SaveProductDto saveProductDto)
        {
            var Product = _unitOfWork.Product.GetPro(saveProductDto.Id);
            if (Product == null) return;
            _mapper.Map<SaveProductDto,Product>(saveProductDto,Product);
            _unitOfWork.Complete();
        }
    }
}