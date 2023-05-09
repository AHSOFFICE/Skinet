
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.Identity;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {

            CreateMap<Product,ProductToReturnDto>()
            .ForMember(d=> d.ProductBrand , o=> o.MapFrom(s => s.ProductBrand.Name))
            .ForMember(d=> d.ProductType , o=> o.MapFrom(s => s.ProductType.Name))
            .ForMember(d=> d.PictureUrl , o=> o.MapFrom<ProductUrlResolver>());
            CreateMap<Address,AddressDto>().ReverseMap();
<<<<<<< HEAD
=======
            CreateMap<CustomerBasketDto , CustomerBasket>();
            CreateMap<BasketItemDto, Basketitem>();
>>>>>>> 647186f6de55babfb6ca38d31d673b920360f367
        }

       
    }
}