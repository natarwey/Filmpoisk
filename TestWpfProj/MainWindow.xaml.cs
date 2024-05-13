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
using TestWpfProj.Data;

namespace TestWpfProj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Film> _films;
        private List<FilmGanr> _filmGanres;
        public MainWindow()
        {
            InitializeComponent();

            _films = Data.DataContext.Films;
            _filmGanres = Data.DataContext.FilmGanres;

            LstView.ItemsSource = _films;
            FilterCB.ItemsSource = _filmGanres;
        }

        private void DeleteMI_Click(object sender, RoutedEventArgs e)
        {
            Film selectedMeme = (Film)LstView.SelectedItem;
            _films.Remove(selectedMeme);

            LstView.ItemsSource = _films;
            LstView.Items.Refresh();
        }

        private void EditMI_Click(object sender, RoutedEventArgs e)
        {
            Film selectedMeme = (Film)LstView.SelectedItem;
            MessageBox.Show($"Id:{selectedMeme.Id} \nTitle: {selectedMeme.Title}", "Soon!");
        }

        private void RefreshBtn_Click(object sender, RoutedEventArgs e)
        {
            LstView.ItemsSource = _films;
            LstView.Items.Refresh();
        }

        private void SerchTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tempLst = _films;

            if (!String.IsNullOrEmpty(SerchTB.Text))
            {
                tempLst = _films.Where(x => x.Title.Contains(SerchTB.Text)).ToList();
            }

            LstView.ItemsSource = tempLst;
            LstView.Items.Refresh();
        }
    }
}
