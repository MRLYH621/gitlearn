using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaDataCenter.Models
{
    
    public class Tb_TargetModel
    {   
        /// <summary>
        /// 评估指标(Tb_SysInex)
        /// </summary>
        public string Sn { get; set; }//Sn
        public float Value { get; set; }//指标值		float
        public float Benchmarking { get; set; }//对标值		float
        public float Weight { get; set; }//指标权重	%	float
        public int BindType { get; set; }//绑定方式(0或者1)		int
        public int DTColSour { get; set; }//数据库字段来源(1主表2基准参数3经济参数)		int
        public String DTColumn { get; set; }//数据库字段名(0系统实时表)	int
        /// <summary>
        /// 指标定义(Tb_Target)
        /// </summary>
        public int ID { get; set; }//指标ID		int
        public string T_Name { get; set; }//	指标名称		varchar(50)
        public string T_Type { get; set; }//	指标类别		int
        public string T_Code { get; set; }//	指标代码		varchar(50)
        public string T_Formula { get; set; }//	指标公式		varchar(50)

        public List<string> listCodes { get; set; }  //公式A*B*C  分解后 变成  ABC  list

    }

    public class FieldModel
    {
        public string FieldName { get; set; } //	字段名称		varchar(50)
        public string ChinaName { get; set; } //	字段中文名称		int
    }
}
