using System;
using System.Data.SqlClient;

namespace business
{
    internal class DataAccess
    {
        private SqlConnection conection;
        private SqlCommand command;
        private SqlDataReader reader;

        public SqlDataReader Reader
        {
            get { return reader; }
        }

        public DataAccess()
        {
            conection = new SqlConnection("server=.\\SQLEXPRESS; database=ALBUMS_DB; integrated security=true");
            command = new SqlCommand();
        }

        public void setQuery(string query)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;
        }

        public void executeRead()
        {
            command.Connection = conection;
            try
            {
                conection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void executeWrite() 
        {
            command.Connection = conection;

            try
            {
                conection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void closeConnection()
        {
            if (reader != null)
            {
                reader.Close();
            }

            conection.Close();
        }
    }
}
