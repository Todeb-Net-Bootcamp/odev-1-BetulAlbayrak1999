using CRUD_Operations.DTOs;
using CRUD_Operations.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Operations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAll()
        {
            try
            {
                var result = _postService.GetAll();
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
            
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = _postService.Delete(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(); ;
            }

        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Post(PostDTO p)
        {
            try
            {
                var result = _postService.Post(p);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(); ;
            }

        }

        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = _postService.GetById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(); ;
            }

        }

        [HttpPut]
        [Route("[action]")]
        public IActionResult Update(PostDTO p)
        {
            try
            {
                var result = _postService.Update(p);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(); ;
            }

        }

    }
}
