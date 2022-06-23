using AutoMapper;
using CRUD_Operations.DTOs;
using CRUD_Operations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Operations.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<PostDTO, Post>().ReverseMap();
            CreateMap<UserDTO, User>().ReverseMap();
        }
    }
}
