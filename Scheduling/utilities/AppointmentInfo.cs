namespace Scheduling
{
    class AppointmentInfo
    {
        private int _customerId;
        private string _title;
        private string _description;
        private string _location;
        private string _contact;
        private string _type;
        private string _url;
        private string _startDate;
        private string _endDate;

        public AppointmentInfo() { }
        public AppointmentInfo(int customerId, string title, string description, string location, string contact, string type, string url, string startDate, string endDate)
        {
            this._customerId = customerId;
            this._title = title;
            this._description = description;
            this._location = location;
            this._contact = contact;
            this._type = type;
            this._url = url;
            this._startDate = startDate;
            this._endDate = endDate;
        }

        public int CustomerId { get { return _customerId; } set { _customerId = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string Location { get { return _location; } set { _location = value; } }
        public string Contact { get { return _contact; } set { _contact = value; } }
        public string Type { get { return _type; } set { _type = value; } }
        public string Url { get { return _url; } set { _url = value; } }
        public string StartDate { get { return _startDate; } set { _startDate = value; } }
        public string EndDate { get { return _endDate; } set { _endDate = value; } }

    }
}
