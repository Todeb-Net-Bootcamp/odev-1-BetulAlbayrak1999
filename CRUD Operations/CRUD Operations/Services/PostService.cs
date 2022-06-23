using AutoMapper;
using CRUD_Operations.DTOs;
using CRUD_Operations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Operations.Services
{
    public class PostService : IPostService
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public PostService(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool Delete(int id)
        {
            try
            {
                var post = _context.Posts.Find(id);
                if (post == null)
                    return false;
                _context.Posts.Remove(post);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<PostDTO> GetAll()
        {
            try
            {
                var postList = _context.Posts.ToList();
                if (postList == null)
                    return null;
                List<PostDTO> postDTOList = _mapper.Map<List<PostDTO>>(postList);
                return postDTOList;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public PostDTO GetById(int id)
        {
            try
            {
                var post = _context.Posts.Find(id);
                if (post == null)
                    return null;
                PostDTO postDTO = _mapper.Map<PostDTO>(post);
                return postDTO;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Post(PostDTO p)
        {
            try
            {
                Post post = _mapper.Map<Post>(p);
                _context.Posts.Add(post);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(PostDTO p)
        {
            try
            {
                var post = _mapper.Map<Post>(p);

                _context.Posts.Update(post);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
