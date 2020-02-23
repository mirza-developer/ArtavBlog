using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtavBlog.Models.Account;
using ArtavBlog.Models.Blog;
using ArtavBlog.Models.Messaging.CustomerCare;
using ArtavBlog.Models.Messaging.Sms;
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
        public DbSet<PhoneNumber> PhoneNumberDb { get; set; }
        public DbSet<Message> MessageDb { get; set; }
        public DbSet<CareMessage> CareMessageDb { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            AdminUserRegister();
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

            modelBuilder.Entity<PhoneNumber>()
                .HasMany(p => p.Message_List)
                .WithOne(p => p.PhoneNumber_Message)
                .HasForeignKey(p => p.PhoneNumberId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<Post>()
                .Property(e => e.UniqueIntegerID)
                .Metadata
                .SetBeforeSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            modelBuilder
                .Entity<CareMessage>()
                .Property(p => p.Lock)
                .HasDefaultValue(false);

            void AdminUserRegister()
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
                NormalUserRegister();
                void NormalUserRegister()
                {
                    var userUserId = Guid.NewGuid().ToString();
                    modelBuilder.Entity<ApplicationUser>().ToTable("User", "Ident").HasData(new ApplicationUser()
                    {
                        UserName = "user",
                        IsDeleted = false,
                        LastModifiedDateAndTime = DateTime.Now,
                        CreateDateAndTime = DateTime.Now,
                        Email = "ali.qader3@gmail.com",
                        EmailConfirmed = true,
                        Id = userUserId,
                        PasswordHash = AvizheCrypto.DataCryptography.GetHashedString("user220!"),
                        SecurityStamp = Guid.NewGuid().ToString(),
                        CreatorIdentityID = "NOONE!",
                        LastModifierIdentityID = "NOONE!"
                    });
                    modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRole", "Ident").HasData(
                    new IdentityUserRole<string>()
                    {
                        RoleId = userRoleId,
                        UserId = userUserId
                    });
                }
            }

         
        }
    }
}
