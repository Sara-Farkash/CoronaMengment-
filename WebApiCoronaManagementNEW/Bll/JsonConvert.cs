using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Bll
{
    public class JsonConvert
    {
        public static string ConvertToJson(object input)
        {
            return JsonConvert.SerializeObject(input);
        }

        private static string SerializeObject(object input)
        {
            return "";
        }
    }
}
