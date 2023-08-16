using Ashion.Core.Extensions;
using Ashion.Infrastructure.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Tests.Mocks
{
    public class MapperMock
    {
        public static IMapper Instance
        {
            get
            {
                var mapperConfiguration = new MapperConfiguration(config =>
                {
                    config.AddProfile<ServiceMappingProfile>();
                });

                return new Mapper(mapperConfiguration);
            }
        }
    }
}
