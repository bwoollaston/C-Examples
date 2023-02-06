using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using DataBindingPractice.Model;

namespace DataBindingPractice.ViewModel
{
    internal class UserViewModel
    {
        private IList<User> _UserList;

        public UserViewModel()
        {
            _UserList = new List<User>
            {
                new User{UserId = 1,Firstname="Raj",Lastname="Beniwal",City="Delhi",State="DEL",Country="INDIA"},
                new User{UserId=2,Firstname="Mark",Lastname="henry",City="New York", State="NY", Country="USA"},
                new User{UserId=3,Firstname="Mahesh",Lastname="Chand",City="Philadelphia", State="PHL", Country="USA"},
                new User{UserId=4,Firstname="Vikash",Lastname="Nanda",City="Noida", State="UP", Country="INDIA"},
                new User{UserId=5,Firstname="Harsh",Lastname="Kumar",City="Ghaziabad", State="UP", Country="INDIA"},
                new User{UserId=6,Firstname="Reetesh",Lastname="Tomar",City="Mumbai", State="MP", Country="INDIA"},
                new User{UserId=7,Firstname="Deven",Lastname="Verma",City="Palwal", State="HP", Country="INDIA"},
                new User{UserId=8,Firstname="Ravi",Lastname="Taneja",City="Delhi", State="DEL", Country="INDIA"}
            };
        }
        public IList<User> Users
        {
            get { return _UserList; }
            set { _UserList = value; }
        }
        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null) mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        private class Updater : ICommand
        {
            public bool CanExecute(object parameter)
            {
                return true;
            }
            public event EventHandler CanExecuteChanged;
            public void Execute(object parameter)
            {

            }
        }
    }
}
