using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaDataCenter.Models
{
    public class Tb_DatumModel
    {
        public int ID { get; set; }//参数ID		int
        public string D_Name { get; set; }//参数名称		varchar(10)
        public string D_Code { get; set; }//参数代码		varchar(10)
        public float D_Value { get; set; }//参数值		float
        public string D_Unit { get; set; }//参数单位		varchar(10)

    }
}
