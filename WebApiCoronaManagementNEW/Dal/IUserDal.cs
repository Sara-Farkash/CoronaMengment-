using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dal
{
    public interface IUserDal
    {
        List<User1> GetAllUsers();
        User1 GetUserById(int id);
        void AddUser(User1 u);
        int notVaccination();

    }
}
