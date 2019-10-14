using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.DAL
{
    public class FormDbContext : DbContext
    {
        public FormDbContext(): base("FormDb")
        {
        }

        public DbSet<Form> Forms { get; set; }
        public DbSet<CourseNSeminar> CourseNSeminars { get; set; }
        public DbSet<LangInfo> LangInfos { get; set; }
        public DbSet<ComputerSkill> ComputerSkills { get; set; }
        public DbSet<JobHistory> JobHistories { get; set; }
        public DbSet<FormResult> FormResults { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // configures zero-or-one-to-many relationship
            modelBuilder.Entity<Form>()
                .HasRequired<ComputerSkill>(s => s.ComputerSkill)
                .WithMany(g => g.Forms);
            modelBuilder.Entity<Form>()
                .HasRequired<CourseNSeminar>(s => s.CourseNSeminar)
                .WithMany(g => g.Forms);
            modelBuilder.Entity<Form>()
                .HasRequired<JobHistory>(s => s.JobHistory)
                .WithMany(g => g.Forms);
            modelBuilder.Entity<Form>()
                .HasRequired<LangInfo>(s => s.LangInfo)
                .WithMany(g => g.Forms);

            // Configure FormId as FK for FormResult
            modelBuilder.Entity<Form>()
                .HasRequired(s => s.FormResult)
                .WithRequiredPrincipal(ad => ad.Form);

        }
    }
}