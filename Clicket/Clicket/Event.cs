﻿using System;

namespace Clicket
{ 
	public class Event
	{
		private int _eventID;
		private string _title;
		private string _description;
		private string _location;
        private DateTime _startDate;
		private DateTime _endDate;
        private int _price;
		private int _quota;
		private string _imgURL;

		public int EventID
		{
			get { return _eventID; }
            set { _eventID = value; }
        }

		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		public string Description
		{
			get { return _description; }
			set { _description = value; }
        }
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public DateTime StartDate
		{
			get { return _startDate; }
			set { _startDate = value; }
		}

		public DateTime EndDate
		{
			get { return _endDate; }
			set { _endDate = value; }
		}

        public int Price
		{
			get { return _price; }
			set { _price = value; }
		}

		public int Quota
		{
			get { return _quota; }
			set { _quota = value; }
		}

		public string ImgURL
		{
			get { return _imgURL; }
			set { _imgURL = value; }
		}

		public bool BuyTicket(int eventID)
		{
            return false;
        }
	}
}
