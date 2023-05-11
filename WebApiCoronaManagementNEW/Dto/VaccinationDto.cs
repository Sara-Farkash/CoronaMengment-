using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public partial class VaccinationDto
    {
        public int id { get; set; }
        [Required, RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please enter a valid manufacturer.")]
        public string manufacturer { get; set; }
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Please enter a valid code Vaccination.")]
        public int codeV { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime timeOfV { get; set; }
        public int userId { get; set; }
     
    }
}
