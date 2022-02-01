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
using Test_Stage_Scancube.Test1;
using Test_Stage_Scancube.Test2;

namespace Test_Stage_Scancube
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string resultTest1Lb = "I'm a Lightbox";
        private const string resultTest1Tt = "I'm a Turntable";
        private const string resultTest1Cam = "I'm a Camera";
        private BundlesManager manager;


        public MainWindow()
        {
            InitializeComponent();
            ListViewOwner.SelectionChanged += ListView_Selected;
        }


        private void StartTest1(object sender, RoutedEventArgs e)
        {
            try
            {
                HardwareGenerator generator = new HardwareGenerator();
                string[] names = generator.GetAllInfos();
                LightboxTxt1.Text = names[0];
                TurnTableTxt1.Text = names[1];
                Cameratxt1.Text = names[2];

                LightboxTxt1.Foreground = names[0] == resultTest1Lb ? Brushes.Green : Brushes.Red;
                TurnTableTxt1.Foreground = names[1] == resultTest1Tt ? Brushes.Green : Brushes.Red;
                Cameratxt1.Foreground = names[2] == resultTest1Cam ? Brushes.Green : Brushes.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            manager = new BundlesManager();
            ListViewOwner.Items.Clear();
            foreach (var item in manager.GetOwners())
            {
                ListViewOwner.Items.Add(item);
            };
        }


        private void ListView_Selected(object sender, SelectionChangedEventArgs e)
        {
            string owner = (string)e.AddedItems[0];
            Bundle bundle = manager.GetBundleByOwner(owner);
            OwnerTxt2.Text = bundle.Owner;
            LightboxTxt2.Text = bundle.Lightbox.Id.ToString();
            TurnTableTxt2.Text = bundle.Turntable.Id.ToString();
            Cameratxt2.Text = bundle.Camera.Id.ToString();
        }
    }
}
