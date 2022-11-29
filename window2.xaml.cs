using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace SummonerSpells
{
    /// <summary>
    /// Interaction logic for window2.xaml
    /// </summary>
    public partial class window2 : Window
    {

        public window2()
        {
            InitializeComponent();
            initUserData();
        }

        private void initUserData()
        {
            LabelUserName.Content = ((MainWindow)Application.Current.MainWindow).UserName.Text;
            LabelUserRegion.Content = ((MainWindow)Application.Current.MainWindow).RegionCombobox.Text;
            TopChampion.Source = new BitmapImage(new Uri(String.Format("...\\Images\\Champions\\"".png" )));
            ((MainWindow)Application.Current.MainWindow).Close();

        }



        //Flash
        private void TopFlash_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void JglFlash_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void MidFlash_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void AdcFlash_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void SuppFlash_OnClick(object sender, RoutedEventArgs e)
        {

        }

        //Barrier
        private void TopBarrier_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void JglBarrier_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void MidBarrier_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void AdcBarrier_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void SuppBarrier_OnClick(object sender, RoutedEventArgs e)
        {

        }

        //Cleanse
        private void TopCleanse_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void JglCleanse_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void MidCleanse_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void AdcCleanse_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void SuppCleanse_OnClick(object sender, RoutedEventArgs e)
        {

        }

        //Exhaust
        private void TopExhaust_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void JglExhaust_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void MidExhaust_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void AdcExhaust_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void SuppExhaust_OnClick(object sender, RoutedEventArgs e)
        {

        }

        //Ghost
        private void TopGhost_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void JglGhost_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void MidGhost_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void AdcGhost_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void SuppGhost_OnClick(object sender, RoutedEventArgs e)
        {

        }

        //Heal
        private void TopHeal_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void JglHeal_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void MidHeal_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void AdcHeal_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void SuppHeal_OnClick(object sender, RoutedEventArgs e)
        {

        }

        //Ignite
        private void TopIgnite_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void JglIgnite_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void MidIgnite_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void AdcIgnite_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void SuppIgnite_OnClick(object sender, RoutedEventArgs e)
        {

        }

        //Smite
        private void TopSmite_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void JglSmite_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void MidSmite_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void AdcSmite_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void SuppSmite_OnClick(object sender, RoutedEventArgs e)
        {

        }

        //Teleport
        private void TopTeleport_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void JglTeleport_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void MidTeleport_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void AdcTeleport_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void SuppTeleport_OnClick(object sender, RoutedEventArgs e)
        {

        }


    }
}
