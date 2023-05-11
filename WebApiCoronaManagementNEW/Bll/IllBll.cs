using Dal;
using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Dal;


namespace Bll
{
    public class IllBll : IIllBll
    {
        private IIllDal illDal;
        private  IMapper mapper;
        public IllBll(IIllDal illDal, IMapper map)
        {
            this.illDal = illDal;
            this.mapper = map;
        }

        public void AddIll(IllDto i)
        {

            string inputJson = JsonConvert.ConvertToJson(i);
            this.illDal.AddIll(mapper.Map<Ill>(i));
        }


        public List<IllDto> GetAllIlls()
        {
            return mapper.Map<List<IllDto>>(illDal.GetAllIlls());
        }
        public IllDto GetIllById(int id)
        {
            return mapper.Map<IllDto>(illDal.GetIllById(id));
        }


    }
}
