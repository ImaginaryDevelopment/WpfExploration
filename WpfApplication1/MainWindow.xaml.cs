using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        #region string - Password1
        private string _Password1;

        public string Password1
        {
            get { return _Password1; }
            set
            {
                this._Password1 = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Password1"));
            }
        }

        #endregion

        #region string - Password2
        private string _Password2;

        public string Password2
        {
            get { return _Password2; }
            set
            {
                this._Password2 = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Password2"));
            }
        }

        #endregion

        public MainWindow()
        {
            CreateShowPasswordCommand();
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Password1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Password2);
        }

        /// <summary>
        /// http://www.codeproject.com/Articles/238657/How-to-use-Commands-in-WPF
        /// </summary>
        public ICommand ShowPasswordCommand { get; internal set; }

        void CreateShowPasswordCommand()
        {
            ShowPasswordCommand = new RelayCommand(pwd => MessageBox.Show((string)pwd), pwd => !String.IsNullOrEmpty( (string)pwd));
        }

    }
}
