﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clicket
{
    internal class Action
    {
        DB db = new DB();
        public void add(Movie movieItem)
        {
            db.insert(movieItem);
        }
        public void add(Event eventItem)
        {
            db.insert(eventItem);
        }
        public User login(string _username, string _password)
        {
            return db.login(_username, _password);
        }

        public List<Movie> getMovieList()
        {
            return db.getMovies();
        }

        public List<Event> getEventList()
        {
            return db.getEvents();
        }

        public List<History> getHistoryList(int _id)
        {
            return db.getHistory(_id);
        }

    }
}
