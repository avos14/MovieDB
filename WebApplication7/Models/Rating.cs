using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication7.Models.DAL;

namespace WebApplication7.Models
{
    public class Rating
    {
        int userId;
        int seriesId;
        int rate;

        public void insert()
        {
            DataServices ds = new DataServices();
            ds.insertRating(this);
        }
        //public bool Get()
        //{
        //    DataServices ds = new DataServices();
        //    return ds.GetUserRating(this);
        //}
        public List<int> GetUR(int userId)
        {
            DataServices ds = new DataServices();
            return ds.GetUserRating(userId);
        }
        public float Get(int seriesId)
        {
            DataServices ds = new DataServices();
            return ds.GetRatings(seriesId);
        }
        public void Update()
        {
            DataServices ds = new DataServices();
            ds.updateUserRating(this);
        }
        public Rating() { }
        public Rating(int userId, int seriesId, int rate)
        {
            this.userId = userId;
            this.seriesId = seriesId;
            this.rate = rate;
        }

        public int UserId { get => userId; set => userId = value; }
        public int SeriesId { get => seriesId; set => seriesId = value; }
        public int Rate { get => rate; set => rate = value; }
    }
}