using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaDataCenter.Business
{
    public class DataAccess
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["MasterConnectionString"].ConnectionString.ToString();//集群主节点 可读写
        private static string connStrRead = ConfigurationManager.ConnectionStrings["NodeConnectionString"].ConnectionString.ToString();//辅节点 只读
        public static SqlConnection GetDBConn(bool readOnly)
        {
            return DBConn(readOnly == true ? connStrRead : connStr);
        }
        private static SqlConnection DBConn(string ConnectionString)
        {
            SqlConnection tConn = new SqlConnection(ConnectionString);
            try
            {
                tConn.Open();
            }
            catch (Exception)
            {
                tConn = new SqlConnection(connStr);
                tConn.Open();
            }
            return tConn;
        }

        /// <summary>
        /// 执行查询语句，返回查询结果集 （只读）
        /// </summary>
        public static DataTable ExecuteGetDataTable(string SQL)
        {
            SqlConnection tSqlConnection = GetDBConn(true);
            try
            {
                SqlCommand tSqlCommand = new SqlCommand(SQL, tSqlConnection);

                SqlDataAdapter tSqlDataAdapter = new SqlDataAdapter(tSqlCommand);

                DataTable dt = new DataTable();
                tSqlDataAdapter.Fill(dt);
                return dt;
            }
            catch
            {
                return new DataTable();
            }
            finally
            {
                tSqlConnection.Close();
            }
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="tableName">表名（例如:tb_user）</param>
        /// <param name="where">where条件（例如：where id > 5）</param>
        /// <param name="order">orderby 排序字段（例如：id）</param>
        /// <param name="pageSize">每页显示条数（例如：20）</param>
        /// <param name="pageIndex">当前显示页（例如：5）</param>
        /// SQLSERVER2012  分页语句
        /// select * from Tb_HLX_LS order by id DESC OFFSET (pageSize * (pageIndex-1)) ROW FETCH NEXT pageSize rows only
        /// <returns></returns>
        public static DataTable Paging(string tableName, string where, string order, int pageSize, int pageIndex)
        {
            if (string.IsNullOrEmpty(tableName) || pageSize < 0 || pageIndex < 1)
            {
                return new DataTable();
            }
            int rowNum = pageIndex > 0 ? ((pageIndex - 1) * pageSize) : 0;
            string sql = "select top " + pageSize + " * from ( select row_number() over ( order by ";
            if (string.IsNullOrEmpty(order))
            {
                order = "id";
            }
            sql = sql + order + " desc ) as rownumber,* from " + tableName + " ";
            if (!string.IsNullOrEmpty(where))
            {
                sql = sql + where;
            }
            sql = sql + " ) A  where rownumber > " + rowNum + "order by " + order + " desc";
            return ExecuteGetDataTable(sql);
        }

        /// <summary>
        /// 执行SQL,返回DBID （写）
        /// </summary>
        /// <param name="ConnStr"></param>
        /// <param name="SQL"></param>
        /// <returns></returns>        
        public static string ExecuteScalarGetValue(string SQL)
        {
            SqlConnection tSqlConnection = GetDBConn(false);
            int strReturnValue = -1;
            try
            {
                SqlCommand tSqlCommand = new SqlCommand(SQL, tSqlConnection);

                strReturnValue = (Int32)tSqlCommand.ExecuteScalar();
                if (strReturnValue == -1)
                {
                    return "";
                }
                else
                {
                    return strReturnValue.ToString();
                }
            }
            catch
            {
                return "";
            }
            finally
            {
                tSqlConnection.Close();
            }
        }

        /// <summary>
        /// 执行SQl，返回受影响的行数 （写）
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        public static int ExecuteNoQueryGetValue(string SQL)
        {
            SqlConnection tSqlConnection = GetDBConn(false);
            int strReturnValue = 0;
            try
            {
                SqlCommand tSqlCommand = new SqlCommand(SQL, tSqlConnection);
                strReturnValue = tSqlCommand.ExecuteNonQuery();
                return strReturnValue;
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                tSqlConnection.Close();
            }
        }

        /// <summary>
        /// 执行存储过程，带参数 （只读）
        /// </summary>
        /// <param name="procdure">存储过程名称</param>
        /// <param name="parms">参数名称数组</param>
        /// <param name="values">参数值数组</param>
        /// <returns></returns>
        public static DataTable ExecuteGetDataTable(string procdure, IDataParameter[] parms, ArrayList values)
        {
            SqlConnection tSqlConnection = GetDBConn(true);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = tSqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procdure;

                for (int i = 0; i < parms.Length; i++)
                {
                    parms[i].Value = values[i];
                    cmd.Parameters.Add(parms[i]);
                }

                SqlDataAdapter tSqlDataAdapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                tSqlDataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return new DataTable();
            }
            finally
            {
                tSqlConnection.Close();
            }
        }

        /// <summary>
        /// 执行查询,返回每行第一列的ArrayList （读写）
        /// </summary>
        public static ArrayList ExecuteGetArrayList(string SQL)
        {
            ArrayList tempArr = new ArrayList();
            SqlConnection tSqlConnection = GetDBConn(false);//DBAccess.GetSourceDBConn();
            try
            {
                SqlCommand tSqlCommand = new SqlCommand(SQL, tSqlConnection);

                SqlDataReader reader = tSqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    tempArr.Add(reader[0].ToString());
                }
                return tempArr;

            }
            finally
            {
                tSqlConnection.Close();
            }

        }

        /// <summary>
        /// 执行查询语句,返回查询字段的List<string> （读）
        /// </summary>
        public static List<string[]> ExecuteGetListString(string SQL)
        {
            List<string[]> tempArr = new List<string[]>();
            SqlConnection tSqlConnection = GetDBConn(true);//DBAccess.GetSourceDBConn();
            try
            {
                SqlCommand tSqlCommand = new SqlCommand(SQL, tSqlConnection);
                SqlDataReader reader = tSqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    string[] temp = new string[reader.FieldCount];

                    for (int k = 0; k < reader.FieldCount; k++)
                    {
                        temp[k] = reader[k].ToString();
                        tempArr.Add(temp);
                    }
                }
                return tempArr;
            }
            finally
            {
                tSqlConnection.Close();
            }
        }

        #region 事务处理 （读写）
        public static bool GetTransaction(List<string> sqllist)
        {
            bool Result = false;
            int result;
            SqlConnection myConnection = DataAccess.GetDBConn(false);    //获取SqlConnection对象
            SqlTransaction myTrans = myConnection.BeginTransaction(); // 启动一个事务
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.Transaction = myTrans;
            try
            {
                foreach (string item in sqllist)
                {
                    myCommand.CommandText = item.ToString();
                    result = myCommand.ExecuteNonQuery();
                    //if (result == 1)
                    if (result > 0)
                    {
                        Result = true;
                    }
                }
                myTrans.Commit();
            }
            catch (Exception)
            {
                myTrans.Rollback();
            }
            finally
            {
                myConnection.Close();
            }
            return Result;
        }

        /// <summary>
        /// 执行SQL,返回DBID （写）
        /// </summary>
        /// <param name="ConnStr"></param>
        /// <param name="SQL"></param>
        /// <returns></returns>        
        public static string ExecuteScalarGetID(string SQL)
        {
            SqlConnection tSqlConnection = GetDBConn(false);
            int strReturnValue = -1;
            try
            {
                SqlCommand tSqlCommand = new SqlCommand(SQL, tSqlConnection);
                strReturnValue = Convert.ToInt32(tSqlCommand.ExecuteScalar());
                if (strReturnValue == -1 || strReturnValue == 0)
                {
                    return "";
                }
                else
                {
                    return strReturnValue.ToString();
                }
            }
            catch
            {
                return "";
            }
            finally
            {
                tSqlConnection.Close();
            }
        }
        #endregion
    }
}
