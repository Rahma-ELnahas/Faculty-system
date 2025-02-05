using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Models
{
    public class ProjContext : DbContext
    {

        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<sub> Subs { get; set; }
        public virtual DbSet<subject> Subjects { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=.;Database=Project;Trusted_Connection=True;Trust Server Certificate=true");
       
       }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define composite primary key
            modelBuilder.Entity<sub>().HasKey(s => new { s.accId, s.courseId });
           modelBuilder.Entity<sub>().HasOne(s => s.account).WithMany(u => u.Subs).HasForeignKey(s => s.accId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<sub>().HasOne(s => s.course).WithMany(c => c.Subs).HasForeignKey(s => s.courseId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<sub>().HasOne(s => s.account).WithMany(u => u.Subs).HasForeignKey(s => s.accId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
