using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication7.Models;
using WebApplication7.Models.DAL;

namespace WebApplication7.Models
{
    public class Preference
    {
        Series s;
        Episode e;
        int u;


        public void insert()
        {
            DataServices ds = new DataServices();
            ds.insertSeries(s);
            ds.insertEpisode(e);
            ds.insertPref(this);
        }
        public Preference() { }
        public Preference(Series s, Episode e, int u)
        {
            this.S = s;
            this.E = e;
            this.U = u;
        }

        public Series S { get => s; set => s = value; }
        public Episode E { get => e; set => e = value; }
        public int U { get => u; set => u = value; }
    }
}