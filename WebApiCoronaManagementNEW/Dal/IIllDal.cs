using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IIllDal
    {
        List<Ill> GetAllIlls();
        Ill GetIllById(int id);
        void AddIll(Ill i);
    }
}
