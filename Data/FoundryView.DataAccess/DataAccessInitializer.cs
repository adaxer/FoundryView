using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using FoundryView.Data.DataAccess.Models;
using FoundryView.UseCases.Contracts.Interfaces;
using FoundryView.UseCases.Contracts.Models;
using Prism.Ioc;
using Prism.Modularity;

namespace FoundryView.Data.DataAccess
{
    public class DataAccessInitializer : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IRepository<Category>,CategoryRepository>();
            containerRegistry.Register(typeof(IPersistenceProvider<>), typeof(GenericPersistenceProvider<>));
            containerRegistry.RegisterInstance<IMapper>(new Mapper(GetMapperConfiguration()));
        }

        private IConfigurationProvider GetMapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Categories, Category>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CategoryId))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CategoryName));
            });
            config.AssertConfigurationIsValid();
            return config;
        }
    }
}
