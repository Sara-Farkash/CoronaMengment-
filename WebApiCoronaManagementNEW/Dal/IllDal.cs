using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class IllDal : IIllDal
    {
        private Database db;
        public IllDal(Database _db)
        {
            this.db = _db;

        }
        public void AddIll(Ill i)
        {

            this.db.Ills.Add(i);
            this.db.SaveChanges();
        }

        public List<Ill> GetAllIlls()
        {
            return this.db.Ills.ToList();
        }

        public Ill GetIllById(int id)
        {
            return this.db.Ills.FirstOrDefault(x => x.id == id);
        }
    }
}
