using domain;
using System;
using System.Collections.Generic;

namespace business
{
    public class GenreService
    {
        public List<Genre> BringList()
        {
            List<Genre> list = new List<Genre>();
            DataAccess dataAccess = new DataAccess();

            try
            {
                dataAccess.setQuery("select Id, Name from GENRES");
                dataAccess.executeRead();

                while (dataAccess.Reader.Read())
                {
                    Genre genre = new Genre();
                    genre.Id = (int)dataAccess.Reader["Id"];
                    genre.Name = (string)dataAccess.Reader["Name"];

                    list.Add(genre);
                }

                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
