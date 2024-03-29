﻿using AutoMapper;
using OnlineStore.Model.DTO;
using OnlineStore.Website.Areas.Account.ViewModels;
using OnlineStore.Website.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Website.Mappings
{
    public class ModelToViewModelMappingProfile : Profile
    {
        public override string ProfileName => "ModelToViewModelMappingProfile";

        public ModelToViewModelMappingProfile()
        {
            CreateMap<CategoryDTO, CategoryViewModel>();
            CreateMap<ProductDTO, ProductViewModel>();
            CreateMap<ArticleDTO, ArticleViewModel>();
            CreateMap<ProviderDTO, ProviderViewModel>();
            CreateMap<LanguageDTO, LanguageViewModel>();
            CreateMap<ShopContactDTO, ShopContactViewModel>();
            CreateMap<StockDTO, StockViewModel>();
        }
    }
}
