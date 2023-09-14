using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using domain;

namespace WindowsFormApp
{
    public class AlbumService
    {
        public List<Album> BringList()
        {
            List<Album> list = new List<Album>();
            SqlConnection sqlConection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataReader sqlDataReader;

            try
            {
                sqlConection.ConnectionString = "server=.\\SQLEXPRESS; database=ALBUMS_DB; integrated security=true";
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "select Title, Author, UrlCoverImage, G.Name from ALBUMS A, GENRES G where A.IdGenre = G.Id";
                sqlCommand.Connection = sqlConection;

                sqlConection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Album album = new Album();
                    album.Title = (string)sqlDataReader["Title"];
                    album.Author = (string)sqlDataReader["Author"];
                    album.CoverImage = (string)sqlDataReader["UrlCoverImage"];
                    album.Genre = new Genre();
                    album.Genre.Name = (string)sqlDataReader["Name"];

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
