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
using static System.Net.Mime.MediaTypeNames;

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
        
        public void OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Beaucoup trop facile ce test!");
        }
    }
}
