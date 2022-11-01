using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MisterX.Models;

namespace MisterX
{
    public class MisterXDbContext:DbContext
    {

        public MisterXDbContext(DbContextOptions opt):base(opt)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
    }
}

