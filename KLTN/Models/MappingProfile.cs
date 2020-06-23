﻿using AutoMapper;
using Data.Enum;
using Data.Models;
using KLTN.Areas.Admin.Models;
using KLTN.Areas.GVHD.Models;
using KLTN.Areas.SinhVien.Models;
using System;


namespace KLTN.Models
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
            
            CreateMap<Data.Models.SinhVien, SinhVienViewModel>();

            CreateMap<BaoCaoTienDo, BaoCaoTienDoViewModel>()
                .ForMember(dest => dest.NgayNop, opt => opt.MapFrom(src => ((DateTime)src.NgayNop).ToString("dd/MM/yyyy")))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status == (int)StatusBaoCao.DaNop ? "Đã nộp" : "Trễ hạn"));

            CreateMap<YeuCauPheDuyet, YeuCauPheDuyetViewModel>()
                .ForMember(dest => dest.TenDeTai, opt => opt.MapFrom(src => src.IddeTaiNavigation.TenDeTai))
                .ForMember(dest => dest.TenGiangVien, opt => opt.MapFrom(src => src.IddeTaiNavigation.IdgiangVienNavigation.Ho +" "+ src.IddeTaiNavigation.IdgiangVienNavigation.Ten))
                .ForMember(dest => dest.NgayTao, opt => opt.MapFrom(src => ((DateTime)src.NgayTao).ToString("dd/MM/yyyy")))
                //.ForMember(dest => dest.NgayDuyet, opt => opt.MapFrom(src => ((DateTime)src.NgayDuyet.Value).ToString("dd/MM/yyyy")))
                .ForMember(dest => dest.IdNguoiDuyet, opt => opt.MapFrom(src => src.IdNguoiDuyet.ToString()))
                .ForMember(dest => dest.LoaiYeuCau, opt => opt.MapFrom(src => src.LoaiYeuCau == (int)LoaiYeuCauPheDuyet.ChinhSua ? "Chỉnh sửa" : "Xóa"))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status == (int)StatusYeuCauPheDuyet.ChuaXuLy ? "Chưa xử lý" : src.Status == (int)StatusYeuCauPheDuyet.DaDuyet ? "Đã duyệt" : "Hủy yêu cầu"));
        }
    }
}
