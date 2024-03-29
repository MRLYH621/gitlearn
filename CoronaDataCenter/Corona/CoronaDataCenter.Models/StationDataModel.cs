﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CoronaDataCenter.Models
{
    public class StationDataModel
    {
     public String   parm_001	{get;set;}//时刻		datetime
     public String parm_002 { get; set; } //系统Sn		varchar(50)
     public float parm_006{ get; set; } //预留		
     public float DZZ_Parm_003 { get; set; }//当日光伏发电量	kWh	float
     public float DZZ_Parm_004 { get; set; }//累计光伏发电量	kWh	float
     public float DZZ_Parm_005 { get; set; }//当日充电电量	kWh	float
     public float DZZ_Parm_006 { get; set; }//当日放电电量	kWh	float
     public float DZZ_Parm_007 { get; set; }//累计充电电量	kWh	float
     public float DZZ_Parm_008 { get; set; }//累计放电电量	kWh	float
     public float DZZ_Parm_009 { get; set; }//当日负荷电量	kWh	float
     public float DZZ_Parm_010 { get; set; }//累计负荷电量	kWh	float
     public float DZZ_Parm_011 { get; set; }//当日上网电量	kWh	float
     public float DZZ_Parm_012 { get; set; }//当日下网电量	kWh	float
     public float DZZ_Parm_013 { get; set; }//累计上网电量	kWh	float
     public float DZZ_Parm_014 { get; set; }//累计下网电量	kWh	float
     public float DZZ_Parm_015 { get; set; }//当日收益	元	float
     public float DZZ_Parm_016 { get; set; }//累计收益	元	float
     public float DZZ_Parm_017 { get; set; }//当日支出	元	float
     public float DZZ_Parm_018 { get; set; }//累计支出	元	float
     public float DZZ_Parm_019 { get; set; }//当日减排	T	float
     public float DZZ_Parm_020 { get; set; }//累计减排	T	float
        /// <summary>
        /// 系统信息
        /// </summary>
     public String Pname { get; set; } //      名称		varchar(50)
     public float SysCap { get; set; } // 系统容量	MW	float
     public int SysType { get; set; } // 系统类型		int
     public int SysMode { get; set; } // 运行模式		int

    }
}
