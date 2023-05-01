using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication7.Models.DAL;

namespace WebApplication7.Models
{
    public class Episode
    {
        string seriesName;
        int episodeID;
        int seriesID;
        int seasonNum;
        string episodeName;
        string episodeImg;
        string episodeOverview;
        string episodeAirdate;
        int favCount;

        public Episode(){ }

        public List<Episode> Get()
        {
            DataServices ds = new DataServices();
            return ds.GetEpisodes();
        }
        public List<Episode> Get(string series, int id)
        {
            DataServices ds = new DataServices();
            return ds.GetEpisodes(series, id);
        }
        public int EpisodeID { get => episodeID; set => episodeID = value; }
        public int SeasonNum { get => seasonNum; set => seasonNum = value; }
        public string EpisodeName { get => episodeName; set => episodeName = value; }
        public string EpisodeImg { get => episodeImg; set => episodeImg = value; }
        public string EpisodeOverview { get => episodeOverview; set => episodeOverview = value; }
        public string EpisodeAirdate { get => episodeAirdate; set => episodeAirdate = value; }
        public string SeriesName { get => seriesName; set => seriesName = value; }
        public int SeriesID { get => seriesID; set => seriesID = value; }
        public int FavCount { get => favCount; set => favCount = value; }
    } 
}