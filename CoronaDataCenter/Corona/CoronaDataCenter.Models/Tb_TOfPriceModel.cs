using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaDataCenter.Models
{
    public class Tb_TOfPriceModel
    {
        public int ID { get; set; }	//参数ID		int
        public string P_Name { get; set; }	//时间名称		varchar(10)
        public string P_StartTime { get; set; }	//开始时间(时分)		time
        public string P_EndTime { get; set; }	//结束时间(时分)		time

    }
}
