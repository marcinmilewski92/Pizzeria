using Application.DTOs.AdditionalIngedietDtos;
using Application.DTOs.BaseIngredientDtos;
using Application.DTOs.PizzaDtos;
using Application.DTOs.SinglePizzaOrder;
using Application.DTOs.SinglePizzaOrderDtos;
using AutoMapper;
using Pizzeria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                

        }
    }
}
