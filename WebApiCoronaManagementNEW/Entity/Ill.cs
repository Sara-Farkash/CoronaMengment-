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
    public class Ill
    {
        [Key]
        public int id { get; set; }
        public DateTime timeAswerPostive { get; set; }
        public DateTime timeRecovery { get; set; }
        public int userId { get; set; }

        public User1 user { get; set; }
        
    }
}
