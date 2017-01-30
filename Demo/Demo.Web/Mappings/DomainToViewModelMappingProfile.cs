using AutoMapper;
using Demo.Model.Models;
using Demo.Web.ViewModel;

namespace Demo.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Category, CategoryViewModel>();
            Mapper.CreateMap<Gadget, GadgetViewModel>();
        }
    }

}