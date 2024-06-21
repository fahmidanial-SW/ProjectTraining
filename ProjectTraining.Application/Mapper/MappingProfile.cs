using AutoMapper;
using ProjectTraining.Application.ViewModel;
using ProjectTraining.Domain.Entities;
using ProjectTraining.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraining.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TRAINING, ProjectViewModel_List>().ReverseMap();
            CreateMap<ProjectViewModel_List, TRAINING>().ReverseMap();

            CreateMap<TRAINING, ProjectViewModel_Insert>().ReverseMap();
        }
    }
}
