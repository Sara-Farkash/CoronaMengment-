using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;
namespace Bll
{
    public interface IVaccinationBll
    {
        List<VaccinationDto> GetAllVaccination();
        
        void AddVaccination(VaccinationDto u);
    }
}
