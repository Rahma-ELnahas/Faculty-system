using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Models
{
    public class user
    {
        [Key]
        public int id { get; set; }
        [Required , MaxLength(50)]
        public string name { get; set; }

        [Required, MaxLength(50)]
        public string email { get; set; }

        [Required,MinLength(5) ,MaxLength(15)]
        public int password { get; set; }
        public int age { get; set; }
        public int? phone { get; set; }

        [Required, MaxLength(15)]
        public string role { get; set; }
        public virtual List<sub>? Subs { get; set; }


    }
}
