using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Operations.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; } 

        public string Title { get; set; } 

        public string Body { get; set; }

        public int UserId { get; set; }


        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }

    }
}
