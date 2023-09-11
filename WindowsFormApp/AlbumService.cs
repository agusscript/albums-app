using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WindowsFormApp
{
    class AlbumService
    {
        public List<Album> BringList()
        {
            List<Album> list = new List<Album>();
            SqlConnection sqlConection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataReader sqlDataReader;

            try
            {
                sqlConection.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "select Titulo, Autor, UrlImagenTapa from DISCOS";
                sqlCommand.Connection = sqlConection;

                sqlConection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Album album = new Album();
                    album.Title = (string)sqlDataReader["Titulo"];
                    album.Author = (string)sqlDataReader["Autor"];
                    album.Image = (string)sqlDataReader["UrlImagenTapa"];

                    list.Add(album);
                }

                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConection.Close();
            }
        }
    }
}
