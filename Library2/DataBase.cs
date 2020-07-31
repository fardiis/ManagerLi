using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library2
{
    class DataBase
    {
        SqlConnection sqlc = new SqlConnection();
        SqlCommand sqlcmd = new SqlCommand();
      public DataTable Select( string str)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter();
            sqlc.ConnectionString = @"Data Source=DESKTOP-NE0671D;initial catalog=ManagerLi;integrated security=true";
            sqlc.Open();
            sqlcmd.Connection = sqlc;
            sqlcmd.CommandText = str;
            sqlda.SelectCommand = sqlcmd;
            sqlda.Fill(dt);
            sqlc.Close();
            return dt;
            
        }
        public bool Exe(string str)
        {
            sqlc.ConnectionString = @"Data Source=DESKTOP-NE0671D;initial catalog=ManagerLi;integrated security=true";
            sqlc.Open();
            sqlcmd.Connection = sqlc;
            sqlcmd.CommandText = str;
            try
            {
                sqlcmd.ExecuteNonQuery();
                return true;
            }
            catch 
            {

                return false;
            }
            finally
            {
                sqlc.Close();
            }

        }
    }
}
