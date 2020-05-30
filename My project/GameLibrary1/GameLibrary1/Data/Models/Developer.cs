using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameLibrary1.Data.Models
{
    public class Developer
    {
        [Key]
        public int ID { get; set; }
        public string DevName { get; set; }
        public string DevAdress { get; set; }

        //public virtual ICollection<Game> Games { get; set; }
       
    }
}
