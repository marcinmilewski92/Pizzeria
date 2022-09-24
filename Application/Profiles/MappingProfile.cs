using Application.DTOs.AdditionalIngedietDtos;
using Application.DTOs.AddressDtos;
using Application.DTOs.BaseIngredientDtos;
using Application.DTOs.Orders;
using Application.DTOs.PizzaDtos;
using Application.DTOs.SinglePizzaOrder;
using Application.DTOs.SinglePizzaOrderDtos;
using AutoMapper;
using Pizzeria.Domain.Entities;

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

            CreateMap<Address, AddressDto>().ReverseMap();




        }
    }
}
