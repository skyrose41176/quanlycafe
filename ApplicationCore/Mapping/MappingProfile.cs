using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using AutoMapper;

namespace ApplicationCore.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Account
            CreateMap<Account, AccountDto>();
            CreateMap<SaveAccountDto, Account>();
            CreateMap<AccountDto, SaveAccountDto>();
            //product
            CreateMap<Product, ProductDto>();
            CreateMap<SaveProductDto, Product>();
            CreateMap<ProductDto, SaveProductDto>();
            //category
            CreateMap<Category, CategoryDto>();
            CreateMap<SaveCategoryDto, Category>();
            CreateMap<CategoryDto, SaveCategoryDto>();
            //bill
            CreateMap<Bill, BillDto>();
            CreateMap<SaveBillDto, Bill>();
            CreateMap<BillDto, SaveBillDto>();
            //Infobill
            CreateMap<InfoBill, InfoBillDto>();
            CreateMap<SaveInfoBillDto, InfoBill>();
            CreateMap<InfoBillDto, SaveInfoBillDto>();
        }
    }
}