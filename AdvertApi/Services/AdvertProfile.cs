using AdvertApi.Models;
using AutoMapper;

namespace AdvertApi.Services
{
    public class AdvertProfile : Profile 
    {
        //GOING TO MAP AFTER ATTRIBUTE NAME
        public AdvertProfile()
        {
            CreateMap<AdvertModel, DynamoDbAdvertStorage>();
        }
    }
}
