using Microsoft.EntityFrameworkCore;
using MottoUI.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MottoUI.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BURAK;database=CoreBlogDb; integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
                .HasOne(m => m.HomeTeam)
                .WithMany(t => t.HomeMatches)
                .HasForeignKey(y=> y.HomeTeamID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.GuestTeam)
                .WithMany(t => t.AwayMatches) 
                .HasForeignKey(y => y.GuestTeamID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>()
                .HasOne(m => m.SenderUser)
                .WithMany(t => t.WriterSender)
                .HasForeignKey(y => y.SenderID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>()
                .HasOne(m => m.ReceiverUser)
                .WithMany(t => t.WriterReceiver)
                .HasForeignKey(y => y.ReceiverID)
                .OnDelete(DeleteBehavior.ClientSetNull);
            //HomeMatches --> WriterSender
            //AwayMatches --> WriterReceiver

            //HomeTeam --> SenderUser
            //GuestTeam --> ReceiverUser
        }
        
        
        //Context DbSet Properties
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<BlogRayting> BlogRaytings { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Message2> Message2s { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
