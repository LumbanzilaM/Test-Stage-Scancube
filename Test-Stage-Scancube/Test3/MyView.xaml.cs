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

namespace Test_Stage_Scancube.Test3
{
    /// <summary>
    /// Logique d'interaction pour MyView.xaml
    /// </summary>
    public partial class MyView : UserControl
    {
        public MyView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyText.Text = "Beaucoup trop facile ce test !";
            MyText.Visibility = MyText.IsVisible ? Visibility.Hidden : Visibility.Visible;
        }
    }
}
