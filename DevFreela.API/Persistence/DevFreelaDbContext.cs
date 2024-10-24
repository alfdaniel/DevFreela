using DevFreela.API.Entity;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.API.Persistence
{
    public class DevFreelaDbContext : DbContext
    {
        public DevFreelaDbContext(DbContextOptions<DevFreelaDbContext> options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<ProjectComments> ProjectComments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Skill>(e =>
            {
                e.HasKey(s => s.Id);
            });

            builder.Entity<UserSkill>(e =>
            {
                e.HasKey(us => us.Id);
                e.HasOne(us => us.Skill)
                .WithMany(u => u.UserSkills)
                .HasForeignKey(us => us.IdSkill)
                .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<ProjectComments>(e =>
            {
                e.HasKey(pc => pc.Id);
                e.HasOne(pc => pc.Project)
                .WithMany(pc => pc.Comments)
                .HasForeignKey(pc => pc.IdProject)
                .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<User>(e => {
                e.HasKey(u => u.Id);
                e.HasMany(u => u.Skills)
                .WithOne(us => us.User)
                .HasForeignKey(us => us.IdUser)
                .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<Project>(e => {
                e.HasKey(p => p.Id);
                e.HasOne(p => p.Freelancer)
                .WithMany(p => p.FreelanceProjects)
                .HasForeignKey(p => p.IdFreelancer)
                .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(p => p.Client)
                .WithMany(p => p.OwnedProjects)
                .HasForeignKey(p => p.IdCliente)
                .OnDelete(DeleteBehavior.Restrict);
             });

            base.OnModelCreating(builder);
        }

    }
}