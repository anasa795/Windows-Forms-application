using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2.Models
{
    public class Post
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(100)]

        public string Bref { get; set; }
        [StringLength(200)]

        public string Description { get; set; }
        public DateTime? time { get; set; }
        [Column(TypeName = "date(7)")]
        public DateTime? date { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        [ForeignKey("Catalog")]
        public int Cat_Id { get; set; }

        public virtual Author? Author { get; set; }
        public virtual Catalog? Catalog { get; set; }
    }
}
