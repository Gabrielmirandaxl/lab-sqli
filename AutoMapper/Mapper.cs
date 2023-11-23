using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using lab_sqli.Dtos;
using lab_sqli.Models;

namespace lab_sqli.AutoMapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<Product, ProductDto>();
        }
    }
}