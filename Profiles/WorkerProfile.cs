using Aplikacja_do_awizacji.DTO;
using Aplikacja_do_awizacji.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_do_awizacji.Profiles
{
    internal class WorkerProfile : Profile
    {
        public WorkerProfile()
        {
            CreateMap<Worker, WorkersListResponse>();
        }
    }
}
