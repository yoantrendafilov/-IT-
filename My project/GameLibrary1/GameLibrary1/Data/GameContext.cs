using GameLibrary1.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameLibrary1.Data
{
   public class GameContext:DbContext
    {
                
        public GameContext() : base("name=GameContext") { }

        public DbSet<Game> Games { get; set; }
      
       public DbSet<Developer> Developers { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}
