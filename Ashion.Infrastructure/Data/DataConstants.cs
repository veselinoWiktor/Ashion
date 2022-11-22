using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Infrastructure.Data
{
    public class DataConstants
    {
        public class User
        {
            public const int MaxFirstNameLength = 30;
            public const int MinFirstNameLength = 2;

            public const int MaxLastNameLength = 30;
            public const int MinLastNameLength = 2;
        }

        public class Accessory
        {
            public const int MaxNameLength = 50;
            public const int MinNameLength = 3;

            public const int MaxBrandLength = 30;
            public const int MinBrandLength = 3;

            public const int MaxDescriptionLength = 1000;
            public const int MinDescriptionLength = 20;
        }
        public class Cloth
        {
            public const int MaxNameLength = 50;
            public const int MinNameLength = 3;

            public const int MaxBrandLength = 30;
            public const int MinBrandLength = 3;

            public const int MaxDescriptionLength = 1000;
            public const int MinDescriptionLength = 20;
        }

        public class Cosmetic
        {
            public const int MaxNameLength = 50;
            public const int MinNameLength = 3;

            public const int MaxBrandLength = 30;
            public const int MinBrandLength = 3;

            public const int MaxDescriptionLength = 1000;
            public const int MinDescriptionLength = 20;

            public const int MaxIntededLength = 15;
            public const int MinIntededLength = 1;

        }

        public class Review
        {
            public const int MaxDescriptionLength = 1200;
            public const int MinDescriptionLength = 10;
        }

        public class Type
        {
            public const int MaxTypeNameLength = 30;
            public const int MinTypeNameLength = 3;
        }
    }
}
