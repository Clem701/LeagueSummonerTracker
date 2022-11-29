using SummonerSpells.Models;
using SummonerSpells.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace SummonerSpells
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] regions { get; set; }

        private string name = "";

        private string region = "";

        public MainWindow()
        {
            InitializeComponent();
            initData();
            List<ComboBoxVM> regionsList = new List<ComboBoxVM>();
            regionsList.Add(new ComboBoxVM() { Id = "EUW1", Value = "Europe West" });
            regionsList.Add(new ComboBoxVM() { Id = "NA1", Value = "North America" });
            regionsList.Add(new ComboBoxVM() { Id = "EUN1", Value = "Europe Nordic East" });
            regionsList.Add(new ComboBoxVM() { Id = "TR", Value = "Turkey" });
            regionsList.Add(new ComboBoxVM() { Id = "RU", Value = "Russia" });
            regionsList.Add(new ComboBoxVM() { Id = "OC1", Value = "Oceania" });
            regionsList.Add(new ComboBoxVM() { Id = "JP1", Value = "Japan" });
            regionsList.Add(new ComboBoxVM() { Id = "KR", Value = "Korea" });
            regionsList.Add(new ComboBoxVM() { Id = "LA1", Value = "Latin America1" });
            regionsList.Add(new ComboBoxVM() { Id = "LA2", Value = "Latin America2" });
            regionsList.Add(new ComboBoxVM() { Id = "BR1", Value = "Brazil" });


            RegionCombobox.ItemsSource = regionsList;
            DataContext = this;
        }

        private async void Btn_Submit(object sender, RoutedEventArgs e)

        {

            try
            {
                string region = RegionCombobox.Text;
                //MessageBox.Show(RegionCombobox.SelectedValue.ToString());
                ApiHandler api = new ApiHandler("https://" + RegionCombobox.SelectedValue.ToString() + ".api.riotgames.com");
                //MessageBox.Show(await api.GetSummonerID(UserName.Text));
                var summoner = await api.GetSummoner(UserName.Text);
                var gameInfo = await api.GetGameInfo();
                List<long> ids = new List<long>();
                List<long> spellIds = new List<long>();
                var participant = gameInfo.Participants.Where(p => p.SummonerId == summoner.Id).First();
                var enemyParticipants = new List<CurrentGameParticipant>();
                foreach (var item in gameInfo.Participants)
                {
                    if (participant.TeamId != item.TeamId)
                    {
                        enemyParticipants.Add(item);
                        ids.Add(item.ChampionId);
                        spellIds.Add(item.Spell1Id);
                        spellIds.Add(item.Spell2Id);
                    }

                }
                var champs = await api.GetEnemyChampsById(ids);
                var spells = await api.GetSpells(spellIds);
                var currentGameVM = new List<CurrentGameParticipantVM>();
                foreach (var item in enemyParticipants)
                {
                    List<Spells> currentSpells = new List<Spells>();
                    foreach (var spell in spells)
                    {
                        if (item.Spell1Id == spell.Id || item.Spell2Id == spell.Id)
                        {
                            currentSpells.Add(spell);
                        }
                    }
                    currentGameVM.Add(new CurrentGameParticipantVM()
                    {
                        Participant = item,
                        Spells = currentSpells
                    });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with Riots-Api.\nPlease try again later or refresh the API-KEY!");
                throw;
            }

            if (Checkbox_RememberMeName.IsChecked == true)
            {
                Properties.Settings.Default.username = UserName.Text;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.region = RegionCombobox.Text;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.Save();
            }
            window2 liveGameWindow = new window2();
            liveGameWindow.Show();
        }

        private void UserSummonerName(object sender, TextChangedEventArgs e)
        {
            name = UserName.Text;
        }

        private void CheckBox_RememberMe(object sender, RoutedEventArgs e)
        {

        }

        private void initData()
        {
            if (Properties.Settings.Default.username != string.Empty)
            {
                UserName.Text = Properties.Settings.Default.username;
                RegionCombobox.Text = Properties.Settings.Default.region;
                Checkbox_RememberMeName.IsChecked = true;
            }
        }
    }
}
