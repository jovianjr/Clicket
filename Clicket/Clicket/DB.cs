using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clicket
{
    internal class DB
    {
        public NpgsqlConnection conn;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private string connstring = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=clicket";


        public DB()
        {
            conn = new NpgsqlConnection(connstring);
        }

        public List<Movie> getMovies()
        {
            List<Movie> movies = new List<Movie>();

            conn.Open();
            string sql = "select * from get_movies()";
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Movie result = new Movie();
                    result.MovieID = (int)reader["_id"];
                    result.Title = (string)reader["_title"];
                    result.Description = (string)reader["_description"];
                    result.Location = (string)reader["_location"];
                    result.Date = (DateTime)reader["_date"];
                    result.DurationHour = (int)reader["_duration_hour"];
                    result.DurationMin = (int)reader["_duration_min"];
                    result.Price = (int)reader["_price"];
                    result.Quota = (int)reader["_quota"];
                    result.ImgURL = reader["_image"] as string ?? "";
                    result.Genre = (string[])reader["_genre"];
                    result.ageRate = (string)reader["_agerate"];
                    movies.Add(result);
                }
            }

            conn.Close();
            return movies;
        }

        public List<Event> getEvents()
        {
            List<Event> events = new List<Event>();

            conn.Open();
            string sql = "select * from get_events()";
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Event result = new Event();
                    result.EventID = (int)reader["_id"];
                    result.Title = (string)reader["_title"];
                    result.Description = (string)reader["_description"];
                    result.Location = (string)reader["_location"];
                    result.StartDate = (DateTime)reader["_start_date"];
                    result.EndDate = (DateTime)reader["_end_date"];
                    result.Quota = (int)reader["_quota"];
                    result.Price = (int)reader["_price"];
                    result.ImgURL = reader["_image"] as string ?? "";
                    events.Add(result);
                }
            }

            conn.Close();
            return events;
        }

        public void insert(Movie movieItem)
        {
            conn.Open();
            string sql = @"select * from insert_movie(:_title, :_description, :_date, :_durationHour, :_durationMin, :_price, :_quota, :_imgUrl, :_genre, :_ageRate)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_title", movieItem.Title);
            cmd.Parameters.AddWithValue("_description", movieItem.Description);
            cmd.Parameters.AddWithValue("_date", movieItem.Date);
            cmd.Parameters.AddWithValue("_durationHour", movieItem.DurationHour);
            cmd.Parameters.AddWithValue("_durationMin", movieItem.DurationMin);
            cmd.Parameters.AddWithValue("_price", movieItem.Price);
            cmd.Parameters.AddWithValue("_quota", movieItem.Quota);
            cmd.Parameters.AddWithValue("_imgUrl", movieItem.ImgURL);
            cmd.Parameters.AddWithValue("_genre", movieItem.Genre);
            cmd.Parameters.AddWithValue("_ageRate", movieItem.ageRate);

            if ((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Movie berhasil ditambahkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            conn.Close();
        }
        public void insert(Event eventItem)
        {
            conn.Open();
            string sql = @"select * from insert_event(:_title, :_description, :_startDate, :_endDate, :_price, :_quota, :_imgUrl)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_title", eventItem.Title);
            cmd.Parameters.AddWithValue("_description", eventItem.Description);
            cmd.Parameters.AddWithValue("_startDate", eventItem.StartDate);
            cmd.Parameters.AddWithValue("_endDate", eventItem.EndDate);
            cmd.Parameters.AddWithValue("_price", eventItem.Price);
            cmd.Parameters.AddWithValue("_quota", eventItem.Quota);
            cmd.Parameters.AddWithValue("_imgUrl", eventItem.ImgURL);

            if ((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Event berhasil ditambahkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            conn.Close();
        }
    }
}
