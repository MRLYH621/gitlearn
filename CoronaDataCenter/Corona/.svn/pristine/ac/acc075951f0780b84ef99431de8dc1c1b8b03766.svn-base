using CoronaDataCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoronaDataCenter.Business
{
    /// <summary>
    /// Excel下载类
    /// </summary>
    public class ExportToExcel
    {
        System.Data.DataTable table11 = new System.Data.DataTable();
        SystemLogRecord Syslog = new SystemLogRecord();
        bool fileSaved = false;
        public bool ExportToExcelData(System.Data.DataTable table, string saveFileName)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    return fileSaved;
                }
                Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
                Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1

                long rows = table.Rows.Count;

                if (rows > 65535)
                {

                    long pageRows = 60000;//定义每页显示的行数,行数必须小于

                    int scount = (int)(rows / pageRows);

                    if (scount * pageRows < table.Rows.Count)//当总行数不被pageRows整除时，经过四舍五入可能页数不准
                    {
                        scount = scount + 1;
                    }
                    for (int sc = 1; sc <= scount; sc++)
                    {
                        if (sc > 1)
                        {
                            object missing = System.Reflection.Missing.Value;
                            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.Add(
                           missing, missing, missing, missing);//添加一个sheet
                        }
                        else
                        {
                            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[sc];//取得sheet1
                        }
                        string[,] datas = new string[pageRows + 1, table.Columns.Count + 1];

                        for (int i = 0; i < table.Columns.Count; i++) //写入字段
                        {
                            datas[0, i] = table.Columns[i].Caption;
                        }
                        Microsoft.Office.Interop.Excel.Range range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, table.Columns.Count]];

                        range.Interior.ColorIndex = 15;//15代表灰色
                        range.Font.Bold = true;
                        range.Font.Size = 9;

                        int init = int.Parse(((sc - 1) * pageRows).ToString());
                        int r = 0;
                        int index = 0;
                        int result;

                        if (pageRows * sc >= table.Rows.Count)
                        {
                            result = table.Rows.Count;
                        }
                        else
                        {
                            result = int.Parse((pageRows * sc).ToString());
                        }
                        for (r = init; r < result; r++)
                        {
                            index = index + 1;
                            for (int i = 0; i < table.Columns.Count; i++)
                            {
                                if (table.Columns[i].DataType == typeof(string) || table.Columns[i].DataType == typeof(Decimal) || table.Columns[i].DataType == typeof(DateTime))
                                {
                                    object obj = table.Rows[r][table.Columns[i].ColumnName];
                                    datas[index, i] = obj == null ? "" : "'" + obj.ToString().Trim();//在obj.ToString()前加单引号是为了防止自动转化格式
                                }
                            }
                        }
                        Microsoft.Office.Interop.Excel.Range fchR = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[index + 2, table.Columns.Count + 1]];
                        fchR.Value2 = datas;
                        worksheet.Columns.EntireColumn.AutoFit();//列宽自适应。

                        range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[index + 1, table.Columns.Count]];
                        range.Font.Size = 9;
                        range.RowHeight = 14.25;
                        range.Borders.LineStyle = 1;
                        range.HorizontalAlignment = 1;

                    }
                }
                else
                {
                    string[,] datas = new string[table.Rows.Count + 2, table.Columns.Count + 1];
                    for (int i = 0; i < table.Columns.Count; i++) //写入字段         
                    {
                        datas[0, i] = table.Columns[i].Caption;
                    }
                    Microsoft.Office.Interop.Excel.Range range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, table.Columns.Count]];
                    range.Interior.ColorIndex = 15;//15代表灰色
                    range.Font.Bold = true;
                    range.Font.Size = 9;

                    int r = 0;
                    for (r = 0; r < table.Rows.Count; r++)
                    {
                        for (int i = 0; i < table.Columns.Count; i++)
                        {
                            if (table.Columns[i].DataType == typeof(int) || table.Columns[i].DataType == typeof(double) || table.Columns[i].DataType == typeof(float) || table.Columns[i].DataType == typeof(string) || table.Columns[i].DataType == typeof(Decimal) || table.Columns[i].DataType == typeof(DateTime))
                            {
                                object obj = table.Rows[r][table.Columns[i].ColumnName];
                                datas[r + 1, i] = obj == null ? "" : "'" + obj.ToString().Trim();//在obj.ToString()前加单引号是为了防止自动转化格式
                            }
                        }
                    }
                    Microsoft.Office.Interop.Excel.Range fchR = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[table.Rows.Count + 2, table.Columns.Count + 1]];
                    fchR.Value2 = datas;
                    worksheet.Columns.EntireColumn.AutoFit();//列宽自适应。
                    range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[table.Rows.Count + 1, table.Columns.Count]];


                    //15代表灰色

                    range.Font.Size = 9;
                    range.RowHeight = 14.25;
                    range.Borders.LineStyle = 1;
                    range.HorizontalAlignment = 1;
                }

                if (saveFileName != "")
                {
                    try
                    {
                        workbook.Saved = true;
                        workbook.SaveCopyAs(saveFileName);
                        fileSaved = true;
                        Tb_SysLog sysModel = new Tb_SysLog()
                        {
                            LogAction = "数据下载",
                            LogContent = "Excel生成成功",
                            ModuleCode = "LS"
                        };
                        Syslog.InsertSYSLog(sysModel);
                    }
                    catch (Exception ex)
                    {
                        Tb_SysLog sysModel = new Tb_SysLog()
                        {
                            LogAction = "数据下载",
                            LogContent = "Excel生成失败：" + ex.Message,
                            ModuleCode = "LS"
                        };
                        Syslog.InsertSYSLog(sysModel);
                        fileSaved = false;
                    }
                }
                else
                {
                    Tb_SysLog sysModel = new Tb_SysLog()
                    {
                        LogAction = "数据下载",
                        LogContent = "Excel文件名称或路径不对",
                        ModuleCode = "LS"
                    };
                    Syslog.InsertSYSLog(sysModel);
                    fileSaved = false;
                }
                xlApp.Quit();

                GC.Collect();//强行销毁 

                return fileSaved;
            }
            catch (Exception ex)
            {
                fileSaved = false;
                Tb_SysLog sysModel = new Tb_SysLog()
                {
                    LogAction = "数据下载",
                    LogContent = "Excel生成失败：" + ex.Message,
                    ModuleCode = "LS"
                };
                Syslog.InsertSYSLog(sysModel);
                return fileSaved;
            }
        }
    }
}
