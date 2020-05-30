using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameLibrary1.Data.Models
{
   public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int Developer { get; set; }
        public int Genre { get; set; }
        public int Console { get; set; }
        public int Publisher { get; set; }
    }
}
