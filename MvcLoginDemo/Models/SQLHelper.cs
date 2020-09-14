using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MvcLoginDemo.Models
{
    /// <summary>
    /// 通用的数据访问类
    /// </summary>
    public class SQLHelper
    {
        //定义连接字符串
        private static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        public static SqlDataReader GetReader(string sql) 
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try 
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch(Exception ex)
            {
                //将错误信息写入日志TODO
                throw;
            }
        }
    }
}