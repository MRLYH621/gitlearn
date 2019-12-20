using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaDataCenter.Models
{
    public class Tb_EconomyModel
    {
        public int ID { get; set; }	//参数ID		int
        public string E_Name { get; set; }	//参数名称		varchar(10)
        public string E_Code { get; set; }	//参数代码		float
        public int P_ID { get; set; }	//时域		varchar(10)

        public string P_NAME { get; set; }	//地域		varchar(10)
        public string P_STARTTIME { get; set; }	//地域		varchar(10)
        public string P_ENDTIME { get; set; }	//地域		varchar(10)

        public string E_Region { get; set; }	//地域		varchar(10)
        public float E_Value { get; set; }	//值		float
        public string E_Unit { get; set; }	//单位		varchar(10)

    }
}
