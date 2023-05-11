using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public partial class IllDto
    {
        public int id { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime timeAswerPostive { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime timeRecovery { get; set; }
        public int userId { get; set; }
   

    }
}
