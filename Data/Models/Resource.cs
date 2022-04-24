using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data.Models.Enums;

namespace University.Data.Models
{
    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }

        [Required, MaxLength(64)]
        public string Name { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string Url { get; set; }

        public ResourceType ResourceType { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
