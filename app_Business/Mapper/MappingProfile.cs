using app_DataAccess;
using app_Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
			CreateMap<Product, ProductDTO>().ReverseMap();
			CreateMap<ProductPrice, ProductPriceDTO>().ReverseMap();
		}
    }
}
