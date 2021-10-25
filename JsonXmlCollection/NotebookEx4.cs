using System;
using System.Collections.Generic;
using System.Text;

namespace JsonXmlCollection
{
    class NotebookEx4
    {
        private string _name;
        private string _street;
        private int _numberHouse;
        private int _numberApartment;
        private string _numberPhone;
        private string _numberHomePhone;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        public int NumberHouse
        {
            get { return _numberHouse; }
            set { _numberHouse = value; }
        }
        public int NumberApartment
        {
            get { return _numberApartment; }
            set { _numberApartment = value; }
        }
        public string NumberPhone
        {
            get { return _numberPhone; }
            set { _numberPhone = value; }
        }
        public string NumberHomePhone
        {
            get { return _numberHomePhone; }
            set { _numberHomePhone = value; }
        }

        public NotebookEx4(string Name, string Street, int NumberHouse, int NumberApartment, string NumberPhone, string NumberHomePhone)
        {
            _name = Name;
            _street = Street;
            _numberHouse = NumberHouse;
            _numberApartment = NumberApartment;
            _numberPhone = NumberPhone;
            _numberHomePhone = NumberHomePhone;
        }
    }
}
