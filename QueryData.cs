using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CP_Preprocessing
{
    public class QueryData
    {
        private string conStr;
        private SqlCommand sqlcmd;
        private SqlConnection conn;
        private SqlDataAdapter buffer;
        private DataTable dt;

        public QueryData()
        {
            conStr = ConfigurationManager.ConnectionStrings["Prediction"].ConnectionString;
            conn = new SqlConnection(conStr);
            sqlcmd = new SqlCommand();
            buffer = null;
            dt = new DataTable();
        }

        public int executeStoredProcedure(string procedureName)
        {
            try
            {
                conn.Open();
                sqlcmd.CommandText = "EXEC " + procedureName;
                sqlcmd.Connection = conn;
                sqlcmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                conn.Close();
                return -1;
            }
            return 0;
        }

        public DataTable search(string cmd)
        {   
            try
            {
                sqlcmd.CommandText = cmd;
                sqlcmd.Connection = conn;
                sqlcmd.CommandTimeout = 60;
                buffer = new SqlDataAdapter(sqlcmd);
                buffer.Fill(dt);
                return dt;
            }
            catch(InvalidOperationException ex)
            {
                return dt;
            }
        }
    }
}
