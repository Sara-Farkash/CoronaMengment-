using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entity
{
    public class Vaccination
    {
        [Key]
        public int id { get; set; }
        public string manufacturer { get; set; }
        public int codeV { get; set; }
        public DateTime timeOfV { get; set; }
        public int  userid { get; set; }
        public User1 user { get; set; }          
    }
}
