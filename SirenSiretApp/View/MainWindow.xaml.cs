using SirenSiretApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace SirenSiretApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowBusiness windowBusiness = new MainWindowBusiness();
            this.DataContext = windowBusiness;
        }

        private void ValidVerify(object sender, RoutedEventArgs e)
        {
            MainWindowBusiness windowBusiness = new MainWindowBusiness();
            windowBusiness.ErrorOrResult = windowBusiness.VerifyResult(InputBox.Text);
            this.DataContext = windowBusiness;
    }

    }
}
