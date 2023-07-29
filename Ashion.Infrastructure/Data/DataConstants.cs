using Ashion.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Infrastructure.Data
{
    public static class DataConstants
    {
        public static class Accessory
        {

        }

        public static class Cateogry
        {
            public const int MaxNameLength = 20;
            public const int MinNameLength = 1;
        }

        public static class Color
        {
            public const int MaxNameLength = 15;
            public const int MinNameLength = 1;

        }

        public static class Cosmetic
        {
            public const int MaxLabelLength = 10;
            public const int MinLabelLength = 1;


            public const int MaxIngredintsLength = 600;
            public const int MinIngredintsLength = 20;
        }

        public static class Image
        {
            public const int MaxUrlLength = 500;
            public const int MinUrlLength = 1;
        }

        public static class Product
        {
            public const int MaxNameLength = 30;
            public const int MinNameLength = 3;

            public const int MaxBrandLength = 25;
            public const int MinBrandLength = 2;

            public const double MaxPriceRange = 1500.00;
            public const double MinPriceRange = 0.00;

            public const int MaxShortContentLength = 140;

            public const int MaxDescriptionLength = 500;
            public const int MinDescriptionLength = 20;

            public const int MaxQuantityRange = 100;
            public const int MinQuantityRange = 0;

        }

        public static class Review
        {
            public const int MaxTitleLength = 65;
            public const int MinTitleLength = 5;

            public const int MaxContentLength = 750;
            public const int MinContentLength = 80;
        }

        public static class Size
        {
            public const int MaxSizeNumberLength = 4;
            public const int MinSizeNumberLength = 1;
        }
    }
}
