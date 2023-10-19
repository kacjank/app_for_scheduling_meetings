using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplikacja_do_awizacji.Profiles;

namespace Aplikacja_do_awizacji
{
    internal class SingleService
    {
        private static MapperConfiguration _mapperConfiguration =
            new MapperConfiguration(mapper =>
            {
                mapper.AddProfile(new WorkerProfile());
                mapper.AddProfile(new GuestProfile());
            });

        private static Lazy<IMapper> mapper =
            new Lazy<IMapper>(() => _mapperConfiguration.CreateMapper());

        public static IMapper Mapper => mapper.Value;
    }
}
