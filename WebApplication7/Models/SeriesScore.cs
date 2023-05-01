using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class SeriesScore
    {
        int score;
        int seriesId;

        public SeriesScore() { }
        public SeriesScore(int score, int seriesId)
        {
            this.score = score;
            this.seriesId = seriesId;
        }

        public int Score { get => score; set => score = value; }
        public int SeriesId { get => seriesId; set => seriesId = value; }
    }
}