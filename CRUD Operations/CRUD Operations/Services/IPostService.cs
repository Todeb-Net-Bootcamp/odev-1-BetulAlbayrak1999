using CRUD_Operations.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Operations.Services
{
    public interface IPostService
    {
        List<PostDTO> GetAll();

        bool Delete(int id);

        bool Update(PostDTO p);

        PostDTO GetById(int id);

        bool Post(PostDTO p);
    }
}
