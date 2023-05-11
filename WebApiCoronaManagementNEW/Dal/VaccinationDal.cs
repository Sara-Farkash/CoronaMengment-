using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class VaccinationDal : IVaccinationDal
    {
        private Database db;
        public VaccinationDal(Database _db)
        {
            this.db = _db;

        }
        public void AddVaccination(Vaccination v)
        {

            var patient = this.db.Users.Include(u=>u.listVaccination).Where(u => u.id == v.userid).FirstOrDefault();
            if (patient != null)
            {
                if(patient.listVaccination!=null)
                {
                    if (patient.listVaccination.Count<=3)
                    {
                        patient.listVaccination.Add(v);
           
                        
                    }
                    else
                    {
                        throw new Exception("its too much vacnin");

                    }
                }
                else
                {
                    patient.listVaccination=new List<Vaccination>(){ v };
                }
                this.db.SaveChanges();
            }
            else
            {
                throw new Exception("user not found");
            }

        }

        public List<Vaccination> GetAllVaccination()
        {
            return db.Vaccinations.ToList();
        }

        public Vaccination GetVaccinationById(int id)
        {
            return this.db.Vaccinations.FirstOrDefault(x => x.id == id);
        }
      

    }
}

