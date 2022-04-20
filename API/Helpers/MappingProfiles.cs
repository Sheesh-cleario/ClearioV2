﻿using API.DTOs;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CleaningObject, CleaningObjectShortInfo>()
                .ForMember(d => d.Name, o => o.MapFrom(s => s.ObjectName))
                .ForMember(d => d.ObjectId, o => o.MapFrom(s => s.CleaningObjectId))
                .ForMember(d => d.Location, o => o.MapFrom(s => s.ObjectLocation));
            //CreateMap<Order, OrderShortInfo>()
            //    .ForMember(d => d.OrderId, o => o.MapFrom(s => s.OrderId))
            //    .ForMember(d => d.CustomerNumber, o => o.MapFrom(s => s.CustomerName))
            //    .ForMember(d => d.ObjectAddress, o => o.MapFrom(s => s.OrderObjectDetails.ObjectAddres))
            //    .ForMember(d => d.Time, o => o.MapFrom(x => x.OrderObjectDetails.CleaningDate))
            //    .ForMember(d => d.Status, o => o.MapFrom(x => x.OrderDescription.Status.ToString()))
            //    .ForMember(d => d.Price, o => o.MapFrom(x => x.Price));
        }
    }
}
