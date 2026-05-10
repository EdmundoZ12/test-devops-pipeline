using AutoMapper;
using TestDevops.Models;
using TestDevops.Models.Dto;

namespace TestDevops.Mapping;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Category, CreateCategoryDto>().ReverseMap();
    }
}