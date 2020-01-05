using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtavBlog.Models.Account;
using ArtavBlog.Models.Blog;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArtavBlog.Models.Base
{
    public class BlogContext : IdentityDbContext<ApplicationUser>
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        { }

        public DbSet<Comment> CommentDb { get; set; }
        public DbSet<Post> PostDb { get; set; }
        public DbSet<Tag> TagDb { get; set; }
        public DbSet<TagPost> TagPostDb { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            UserRegister();
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaim", "Ident");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserToken", "Ident");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogin", "Ident");
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaim", "Ident");


            modelBuilder.Entity<Post>()
                .HasMany(p => p.TagPost_List)
                .WithOne(p => p.Post_TagPost)
                .HasForeignKey(p => p.PostId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Tag>()
                .HasMany(p => p.TagPost_List)
                .WithOne(p => p.Tag_TagPost)
                .HasForeignKey(p => p.TagId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Post>()
                .HasMany(p => p.Comment_List)
                .WithOne(p => p.Post_Comment)
                .HasForeignKey(p => p.PostId)
                .OnDelete(DeleteBehavior.Restrict);

            void UserRegister()
            {
                var userId = Guid.NewGuid().ToString();
                var adminRoleId = Guid.NewGuid().ToString();
                var userRoleId = Guid.NewGuid().ToString();
                modelBuilder.Entity<ApplicationUser>().ToTable("User", "Ident").HasData(new ApplicationUser()
                {
                    UserName = "admin",
                    IsDeleted = false,
                    LastModifiedDateAndTime = DateTime.Now,
                    CreateDateAndTime = DateTime.Now,
                    Email = "ali.qader3@gmail.com",
                    EmailConfirmed = true,
                    Id = userId,
                    PasswordHash = AvizheCrypto.DataCryptography.GetHashedString("SiteAdmin110!"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    CreatorIdentityID = "NOONE!",
                    LastModifierIdentityID = "NOONE!"
                });
                modelBuilder.Entity<IdentityRole>().ToTable("Role", "Ident").HasData(new IdentityRole()
                {
                    Id = adminRoleId,
                    Name = "Admin"
                }, new IdentityRole()
                {
                    Id = userRoleId,
                    Name = "User",
                });
                modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRole", "Ident").HasData(new IdentityUserRole<string>()
                {
                    RoleId = adminRoleId,
                    UserId = userId
                },
                new IdentityUserRole<string>()
                {
                    RoleId = userRoleId,
                    UserId = userId
                });
            }
        }
    }
}
