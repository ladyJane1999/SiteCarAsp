using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SiteCarAsp.Models;
using SiteCarAsp.ViewModels;
using SiteCarAsp.ViewModels.Request;

namespace SiteCarAsp.Services
{
    /// <summary>
    /// Настройка маппера. Маппер умеет конвертировать 1 класс в другой относительно данных. 
    /// </summary>
    public static class IMapperExtensions
    {
        public static void AddMapper(this IServiceCollection services)
        {
            services.AddSingleton<IMapper, Mapper>(x =>
            {
                MapperConfiguration mapperConfiguration = new MapperConfiguration(x =>
                {
                    x.CreateMap<CreateCreditRequest, CreditsViewModel>();
                    x.CreateMap<CreateTestDriveRequest, TestDriveViewModel>();

                    x.CreateMap<CreateCreditRequest, Credit>();
                    x.CreateMap<CreateTestDriveRequest, TestDrive>();
                });
                return new Mapper(mapperConfiguration);
            });
        }
    }
}
