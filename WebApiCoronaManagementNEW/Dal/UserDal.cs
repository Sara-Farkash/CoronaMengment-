using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class UserDal : IUserDal
    {
        private Database db;
        public UserDal(Database _db)
        {
            this.db = _db;
        }
        public void AddUser(User1 u)
        {
               this.db.Users.Add(u);  
               this.db.SaveChanges();
        }

        public List<User1> GetAllUsers()
        {
            return this.db.Users.ToList();

        }

        public User1 GetUserById(int id)
        {
            return this.db.Users.Include(u=>u.listVaccination).FirstOrDefault(x => x.id == id);
        }
        public int notVaccination()
        {
            return this.db.Users.Include(u=>u.listVaccination).Where(u=>u.listVaccination.Count==0).Count();
        }
    }
}