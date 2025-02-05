using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Models
{
    [PrimaryKey(nameof(accId), nameof(courseId))]
    public class sub
    {
        [ForeignKey("account")]
        public int accId { get; set; }
        public virtual user account { get; set; }

        [ForeignKey("course")]
        public int courseId { get; set; }
        public virtual subject course { get; set; }

    }
}
