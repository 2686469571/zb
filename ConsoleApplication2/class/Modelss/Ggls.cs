using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classs.Modelss
{
   public class Ggls 
{
        public int GglsId { get; set; }
        //[MaxLength(200)]
        public string Lile { get; set; }
        public string Co { get; set; }
        //相当于数据库外码
        public int ClasssId { get; set; }

    }
}
