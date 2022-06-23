using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Operations.DTOs
{
    public class PostDTO
    {
        public string Title { get; set; }

        public string Body { get; set; }

        public int UserId { get; set; }
    }
}
