using Microsoft.Extensions.Logging;
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
            string sql = @"select * from insert_movie(:_title, :_description, :_location, :_date, :_durationHour, :_durationMin, :_price, :_quota, :_imgUrl, :_genre, :_ageRate)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_title", movieItem.Title);
            cmd.Parameters.AddWithValue("_description", movieItem.Description);
            cmd.Parameters.AddWithValue("_location", movieItem.Location);
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
            else
            {
                MessageBox.Show("Movie gagal ditambahkan", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }
        public void insert(Event eventItem)
        {
            conn.Open();
            string sql = @"select * from insert_event(:_title, :_description, :_location, :_startDate, :_endDate, :_price, :_quota, :_imgUrl)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_title", eventItem.Title);
            cmd.Parameters.AddWithValue("_description", eventItem.Description);
            cmd.Parameters.AddWithValue("_location", eventItem.Location);
            cmd.Parameters.AddWithValue("_startDate", eventItem.StartDate);
            cmd.Parameters.AddWithValue("_endDate", eventItem.EndDate);
            cmd.Parameters.AddWithValue("_price", eventItem.Price);
            cmd.Parameters.AddWithValue("_quota", eventItem.Quota);
            cmd.Parameters.AddWithValue("_imgUrl", eventItem.ImgURL);

            if ((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Event berhasil ditambahkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Event gagal ditambahkan", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }

        public User login(string _username, string _password)
        {
            User user = new User();

            conn.Open();
            string sql = @"select * from login(:username, :password)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("username", _username);
            cmd.Parameters.AddWithValue("password", _password);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = (int)reader["_id"];
                    string username = (string)reader["_username"];
                    string password = (string)reader["_password"];
                    string name = (string)reader["_name"];
                    string email = (string)reader["_email"];
                    int phone = (int)reader["_phone"];
                    DateTime birth = (DateTime)reader["_birth"];
                    int role_id = (int)reader["_role_id"];
                    user.SetData(id, username, password, name, email, phone, birth, role_id);
                }
            }

            conn.Close();
            return user;
        }

        public List<History> getHistory(int id)
        {
            List<History> history = new List<History>();

            conn.Open();
            string sql = "select * from get_order_history(:_id)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_id", id);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string title = (string)reader["_title"];
                    string date = (string)reader["_date"];
                    string location = (string)reader["_location"];
                    string price = reader["_price"].ToString();
                    string qty = reader["_quantity"].ToString();
                    string total = reader["_total"].ToString();
                    string status = (string)reader["_status"];
                    History result = new History(title, date, location, price, qty, total, status);

                    history.Add(result);
                }
            }

            conn.Close();
            return history;
        }

        public List<Transaction> getHistoryAdmin()
        {
            List<Transaction> history = new List<Transaction>();

            conn.Open();
            string sql = "select * from get_order_history_admin()";
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string title = (string)reader["_title"];
                    string date = (string)reader["_date"];
                    string location = (string)reader["_location"];
                    string price = reader["_price"].ToString();
                    string qty = reader["_quantity"].ToString();
                    string total = reader["_total"].ToString();
                    string status = (string)reader["_status"];

                    Transaction result = new Transaction(title, date, location, price, qty, total, status);
                    history.Add(result);
                }
            }

            conn.Close();
            return history;
        }

        public Boolean order_movie(int movie_id, int user_id, int qty, int amount, string file)
        {
            conn.Open();
            string result = "0";
            string sql = @"select * from order_movie(:movie_id, :user_id, :qty, :amount, :file)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("movie_id", movie_id);
            cmd.Parameters.AddWithValue("user_id", user_id);
            cmd.Parameters.AddWithValue("qty", qty);
            cmd.Parameters.AddWithValue("amount", amount);
            cmd.Parameters.AddWithValue("file", file);

            var firstColumn = cmd.ExecuteScalar();
            if (firstColumn != null)
            {
                result = firstColumn.ToString();
            }

            return result == "0" ? false : true;
        }

        public Boolean order_event(int event_id, int user_id, int qty, int amount, string file)
        {
            conn.Open();
            string result = "0";
            string sql = @"select * from order_event(:event_id, :user_id, :qty, :amount, :file)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("event_id", event_id);
            cmd.Parameters.AddWithValue("user_id", user_id);
            cmd.Parameters.AddWithValue("qty", qty);
            cmd.Parameters.AddWithValue("amount", amount);
            cmd.Parameters.AddWithValue("file", file);

            var firstColumn = cmd.ExecuteScalar();
            if (firstColumn != null)
            {
                result = firstColumn.ToString();
            }

            return result == "0" ? false : true;
        }

        public void update(Movie movieItem)
        {
            conn.Open();
            string sql = @"select * from update_movie(:_id, :_title, :_description, :_location, :_date, :_durationHour, :_durationMin, :_price, :_quota, :_imgUrl, :_genre, :_ageRate)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_id", movieItem.MovieID);
            cmd.Parameters.AddWithValue("_title", movieItem.Title);
            cmd.Parameters.AddWithValue("_description", movieItem.Description);
            cmd.Parameters.AddWithValue("_location", movieItem.Location);
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
                MessageBox.Show("Movie berhasil diupdate", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Movie gagal diupdate", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }

        public void update(Event eventItem)
        {
            conn.Open();
            string sql = @"select * from update_event(:_id, :_title, :_description, :_location, :_start_date, :_end_date, :_price, :_quota, :_imgUrl)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_id", eventItem.EventID);
            cmd.Parameters.AddWithValue("_title", eventItem.Title);
            cmd.Parameters.AddWithValue("_description", eventItem.Description);
            cmd.Parameters.AddWithValue("_location", eventItem.Location);
            cmd.Parameters.AddWithValue("_start_date", eventItem.StartDate);
            cmd.Parameters.AddWithValue("_end_date", eventItem.EndDate);
            cmd.Parameters.AddWithValue("_price", eventItem.Price);
            cmd.Parameters.AddWithValue("_quota", eventItem.Quota);
            cmd.Parameters.AddWithValue("_imgUrl", eventItem.ImgURL);

            if ((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Event berhasil diupdate", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Event gagal diupdate", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }
    }
}
