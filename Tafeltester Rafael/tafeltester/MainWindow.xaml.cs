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

namespace tafeltester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void afsluiten_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Tafeltester afsluiten?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {

            }
            else
            {
                App.Current.Shutdown();
            }
        }
        void Name_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonEasy_Click(object sender, RoutedEventArgs e)
        {
            string niveau = "Makkelijk";
            Test win1 = new Test(Name_textBox.Text, niveau);
            win1.ShowDialog();
            Close();
        }

        private void ButtonNormal_Click(object sender, RoutedEventArgs e)
        {
            string niveau = "Normaal";
            Test win2 = new Test(Name_textBox.Text, niveau);
            win2.ShowDialog();
            Close();
        }

        private void ButtonHard_Click(object sender, RoutedEventArgs e)
        {
            string niveau = "Moeilijk";
            Test win3 = new Test(Name_textBox.Text, niveau);
            win3.ShowDialog();
            Close();
        }
    }
}
