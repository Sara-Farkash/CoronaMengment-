using AutoMapper;
using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
             CreateMap<User1Dto,  User1>();
            CreateMap<User1, User1Dto>();

            CreateMap<IllDto, Ill>();
            CreateMap<Ill, IllDto>();

            CreateMap<VaccinationDto, Vaccination>();
            CreateMap<Vaccination, VaccinationDto>();


   




        }
    }
}
