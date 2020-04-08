using AutoMapper;
using FluentValidationApp.Web.DTOs;
using FluentValidationApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.Mapping
{
    public class EventDateProfile : Profile
    {
        public EventDateProfile()
        {
            CreateMap<EventDateDto, EventDate>().ForMember(x => x.Date, opt => opt.MapFrom(x => new DateTime(x.Year, x.Month, x.Day)));

            CreateMap<EventDate, EventDateDto>().ForMember(x => x.Year, opt => opt.MapFrom(x => x.Date.Year))
                .ForMember(x => x.Month, opt => opt.MapFrom(x => x.Date.Month))
                .ForMember(x => x.Day, opt => opt.MapFrom(x => x.Date.Day));
        }
    }
}