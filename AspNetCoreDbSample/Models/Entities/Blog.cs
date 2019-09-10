using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDbSample.Models.Entities
{
    public class Blog
    {
        [Required]
        public int BlogId { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
