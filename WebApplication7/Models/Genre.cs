using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication7.Models.DAL;
using WebApplication7.Models;

namespace WebApplication7.Models
{
    public class Genre
    {
        int userId;
        int seriesId;
        string[] genres;

        public void insert()
        {
            DataServices ds = new DataServices();
            ds.insertGenre(this);
        }
        public List<SeriesScore> get(int id)
        {
            DataServices ds = new DataServices();
            List<string> userGenres = ds.getUserGenres(id); //get user genres
            if (userGenres.Count == 0)
                return null;
            List<Genre> allGenres = ds.getAllGenre(id); //get all but the user's genre

            if (allGenres.Count == 0)
                return null;

            return calculateScore(userGenres, allGenres);
            
        }
        private List<SeriesScore> calculateScore(List<string> userGenres, List<Genre> allGenres)
        {
            //calculate score for every show that was not added by the user

            DataServices ds = new DataServices();
            IDictionary<string, int> genreScore = new Dictionary<string, int>();
            string[] distGenres = userGenres.Distinct().ToArray();
            List<SeriesScore> ssl = new List<SeriesScore>();


            for(int i = 0; i < distGenres.Length; i++) //set value for each genre by the amount of appearances in userGenres
            {
                int counter = 0;
                for(int j = 0; j < userGenres.Count; j++)
                {
                    if (distGenres[i] == userGenres[j])
                        counter++;
                }
                genreScore.Add(distGenres[i], counter);
            }

            for (int i = 0; i < allGenres.Count; i++) //calculate the score for each show in allGenres 
            {
                SeriesScore seriesScore = new SeriesScore();
                int score = 0;
                int value = 0;

                for (int j = 0; j < allGenres[i].genres.Length; j++) 
                {
                        if (genreScore.TryGetValue(allGenres[i].genres[j], out value))
                            score += value;
                }
                seriesScore.Score = score;
                seriesScore.SeriesId = allGenres[i].SeriesId;
                ssl.Add(seriesScore);
            }
            var ssl_distinct = ssl.GroupBy(s => s.SeriesId).Select(g => g.First()).ToList(); //remove same show duplicates
            return ssl_distinct.OrderBy(s => s.Score).ToList(); //order list by score
        }
        
        public Genre() { }
        public Genre(int userId, int seriesId, string[] genres)
        {
            this.UserId = userId;
            this.SeriesId = seriesId;
            this.Genres = genres;
        }

        public int UserId { get => userId; set => userId = value; }
        public int SeriesId { get => seriesId; set => seriesId = value; }
        public string[] Genres { get => genres; set => genres = value; }
    }
}