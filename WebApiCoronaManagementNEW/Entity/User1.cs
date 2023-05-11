using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class User1
    {
        [Key]
        public int id { get; set; }
        public string fullName { get; set; }
        public string tz { get; set; }
        public string city  { get; set; }
        public string street { get; set; }
        public int numHouse { get; set; }
        public DateTime dateBirth { get; set; }
        public string phone { get; set; }
        public string cellphone { get; set; }
        public int isCust { get; set; }
        public int isWorker { get; set; }
        public string picture { get; set; }
        public Ill ill { get; set; }
        public  ICollection<Vaccination> listVaccination { get; set; }
    }
}
