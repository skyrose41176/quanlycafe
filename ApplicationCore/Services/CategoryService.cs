using System.Collections.Generic;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Specifications;
using AutoMapper;

namespace ApplicationCore.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IEnumerable<int> GetCategory()
        {
            return _unitOfWork.Category.GetCategory();
        }
        public CategoryDto GetCategory(int id)
        {
            var category = _unitOfWork.Category.GetPro(id);
            return _mapper.Map<Category, CategoryDto>(category);
        }
        public CategoryDto GetCategory(string Username)
        {
            var category = _unitOfWork.Category.GetCa(Username);
            return _mapper.Map<Category, CategoryDto>(category);
        }
        public void CreateCategory(SaveCategoryDto saveCategoryDto)
        {
             var Category = _mapper.Map<SaveCategoryDto,Category>(saveCategoryDto);
            _unitOfWork.Category.Add(Category);
            _unitOfWork.Complete();
        }

        public void DeleteCategory(int category)
        {
            var Category = _unitOfWork.Category.GetPro(category);
            if (Category != null)
            {
                _unitOfWork.Category.Remove(Category);
                _unitOfWork.Complete();
            }
        }
        public IEnumerable<CategoryDto> GetCategorys(string searchString, string category, int pageIndex, int pageSize, out int count)
        {
            CategorySpecification CategoryFilterPaginated = new CategorySpecification(searchString, category, pageIndex, pageSize);
            CategorySpecification CategoryFilter = new CategorySpecification(searchString, category);

            var Category = _unitOfWork.Category.Find(CategoryFilterPaginated);
            count = _unitOfWork.Category.Count(CategoryFilter);

            return _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDto>>(Category);
        }

        public void UpdateCategory(SaveCategoryDto saveCategoryDto)
        {
            var Category = _unitOfWork.Category.GetPro(saveCategoryDto.CategoryId);
            if (Category == null) return;
            _mapper.Map<SaveCategoryDto,Category>(saveCategoryDto,Category);
            _unitOfWork.Complete();
        }
    }
}