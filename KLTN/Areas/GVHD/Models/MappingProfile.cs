﻿using AutoMapper;
using Data.Enum;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLTN.Areas.GVHD.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DeTaiNghienCuu, DeTaiNghienCuuViewModel>()
                .ForMember(dest => dest.NgayLap, opt => opt.MapFrom(src => ((DateTime)src.NgayLap).ToString("dd/MM/yyyy")))
                .ForMember(dest => dest.MoTa, options => options.MapFrom(orderitem => orderitem.MoTa == null ? "" : orderitem.MoTa))
                .ForMember(dest => dest.SDT, options => options.MapFrom(orderitem => orderitem.IdgiangVienNavigation.Sdt))
                .ForMember(dest => dest.Email, options => options.MapFrom(orderitem => orderitem.IdgiangVienNavigation.Email))
                .ForMember(dest => dest.HoTenGVHD, options => options.MapFrom(orderitem => orderitem.IdgiangVienNavigation.Ho +" "+ orderitem.IdgiangVienNavigation.Ten))
                .ForMember(dest => dest.TenTep, options => options.MapFrom(orderitem => orderitem.TenTep == null ? "" : orderitem.TenTep));

            //CreateMap<DeTaiNghienCuu, DeTaiNghienCuuViewModel>().ReverseMap();
        }
    }
}
