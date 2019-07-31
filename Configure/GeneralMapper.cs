using AutoMapper;
using CP_Preprocessing.Entities;

namespace CP_Preprocessing.Configure
{
    public class GeneralMapper:Profile
    {
        public GeneralMapper()
        {
            CreateMap<U_CP, School>()
                .ForMember(dest => dest.name, opt => opt.MapFrom(source => source.Uname))
                .ForMember(dest => dest.AverageScore, opt => opt.MapFrom(source => source.MinScore))
                .ForMember(dest => dest.AverageSalary, opt => opt.MapFrom(source => source.SalaryInK))
                .ForMember(dest => dest.ScorePercentile, opt => opt.MapFrom(source => source.P))
                .ForMember(dest => dest.SalaryPercentile, opt => opt.MapFrom(source => source.C))
                .ForMember(dest => dest.CPValue, opt => opt.MapFrom(source => source.CP));
        }
    }
}
