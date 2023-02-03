using DataBindingPractice.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DataBindingPractice
{

    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            WpfMVVMSample.MainWindow window = new MainWindow();
            UserViewModel VM = new UserViewModel();
            window.DataContext = VM;
            window.Show();
        }
    }
}
