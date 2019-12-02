using AutoMapper;
using MUGPeru.API.Models;

namespace MUGPeru.API.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, Models.DTOs.Customer>();
        }
    }
}
