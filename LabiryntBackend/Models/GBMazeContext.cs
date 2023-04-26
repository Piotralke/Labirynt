using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LabiryntBackend.Models
{
    public class GBMazeContext : DbContext
    {
        public GBMazeContext() { }

        public GBMazeContext(DbContextOptions<GBMazeContext> options) 
            : base(options) 
        { 
        }

        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Maze> Mazes { get; set; } = null!;
    }
}
