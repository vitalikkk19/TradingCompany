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
using System.Windows.Shapes;

namespace WPF_Project
{
    /// <summary>
    /// Interaction logic for WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Window
    {
        public WindowLogin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_LogIn_Click(object sender, RoutedEventArgs e)
        {
            WindowMainSupplyList wmsl = new WindowMainSupplyList();
            wmsl.Show();
            this.Close();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            WindowRegistration wr = new WindowRegistration();
            wr.Show();
            this.Close();
        }
    }
}
