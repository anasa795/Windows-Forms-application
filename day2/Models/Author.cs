using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2.Models
{
    public class Author
    {

        public int Id { get; set; }
        [StringLength(20)]
        public string UserName { get; set; }
        [StringLength(20)]
        public string Password { get; set; }
        [StringLength(20)]
        public string Email { get; set; }
        public int Age { get; set; }
        public byte[]? Photo { get; set; }

        public virtual List<Post> Posts { get; set; }


    }
}
