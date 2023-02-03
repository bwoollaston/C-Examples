using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingPractice.Model
{
    public class User : INotifyPropertyChanged
    {
        private int userId;
        private string firstname;
        private string lastname;
        private string city;
        private string state;
        private string country;
        public int UserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
                OnPropertyChanged("UserId")
            }
        }
        public string Firstname
        {
            get 
            { 
                return firstname; 
            }
            set
            {
                firstname = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
                OnPropertyChanged("LastName");
            }
        }
        public string City
        {
            get
            {
                return City;
            }
            set
            {
                City = value;
                OnPropertyChanged("City");
            }
        }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                OnPropertyChanged("State");
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
