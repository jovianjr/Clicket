using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum TicketStatus
{
    Verified,
    NotVerified,
    Progres
}

namespace Clicket
{
    class Admin : User
    {
        public Boolean MakeEvent(string title, string description, DateTime startDate, DateTime endDate, int price, int quota, string imgURL)
        {
            return false;
        }

        public Boolean UpdateEvent(string title, string description, DateTime startDate, DateTime endDate, int price, int quota, string imgURL)
        {
            return false;
        }

        public Boolean DeleteEvent(int eventID)
        {
            return false;
        }

        public Boolean MakeMovie(string title, string description, DateTime date, int durationHour, int durationMin, int price, int quota, string imgURL, string[] genre, string ageRate)
        {
            return false;
        }

        public Boolean UpdateMovie(string title, string description, DateTime date, int durationHour, int durationMin, int price, int quota, string imgURL, string[] genre, string ageRate)
        {
            return false;
        }

        public Boolean DeleteMovie(int movieID)
        {
            return false;
        }

        public Boolean ConfirmEventTicket(int userID, int eventID, TicketStatus status)
        {
            return false;
        }

        public Boolean ConfirmMovieTicket(int userID, int eventID, TicketStatus status)
        {
            return false;
        }
    }
}
