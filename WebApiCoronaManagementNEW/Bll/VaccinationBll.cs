using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;
using AutoMapper;
using Entity;
namespace Bll
{
    public class VaccinationBll : IVaccinationBll
    {
        private IVaccinationDal vaccinationDal;
        private IMapper mapper;
        public VaccinationBll(IVaccinationDal vaccinationDal, IMapper map)
        {
            this.vaccinationDal = vaccinationDal;
            this.mapper = map;
        }
        public void AddVaccination(VaccinationDto u)
        {
            this.vaccinationDal.AddVaccination(mapper.Map<Vaccination>(u));
        }

        public List<VaccinationDto> GetAllVaccination()
        {
            return mapper.Map<List<VaccinationDto>>(vaccinationDal.GetAllVaccination());
        }      
    }
}
