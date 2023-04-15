namespace Scheduling
{
    public class CustomerInfo
    {
        //protected int _customerId;
        protected string _customerName;
        private string _address;
        private string _address2;
        private string _city;
        private string _country;
        private string _zipCode;
        private string _phone;
        private int _active;

        public CustomerInfo() { }

        public CustomerInfo(string customerName, string address, string address2, string city, string country, string zipCode, string phone, int active)
        {
            //this._customerId = customerId;
            this._customerName = customerName;
            this._address = address;
            this._address2 = address2;
            this._city = city;
            this._country = country;
            this._zipCode = zipCode;
            this._phone = phone;
            this._active = active;
        }

        // public int CustomerId { get { return _customerId; } set { _customerId = value; } }
        public string CustomerName { get { return _customerName; } set { _customerName = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public string Address2 { get { return _address2; } set { _address2 = value; } }
        public string City { get { return _city; } set { _city = value; } }
        public string Country { get { return _country; } set { _country = value; } }
        public string ZipCode { get { return _zipCode; } set { _zipCode = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }
        public int Active { get { return _active; } set { _active = value; } }

    }
}
