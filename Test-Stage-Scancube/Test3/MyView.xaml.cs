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

        private void button_Click(object _obj, RoutedEventArgs _event)
        {
            Button source = _obj as Button;

            if (source != null) {
                source.Visibility = Visibility.Hidden;
                this.TextInfo.Visibility = Visibility.Visible;
            }
        }
    }
}
