using business;
using domain;
using System;
using System.Collections.Generic;

namespace WindowsFormApp
{
    public class AlbumService
    {
        public List<Album> BringList()
        {
            List<Album> list = new List<Album>();
            DataAccess dataAccess = new DataAccess();

            try
            {
                dataAccess.setQuery("select Title, Author, UrlCoverImage, G.Name from ALBUMS A, GENRES G where A.IdGenre = G.Id");
                dataAccess.executeRead();

                while (dataAccess.Reader.Read())
                {
                    Album album = new Album();
                    album.Title = (string)dataAccess.Reader["Title"];
                    album.Author = (string)dataAccess.Reader["Author"];
                    album.CoverImage = (string)dataAccess.Reader["UrlCoverImage"];
                    album.Genre = new Genre();
                    album.Genre.Name = (string)dataAccess.Reader["Name"];

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
                dataAccess.closeConnection();
            }
        }

        public void Add(Album newAlbum)
        {
            DataAccess dataAccess = new DataAccess();

            try
            {
                dataAccess.setQuery($"insert into ALBUMS (Title, Author, UrlCoverImage) values ('{newAlbum.Title}', '{newAlbum.Author}', '{newAlbum.CoverImage}')");
                dataAccess.executeWrite();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dataAccess.closeConnection();
            }
        }
    }
}
