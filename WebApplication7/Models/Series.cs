using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication7.Models.DAL;

namespace WebApplication7.Models
{
    public class Series
    {

        int id;
        string first_air_date;
        string name;
        string origin_country;
        string original_language;
        string overview;
        int popularity;
        string poster_path;
        int favCount;


        public List<Series> Get()
        {
            DataServices ds = new DataServices();
            return ds.GetSeries();
        }
        public List<string> Get(int id)
        {
            DataServices ds = new DataServices();
            return ds.GetSeries(id);
        }

        public Series() { }

        public Series(int id, string first_air_date, string name, string origin_country, string original_language, string overview, int popularity, string poster_path, int favCount)
        {
            this.id = id;
            this.first_air_date = first_air_date;
            this.name = name;
            this.origin_country = origin_country;
            this.original_language = original_language;
            this.overview = overview;
            this.popularity = popularity;
            this.poster_path = poster_path;
            this.favCount = 0;
        }

        public int Id { get => id; set => id = value; }
        public string First_air_date { get => first_air_date; set => first_air_date = value; }
        public string Name { get => name; set => name = value; }
        public string Origin_country { get => origin_country; set => origin_country = value; }
        public string Original_language { get => original_language; set => original_language = value; }
        public string Overview { get => overview; set => overview = value; }
        public int Popularity { get => popularity; set => popularity = value; }
        public string Poster_path { get => poster_path; set => poster_path = value; }
        public int FavCount { get => favCount; set => favCount = value; }
    }

}