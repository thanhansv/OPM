using System;
using System.Data;
using System.Data.SqlClient;

namespace OPM.DBHandler
{

    class OPMDBHandler
    {
        public static int GetConnection(ref SqlConnection con)
        {
            try 
            {
                string strconnection = @"Data Source=LEXUANTHANH\SQLEXPRESS;Initial Catalog=OpmDB;Integrated Security=True";
                con = new SqlConnection(strconnection);
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
        }

        public static int fInsertData(string strSqlCommand)
        {
            string strconnection = @"Data Source=LEXUANTHANH\SQLEXPRESS;Initial Catalog=OpmDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(strconnection);

            try
            {
                con.Open();
                using (SqlCommand insertCommand = con.CreateCommand())
                {
                    insertCommand.CommandText = strSqlCommand;
                    var row = insertCommand.ExecuteNonQuery();
                }
                CloseConnection(con);
                return 1;
            }
            catch(Exception)
            {
                CloseConnection(con);
                return 0;
            }

        }
        public static int fQuerryData1(string strQuerry)
        {
            string strconnection = @"Data Source=LEXUANTHANH\SQLEXPRESS;Initial Catalog=OpmDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(strconnection);
            try
            {
                con.Open();
                using (SqlCommand sCommand = con.CreateCommand())
                {
                    sCommand.CommandText = strQuerry;
                    using (SqlDataReader reader = sCommand.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                //Do Sothing
                            }    
                        }
                        else
                        {
                            //Do Something
                        }    

                    }    
                }
                CloseConnection(con);
                return 1;

            }
            catch (Exception)
            {
                CloseConnection(con);
                return 0;
            }
        }

        public static int fQuerryData(string strQuerry, ref DataSet ds)
        {
            string strconnection = @"Data Source=LEXUANTHANH\SQLEXPRESS;Initial Catalog=OpmDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(strconnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;

            try
            {
                con.Open();
                command = new SqlCommand(strQuerry, con);
                adapter.SelectCommand = command;
                adapter.Fill(ds, "SQL Temp");

                adapter.Dispose();
                command.Dispose();
                CloseConnection(con);
                if(0 == ds.Tables[0].Rows.Count)
                {
                    return 0;
                }    
                return 1;

            }
            catch (Exception)
            {
                adapter.Dispose();
                CloseConnection(con);
                return 0;
            }
        }
        public static int CloseConnection(SqlConnection con)
        {
            con.Close();
            con.Dispose();
            con = null;
            return 1;
        }
    }
}
