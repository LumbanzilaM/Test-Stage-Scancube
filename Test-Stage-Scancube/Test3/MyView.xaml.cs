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
            Button button = new Button();
            button.Text = "J'ai fini";
            button.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            button.Margin = new System.Windows.Thickness(150, 150, 0, 0);
            button.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            button.Click += new System.EventHandler(Button_Click);
            this.Content = button;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beaucoup trop facile ce test!");
        }
    }
    }
}
