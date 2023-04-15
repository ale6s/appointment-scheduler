namespace Scheduling
{
    internal class AppointmentInfo
    {
        private int _customerId;
        private string _petName;
        private string _petBreed;
        private int _petAge;
        private string _email;
        private string _purposeVisit;
        private string _otherConcerns;
        private string _startDate;
        private string _endDate;

        public AppointmentInfo()
        { }

        public AppointmentInfo(int customerId, string petName, string petBreed, int petAge, string email, string purposeVisit, string otherConcerns, string startDate, string endDate)
        {
            this._customerId = customerId;
            this._petName = petName;
            this._petBreed = petBreed;
            this._petAge = petAge;
            this._email = email;
            this._purposeVisit = purposeVisit;
            this._otherConcerns = otherConcerns;
            this._startDate = startDate;
            this._endDate = endDate;
        }

        public int CustomerId
        { get { return _customerId; } set { _customerId = value; } }
        public string PetName
        { get { return _petName; } set { _petName = value; } }
        public string PetBreed
        { get { return _petBreed; } set { _petBreed = value; } }
        public int PetAge
        { get { return _petAge; } set { _petAge = value; } }
        public string Email
        { get { return _email; } set { _email = value; } }
        public string PurposeVisit
        { get { return _purposeVisit; } set { _purposeVisit = value; } }
        public string OtherConcerns
        { get { return _otherConcerns; } set { _otherConcerns = value; } }
        public string StartDate
        { get { return _startDate; } set { _startDate = value; } }
        public string EndDate
        { get { return _endDate; } set { _endDate = value; } }
    }
}