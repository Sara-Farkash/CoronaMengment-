using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Text.RegularExpressions;

namespace Dto
{
    public partial class User1Dto
    {
        public int id { get; set; }
        [Required, RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please enter a valid full name.")]
        public string fullName { get; set; }

        [Required, MaxLength(9), MinLength(8)]
        public string tz { get; set; }
        [Required, RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please enter a valid city name.")]
        public string city { get; set; }
        [Required, RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please enter a valid street.")]
        public string street { get; set; }
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Please enter a valid house number.")]
        public int numHouse { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime dateBirth { get; set; }
        [Phone]
        public string phone { get; set; }
        [Phone]
        public string cellphone { get; set; }
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Please enter a valid number.")]
        public int isCust { get; set; }
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Please enter a valid  number.")]
        public int isWorker { get; set; }
        public string picture { get; set; }
        public ICollection<VaccinationDto>? listVaccination { get; set; }

       
    }
}
    