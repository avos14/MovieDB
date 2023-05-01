using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Text;
using System.Data;

namespace WebApplication7.Models.DAL
{
    public class DataServices
    {
        public void insertGenre(Genre g)
        {
            SqlConnection con;
            SqlCommand cmd;

            try
            {
                con = connect("DBConnectionString"); // create the connection
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }

            String cStr = BuildInsertCommand(g);      // helper method to build the insert string

            cmd = CreateCommand(cStr, con);             // create the command

            try
            {
                int numEffected = cmd.ExecuteNonQuery();
                // execute the command
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    return;
                }
                else throw;
            }

            finally
            {
                if (con != null)
                {
                    // close the db connection
                    con.Close();
                }
            }
        }
        public int updateUserRating(Rating r)
        {
            SqlConnection con;
            SqlCommand cmd;

            try
            {
                con = connect("DBConnectionString"); // create the connection
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }

            String cStr = BuildInsertCommand(r);      // helper method to build the insert string

            cmd = CreateCommand(cStr, con);             // create the command

            try
            {
                int numEffected = cmd.ExecuteNonQuery();
                // execute the command
                return numEffected;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }

            finally
            {
                if (con != null)
                {
                    // close the db connection
                    con.Close();
                }
            }
        }
        public void insertRating(Rating r)
        {
            SqlConnection con;

            try
            {
                con = connect("DBConnectionString"); // create the connection
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }

            string commandText = "INSERT INTO Rating_2021 (userId, seriesId, rating)"
                + "values(@userId, @seriesId, @rating)";

            using (con)
            {
                SqlCommand command = new SqlCommand(commandText, con);
                command.Parameters.AddWithValue("@userId", r.UserId);
                command.Parameters.AddWithValue("@seriesId", r.SeriesId);
                command.Parameters.AddWithValue("@rating", r.Rate);

                try
                {
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        return;
                    }
                    else throw;
                }
                finally
                {
                    if (con != null)
                    {
                        // close the db connection
                        con.Close();
                    }
                }
            }
        }
        public void insertEpisode(Episode e)
        {
            SqlConnection con;

            try
            {
                con = connect("DBConnectionString"); // create the connection
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }
            
            string commandText = "INSERT INTO Episode_2021 (episodeID, episodeName, seasonNum,seriesName, episodeImg, episodeOverview, episodeAirdate, seriesID)" 
                + "values(@episodeID, @episodeName, @seasonNum, @seriesName, @episodeImg, @episodeOverview, @episodeAirdate, @seriesID)";

            using (con)
            {
                SqlCommand command = new SqlCommand(commandText, con);
                command.Parameters.AddWithValue("@episodeID", e.EpisodeID);
                command.Parameters.AddWithValue("@episodeName", e.EpisodeName);
                command.Parameters.AddWithValue("@seasonNum", e.SeasonNum);
                command.Parameters.AddWithValue("@seriesName", e.SeriesName);
                command.Parameters.AddWithValue("@episodeImg", e.EpisodeImg);
                command.Parameters.AddWithValue("@episodeOverview", e.EpisodeOverview);
                command.Parameters.AddWithValue("@episodeAirdate", e.EpisodeAirdate);
                command.Parameters.AddWithValue("@seriesID", e.SeriesID);
                try
                {
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        return;
                    }
                    else throw;
                }
                finally
                {
                    if (con != null)
                    {
                        // close the db connection
                        con.Close();
                    }
                }
            }
        }
        public void insertSeries(Series s)
        {
            SqlConnection con;

            try
            {
                con = connect("DBConnectionString"); // create the connection
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }

            string commandText = "INSERT INTO Series_2021 (seriesID, first_air_date, name, origin_country, original_language, overview, popularity, poster_path)"
                + "values(@seriesID, @first_air_date, @name, @origin_country, @original_language, @overview, @popularity, @poster_path)";

            using (con)
            {
                SqlCommand command = new SqlCommand(commandText, con);
                command.Parameters.AddWithValue("@seriesID", s.Id);
                command.Parameters.AddWithValue("@first_air_date", s.First_air_date);
                command.Parameters.AddWithValue("@name", s.Name);
                command.Parameters.AddWithValue("@origin_country", s.Origin_country);
                command.Parameters.AddWithValue("@original_language", s.Original_language);
                command.Parameters.AddWithValue("@overview", s.Overview);
                command.Parameters.AddWithValue("@popularity", s.Popularity);
                command.Parameters.AddWithValue("@poster_path", s.Poster_path);  
                try
                {
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        return;
                    }
                    else throw;
                }
                finally
                {
                    if (con != null)
                    {
                        // close the db connection
                        con.Close();
                    }
                }
            }
        }
        public int insertPref(Preference obj)
        {
            SqlConnection con;
            SqlCommand cmd;

            try
            {
                con = connect("DBConnectionString"); // create the connection
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }

            String cStr = BuildInsertCommand(obj);      // helper method to build the insert string

            cmd = CreateCommand(cStr, con);             // create the command

            try
            {
                int numEffected = cmd.ExecuteNonQuery();
                // execute the command
                return numEffected;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }

            finally
            {
                if (con != null)
                {
                    // close the db connection
                    con.Close();
                }
            }

        }
        private String BuildInsertCommand(Genre g)
        {
            String command;
            string genre = "";
            int len = g.Genres.Length;

            for (int i = 0; i < len; i++)
            {
                genre += g.Genres[i];
                if (i + 1 != len)
                    genre += ",";
            }

            StringBuilder sb = new StringBuilder();
            // use a string builder to create the dynamic string
            sb.AppendFormat("Values({0}, {1}, '{2}')", g.UserId, g.SeriesId, genre);
            String prefix = "INSERT INTO Genres_2021 " + "([userID], [seriesID], [genres])";
            command = prefix + sb.ToString();

            return command;
        }
        private String BuildInsertCommand(Rating r)
        {
            String command;

            StringBuilder sb = new StringBuilder();
            // use a string builder to create the dynamic string
            String prefix = "update [Rating_2021] set rating=" + r.Rate + "where userId=" + r.UserId + " and seriesId=" +  r.SeriesId;
            command = prefix + sb.ToString();

            return command;
        }
        private String BuildInsertCommand(Preference obj)
        {
            String command;

            StringBuilder sb = new StringBuilder();
            // use a string builder to create the dynamic string
            sb.AppendFormat("Values({0}, {1}, {2})",obj.U, obj.E.EpisodeID, obj.S.Id);
            String prefix = "INSERT INTO Preferences_2021 " + "([userID], [episodeID], [seriesID]) ";
            command = prefix + sb.ToString();

            return command;
        }
        public int insertUser(User user)
        {
            SqlConnection con;
            SqlCommand cmd;

            try
            {
                con = connect("DBConnectionString"); // create the connection
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }

            String cStr = BuildInsertCommand(user);      // helper method to build the insert string

            cmd = CreateCommand(cStr, con);             // create the command

            try
            {
                int numEffected = cmd.ExecuteNonQuery();
                // execute the command
                return numEffected;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }

            finally
            {
                if (con != null)
                {
                    // close the db connection
                    con.Close();
                }
            }

        }
        private String BuildInsertCommand(User user)
        {
            String command;

            StringBuilder sb = new StringBuilder();
            // use a string builder to create the dynamic string
            sb.AppendFormat("Values('{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}','{7}','{8}')",
                user.Fname, user.Lname, user.Email, user.Password, user.Pnumber, user.Gender, user.BirthYear, user.PGenre, user.Address);
            String prefix = "INSERT INTO Users_2021 " + "([fname], [lname], [email], [password], [pnumber], [gender], [birthYear], [pGenre], [address]) ";
            command = prefix + sb.ToString();

            return command;
        }

        public SqlConnection connect(String conString)
        {

            // read the connection string from the configuration file
            string cStr = WebConfigurationManager.ConnectionStrings[conString].ConnectionString;
            SqlConnection con = new SqlConnection(cStr);
            con.Open();
            return con;
        }
        private SqlCommand CreateCommand(String CommandSTR, SqlConnection con)
        {  

            SqlCommand cmd = new SqlCommand(); // create the command object

            cmd.Connection = con;              // assign the connection to the command object

            cmd.CommandText = CommandSTR;      // can be Select, Insert, Update, Delete 

            cmd.CommandTimeout = 10;           // Time to wait for the execution' The default is 30 seconds

            cmd.CommandType = System.Data.CommandType.Text; // the type of the command, can also be stored procedure

            return cmd;
        }
        public List<string> getUserGenres(int id)
        {
            List<string> GenreArray = new List<string>();
            string[] tmpArr;
            string s = "";
            SqlConnection con = null;

            try
            {
                con = connect("DBConnectionString"); // create a connection to the database using the connection String defined in the web config file

                String selectSTR = "select genres from Genres_2021 where userId=" + id;
                SqlCommand cmd = new SqlCommand(selectSTR, con);

                // get a reader
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // CommandBehavior.CloseConnection: the connection will be closed after reading has reached the end

                while (dr.Read())
                {   // Read till the end of the data into a row
                    s = (string)dr["genres"];
                    tmpArr = s.Split(',');
                    for (int i = 0; i < tmpArr.Length; i++)
                        GenreArray.Add(tmpArr[i]);
                }

                return GenreArray;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }
        }
        public List<Genre> getAllGenre(int id)
        {
            List<int> seriesList = getUserSeriesList(id);
            
            List<Genre> GenreList = new List<Genre>();

            string[] tmpArr;
            SqlConnection con = null;

            string s = "";
            for(int i = 0; i< seriesList.Count; i++)
            {
                s += " and seriesID!=" + seriesList[i] + " ";
            }
            try
            {
                con = connect("DBConnectionString"); // create a connection to the database using the connection String defined in the web config file

                String selectSTR = "select * from Genres_2021 where userID!=" + id + s;
                SqlCommand cmd = new SqlCommand(selectSTR, con);

                // get a reader
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // CommandBehavior.CloseConnection: the connection will be closed after reading has reached the end

                while (dr.Read())
                {   // Read till the end of the data into a row
                    Genre g = new Genre();
                    s = (string)dr["genres"];
                    tmpArr = s.Split(',');
                    g.Genres = tmpArr;
                    g.SeriesId = Convert.ToInt32(dr["seriesID"]);
                    GenreList.Add(g);
                }

                return GenreList;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }
        }
        public List<int> getUserSeriesList(int id)
        {
            List<int> seriesList = new List<int>();
            int s;
            SqlConnection con = null;

            try
            {
                con = connect("DBConnectionString"); // create a connection to the database using the connection String defined in the web config file

                String selectSTR = "select seriesID from Genres_2021 where userID=" + id;
                SqlCommand cmd = new SqlCommand(selectSTR, con);

                // get a reader
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // CommandBehavior.CloseConnection: the connection will be closed after reading has reached the end

                while (dr.Read())
                {   // Read till the end of the data into a row
                    seriesList.Add(Convert.ToInt32(dr["seriesID"]));
                }

                return seriesList;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }
        }
        public List<int> GetUserRating(int userId)
        {
            List<int> li = new List<int>();
            SqlConnection con = null;

            try
            {
                con = connect("DBConnectionString"); // create a connection to the database using the connection String defined in the web config file

                String selectSTR = "select seriesId from Rating_2021 where userId=" + userId;
                SqlCommand cmd = new SqlCommand(selectSTR, con);

                // get a reader
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // CommandBehavior.CloseConnection: the connection will be closed after reading has reached the end

                while (dr.Read())
                {   // Read till the end of the data into a row
                    li.Add(Convert.ToInt32(dr["seriesId"]));
                }
                return li;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }
        }
        public float GetRatings(int seriesId)
        {
            SqlConnection con = null;
            List<int> il = new List<int>();

            try
            {
                con = connect("DBConnectionString"); // create a connection to the database using the connection String defined in the web config file

                String selectSTR = "select rating from Rating_2021 where seriesId=" + seriesId;
                SqlCommand cmd = new SqlCommand(selectSTR, con);

                // get a reader
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // CommandBehavior.CloseConnection: the connection will be closed after reading has reached the end

                while (dr.Read())
                {   // Read till the end of the data into a row
                    il.Add(Convert.ToInt32(dr["rating"]));
                }
                float rating = 0;
                if (il.Count != 0)
                {
                    foreach (int r in il)
                    {
                        rating += r;
                    }
                    rating = rating / il.Count();
                    return rating;
                }
                else return 0;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }
        }
        public List<Series> GetSeries()
        {
            SqlConnection con = null;
            List<Series> sl = new List<Series>();

            try
            {
                con = connect("DBConnectionString"); // create a connection to the database using the connection String defined in the web config file

                String selectSTR = "select * from Series_2021";
                SqlCommand cmd = new SqlCommand(selectSTR, con);

                // get a reader
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // CommandBehavior.CloseConnection: the connection will be closed after reading has reached the end

                while (dr.Read())
                {   // Read till the end of the data into a row
                    Series s = new Series();

                    s.Id = Convert.ToInt32(dr["seriesID"]);
                    s.Name = (string)dr["name"];
                    s.Origin_country = (string)dr["origin_country"];
                    s.Original_language = (string)dr["original_language"];
                    s.Popularity = Convert.ToInt32(dr["popularity"]);

                    sl.Add(s);
                }
                List<Preference> pl = getPrefList();
                foreach(Series s in sl)
                {
                    for(int i = 0; i<pl.Count; i++)
                    {
                        if (s.Id == pl[i].S.Id)
                        {
                            s.FavCount++;
                            pl.RemoveAt(i);
                        }

                    }
                }
                return sl;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }
        }
        public List<Episode> GetEpisodes()
        {
            SqlConnection con = null;
            List<Episode> el = new List<Episode>();

            try
            {
                con = connect("DBConnectionString"); // create a connection to the database using the connection String defined in the web config file

                String selectSTR = "select * from Episode_2021";
                SqlCommand cmd = new SqlCommand(selectSTR, con);

                // get a reader
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // CommandBehavior.CloseConnection: the connection will be closed after reading has reached the end

                while (dr.Read())
                {   // Read till the end of the data into a row
                    Episode e = new Episode();

                    e.EpisodeID = Convert.ToInt32(dr["episodeID"]);
                    e.SeriesName = (string)dr["seriesName"];
                    e.EpisodeName = (string)dr["episodeName"];
                    e.EpisodeAirdate = (string)dr["episodeAirdate"];
                    e.SeasonNum = Convert.ToInt32(dr["seasonNum"]);

                    el.Add(e);
                }
                List<Preference> pl = getPrefList();
                foreach (Episode e in el)
                {
                    for (int i = 0; i < pl.Count; i++)
                    {
                        if (e.EpisodeID == pl[i].E.EpisodeID)
                        {
                            e.FavCount++;
                            pl.RemoveAt(i);
                        }
                    }
                }
                return el;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }
        }
        public List<Preference> getPrefList()
        {
            {
                SqlConnection con = null;
                List<Preference> pl = new List<Preference>();

                try
                {
                    con = connect("DBConnectionString"); // create a connection to the database using the connection String defined in the web config file

                    String selectSTR = "select * from Preferences_2021";
                    SqlCommand cmd = new SqlCommand(selectSTR, con);

                    // get a reader
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // CommandBehavior.CloseConnection: the connection will be closed after reading has reached the end

                    while (dr.Read())
                    {   // Read till the end of the data into a row
                        Preference p = new Preference();
                        Series s = new Series();
                        Episode e = new Episode();

                        p.U = Convert.ToInt32(dr["userID"]);
                        s.Id = Convert.ToInt32(dr["seriesID"]);
                        p.S = s;
                        e.EpisodeID = Convert.ToInt32(dr["episodeID"]);
                        p.E = e;


                        pl.Add(p);
                    }

                    return pl;
                }
                catch (Exception ex)
                {
                    // write to log
                    throw (ex);
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }

                }
            }
        }
        public List<string> GetSeries(int id)
        {
            SqlConnection con = null;
            List<string> seriesList = new List<string>();

            try
            {
                con = connect("DBConnectionString"); // create a connection to the database using the connection String defined in the web config file

                String selectSTR = "select distinct name from Series_2021 as s inner join Preferences_2021 as p on p.seriesID = s.seriesID where userID = " + id;
                SqlCommand cmd = new SqlCommand(selectSTR, con);

                // get a reader
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // CommandBehavior.CloseConnection: the connection will be closed after reading has reached the end

                while (dr.Read())
                {   // Read till the end of the data into a row
                    seriesList.Add((string)dr["name"]);
                }

                return seriesList;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }
        }
        public List<Episode> GetEpisodes(string series, int id)
        {
            SqlConnection con = null;
            int seriesID = GetSeriesID(series);
            List<Episode> episodesList = new List<Episode>();

            try
            {
                con = connect("DBConnectionString"); // create a connection to the database using the connection String defined in the web config file

                String selectSTR = "select * from Episode_2021 as e inner join Preferences_2021 as p on p.episodeID = e.episodeID where userID = " + id +" and e.seriesID = " + seriesID;
                SqlCommand cmd = new SqlCommand(selectSTR, con);

                // get a reader
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // CommandBehavior.CloseConnection: the connection will be closed after reading has reached the end

                while (dr.Read())
                {   // Read till the end of the data into a row
                    Episode e = new Episode();
                    e.EpisodeName = (string)dr["episodeName"];
                    e.SeasonNum = Convert.ToInt32(dr["seasonNum"]);
                    e.EpisodeOverview = (string)dr["episodeOverview"];
                    e.EpisodeImg = (string)dr["episodeImg"];
                    e.EpisodeAirdate = (string)dr["episodeAirdate"];
                    episodesList.Add(e);
                }

                return episodesList;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }
        }
        public int GetSeriesID(string series)
        {
            SqlConnection con = null;
            int seriesID = 0;

            try
            {
                con = connect("DBConnectionString"); // create a connection to the database using the connection String defined in the web config file

                String selectSTR = "select seriesID from Series_2021 where name = '" + series + "'";
                SqlCommand cmd = new SqlCommand(selectSTR, con);

                // get a reader
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // CommandBehavior.CloseConnection: the connection will be closed after reading has reached the end

                while (dr.Read())
                {   // Read till the end of the data into a row
                    seriesID = Convert.ToInt32(dr["seriesID"]);
                }

                return seriesID;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }
        }


        public List<User> getUsers()
        {

            SqlConnection con = null;
            List<User> ul = new List<User>();

            try
            {
                con = connect("DBConnectionString"); // create a connection to the database using the connection String defined in the web config file

                String selectSTR = "SELECT * FROM Users_2021";
                SqlCommand cmd = new SqlCommand(selectSTR, con);

                // get a reader
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // CommandBehavior.CloseConnection: the connection will be closed after reading has reached the end

                while (dr.Read())
                {   // Read till the end of the data into a row
                    User u = new User();

                    u.UserId = Convert.ToInt32(dr["userID"]);
                    u.Fname = (string)dr["fname"];
                    u.Lname = (string)dr["lname"];
                    u.Email = (string)dr["email"];
                    u.Password = (string)dr["password"];
                    u.Pnumber = (string)dr["pnumber"];
                    u.Gender = (string)dr["gender"];
                    u.BirthYear = Convert.ToInt32(dr["birthYear"]);
                    u.PGenre = (string)dr["pGenre"];
                    u.Address = (string)dr["address"];
                    u.IsAdmin = Convert.ToBoolean(dr["admin"]);

                    ul.Add(u);
                }

                return ul;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }

        }

        public User getUsers(string email)
        {

            SqlConnection con = null;
            User u = null;

            try
            {
                con = connect("DBConnectionString"); // create a connection to the database using the connection String defined in the web config file

                String selectSTR = "SELECT * FROM Users_2021 WHERE email='" + email + "'";
                SqlCommand cmd = new SqlCommand(selectSTR, con);

                // get a reader
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // CommandBehavior.CloseConnection: the connection will be closed after reading has reached the end

                while (dr.Read())
                {   // Read till the end of the data into a row
                    u = new User();

                    u.Email = (string)dr["email"];
                    u.Password = (string)dr["password"];
                    u.Fname = (string)dr["fname"];
                    u.UserId = Convert.ToInt32(dr["userID"]);
                    u.IsAdmin = Convert.ToBoolean(dr["admin"]);
                }

                return u;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }

        }
    }
}