using Ashion.Core.Models.Accessory;
using Ashion.Core.Models.Clothes;
using Ashion.Core.Models.Cosmetics;
using Ashion.Core.Models.ProductsShared;
using Ashion.Core.Models.Shop;
using Ashion.Infrastructure.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Core.Extensions
{
    public class ServiceMappingProfile : Profile
    {
        public ServiceMappingProfile()
        {
            //Shop Services

            this.CreateMap<Accessory, ShopProductServiceModel>()
                .ForMember(a => a.ImageUrl, cfg => cfg.MapFrom(a => a.Images.Select(i => i.Url).First()));

            this.CreateMap<Cosmetic, ShopProductServiceModel>()
                .ForMember(c => c.ImageUrl, cfg => cfg.MapFrom(c => c.Images.Select(i => i.Url).First()));

            this.CreateMap<Cloth, ShopProductServiceModel>()
                .ForMember(p => p.ImageUrl, cfg => cfg.MapFrom(c => c.Images.Select(i => i.Url).First()));

            //Category Maps
            this.CreateMap<Category, ProductCategoryServiceModel>();

            //AccessoryService
            this.CreateMap<Accessory, AccessoryDetailsServiceModel>()
                .ForMember(a => a.ImageUrls, cfg => cfg.MapFrom(a => a.Images.Select(i => i.Url).ToList()));

            //CosmeticService
            this.CreateMap<Cosmetic, CosmeticDetailsServiceModel>()
                .ForMember(c => c.ImageUrls, cfg => cfg.MapFrom(c => c.Images.Select(i => i.Url).ToList()));

            //ClothService
            this.CreateMap<Color, ClothColorServiceModel>();

            this.CreateMap<Size, ClothSizeServiceModel>();

            this.CreateMap<Cloth, ClothServiceModel>()
                .ForMember(c => c.ImageUrls, cfg => cfg.MapFrom(c => c.Images.Select(i => i.Url).ToList()))
                .ForMember(c => c.SizesIds, cfg => cfg.MapFrom(c => c.Sizes.Select(s => s.SizeId).ToList()));

            this.CreateMap<Cloth, ShopProductServiceModel>();
        }
    }
}
