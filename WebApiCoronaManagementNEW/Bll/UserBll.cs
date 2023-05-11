using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;
using AutoMapper;
using Entity;

//using System.Text.Json;

namespace Bll
{
    public class UserBll : IUserBll
    {
        private IUserDal userDal;
        private IMapper mapper;
        public UserBll(IUserDal userDal, IMapper map)
        {
            this.userDal = userDal;
            this.mapper = map;
        }
        public void AddUser(User1Dto inputData)
        {
            string inputJson = JsonConvert.ConvertToJson(inputData);
                this.userDal.AddUser(mapper.Map<User1>(inputData));  
        }
   
        public List<User1Dto> getAllUsers()
        {
            return mapper.Map<List<User1Dto>>(this.userDal.GetAllUsers());
        }

        public User1Dto GetUserByID(int id)
        {
            return mapper.Map <User1Dto>(this.userDal.GetUserById(id));

        }
        public int notVaccination()
        {
            return this.userDal.notVaccination();
        }
    }
}
