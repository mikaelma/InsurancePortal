using AutoMapper;
using Domain.Insurance;
using Application.ViewModels.InsuranceViewModels;
using Domain;

namespace Application.ViewModels.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Insurance, InsuranceViewModel>()
                .ForMember(i=>i.CustomerId, map => map.MapFrom(i => i.Customer.Id));
        }
    }
}