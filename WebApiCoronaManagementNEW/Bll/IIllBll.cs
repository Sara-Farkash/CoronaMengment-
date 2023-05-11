using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public interface IIllBll
    {
        List<IllDto> GetAllIlls();
        IllDto GetIllById(int id);
        void AddIll(IllDto i);
    }
}
