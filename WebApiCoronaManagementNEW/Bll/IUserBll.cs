using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
namespace Bll
{
    public interface IUserBll
    {
        List<User1Dto> getAllUsers();
        User1Dto GetUserByID(int id);
        void AddUser(User1Dto u);
        public int notVaccination();
    }
}
