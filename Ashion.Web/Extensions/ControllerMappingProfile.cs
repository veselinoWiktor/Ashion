using Ashion.Core.Models.Accessory;
using Ashion.Core.Models.Clothes;
using Ashion.Core.Models.Cosmetics;
using Ashion.Web.Areas.Admin.Models.Accessories;
using Ashion.Web.Areas.Admin.Models.Clothes;
using Ashion.Web.Areas.Admin.Models.Cosmetics;
using AutoMapper;

namespace Ashion.Web.Extensions
{
    public class ControllerMappingProfile : Profile
    {
        public ControllerMappingProfile()
        {
            this.CreateMap<AccessoryDetailsServiceModel, AccessoryFormModel>();
            this.CreateMap<AccessoryDetailsServiceModel, AccessoryDetailsViewModel>()
                .ForMember(a => a.ImageUrl, cfg => cfg.MapFrom(a => a.ImageUrls.First()));

            this.CreateMap<CosmeticDetailsServiceModel, CosmeticFormModel>();
            this.CreateMap<CosmeticDetailsServiceModel, CosmeticDetailsViewModel>()
                .ForMember(c => c.ImageUrl, cfg => cfg.MapFrom(c => c.ImageUrls.First()));

            this.CreateMap<ClothServiceModel, ClothFormModel>();
            this.CreateMap<ClothServiceModel, ClothDetailsViewModel>()
                .ForMember(c => c.ImageUrl, cfg => cfg.MapFrom(c => c.ImageUrls.First()));
        }
    }
}
