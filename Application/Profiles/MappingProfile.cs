using Application.DTOs.AdditionalIngedietDtos;
using Application.DTOs.AddressDtos;
using Application.DTOs.BaseIngredientDtos;
using Application.DTOs.OrdersDtos;
using Application.DTOs.PizzaDtos;
using Application.DTOs.SinglePizzaOrder;
using Application.DTOs.SinglePizzaOrderDtos;
using Application.DTOs.UsersDtos;
using AutoMapper;
using Pizzeria.Domain.Entities;
using Pizzeria.Domain.Identity;

namespace Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pizza, PizzaDto>().ReverseMap();
            CreateMap<Pizza, PizzaListDto>().ReverseMap();

            CreateMap<BaseIngredient, BaseIngredientDto>().ReverseMap();

            CreateMap<AdditionalIngredient, AdditionalIngredietDto>().ReverseMap();


            CreateMap<SinglePizzaOrder, SinglePizzaOrderCreateDto>().ReverseMap();

            CreateMap<SinglePizzaOrder, SinglePizzaOrderDto>().ReverseMap();

            CreateMap<Order, PlaceOrderDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Order, UsersOrdersDto>().ReverseMap();

            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<Address, CreateAddressDto>().ReverseMap();
            CreateMap<UserAddress, CreateAddressDto>().ReverseMap();
            

            CreateMap<User, RegisterUserDto>().ReverseMap();


        }
    }
}
