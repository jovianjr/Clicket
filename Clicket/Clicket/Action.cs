using Npgsql;
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


    }
}
