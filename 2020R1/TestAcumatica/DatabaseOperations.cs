using Core.Core.Browser;
using System;
using System.Data;
using System.Data.SqlClient;
/***************************
DatabaseOperations - Code Base for performing SQL restore
Patrick Chen SPS Commerce
04-2020
***************************/

namespace TestAcumatica
{
    class DatabaseOperations
    {
        public virtual void RestoreDB(string servername, string name, string backup)
        {
            Browser.Stop();

            var conn = new SqlConnection("Data Source=" + servername + ";Initial Catalog=master;Integrated Security=True;Connection Timeout =240");
            Console.WriteLine("Conn Str: " + conn.ConnectionString);
            string SqlQuery = string.Format(@"DECLARE @strSQL NVARCHAR(MAX) =''
                                    
                                    SELECT
                                    @strSQL +=  N'ALTER DATABASE ' + QUOTENAME(@dbName)
                                     + N' SET SINGLE_USER'
                                     + N' WITH ROLLBACK IMMEDIATE;'
                                     + N' RESTORE DATABASE ' + QUOTENAME(@dbName) 
                                     + N' FROM DISK = N''' + @BakFilePath + ''''
                                     + N' WITH RECOVERY, REPLACE;'                                     
                                     + N' ALTER DATABASE ' + QUOTENAME(@dbName)
                                     + N' SET MULTI_USER;'
                                     
                                     EXEC sp_executesql @strSQL");

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = SqlQuery;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@dbName", SqlDbType.NVarChar, 30));
                cmd.Parameters.Add(new SqlParameter("@BakFilePath", SqlDbType.NVarChar, 255));
                cmd.Parameters["@dbName"].Value = name;
                cmd.Parameters["@BakFilePath"].Value = backup;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Press any key to exit");
                Console.ReadLine();
            }
            try
            {
                Console.WriteLine("Restoring {0}...", name);
                cmd.Connection.Open();
                Console.WriteLine("start on: " + DateTime.Now.ToString());
                cmd.CommandTimeout = 0;
                cmd.ExecuteNonQuery();
                Console.WriteLine("end on: " + DateTime.Now.ToString());
                cmd.Connection.Close();
                Console.WriteLine("Restore Complete!");

            }
            catch (SqlException ex)
            {
                Console.WriteLine("error on: " + DateTime.Now.ToString());
                Console.WriteLine("Connection could not open. Error: {0}", ex);
                Console.ReadLine();
            }


        }
        
    }


}
