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

namespace tafeltester
{
    /// <summary>
    /// Interaction logic for Easy.xaml
    /// </summary>
    public partial class Test : Window
    {
        int i_int = 0;
        public Test(string Name_textBox, string niveau)
        {
            InitializeComponent();
            niveau_box.Text = niveau;
            naam_box.Text = Name_textBox;
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
        private void home_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Terug naar start?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {

            }
            else
            {
                MainWindow win = new MainWindow();
                win.Show();
                Close();
            }
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            if(niveau_box.Text == "Makkelijk")
            {
                Teken.Text = "+";
            }
            if (niveau_box.Text == "Normaal")
            {
                Teken.Text = "-";
            }
            if (niveau_box.Text == "Moeilijk")
            {
                Teken.Text = "x";
            }
            MaakSom();
            goed.Text = "goed: 0";
            fout.Text = "fout: 0";
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void next_Click(object sender, RoutedEventArgs e)
        {
            i_int++;
            MaakSom();
            input.Text = string.Empty;
        }
        private void MaakSom()
        {
            int aantalGoed = int.Parse(goed_int.Text);
            int aantalFout = int.Parse(fout_int.Text);
            if (niveau_box.Text == "Makkelijk")
            {
                if (i_int < 11)
                {
                    Random RDMNum = new Random();

                    int num1 = RDMNum.Next(1, 40);
                    int num2 = RDMNum.Next(1, 40);

                    if (i_int > 0)
                    {
                        int goedAntwoord = int.Parse(num1_box.Text) + int.Parse(num2_box.Text);
                        if (input.Text == "")
                        {
                            aantalFout++;
                            fout_int.Text = aantalFout + "";
                        }
                        else
                        {
                            if (int.Parse(input.Text) != goedAntwoord)
                            {
                                aantalFout++;
                                fout_int.Text = aantalFout + "";
                            }
                            else
                            {
                                aantalGoed++;
                                goed_int.Text = aantalGoed + "";
                            }
                        }
                    }
                    num1_box.Text = num1 + "";
                    num2_box.Text = num2 + "";
                }
                if (i_int == 10)
                {
                    input.Visibility = Visibility.Hidden;
                    Teken.Text = string.Empty;
                    isTeken.Text = string.Empty;
                    num1_box.Text = string.Empty;
                    num2_box.Text = string.Empty;

                    next.Content = "Klaar";
                }
                if (i_int == 11)
                {
                    MainWindow win = new MainWindow();
                    win.Show();
                    Close();
                }
            }
            if (niveau_box.Text == "Normaal")
            {
                if (i_int < 11)
                {
                    Random RDMNum = new Random();

                    int num1 = RDMNum.Next(30, 50);
                    int num2 = RDMNum.Next(1, 30);

                    if (i_int > 0)
                    {
                        int goedAntwoord = int.Parse(num1_box.Text) - int.Parse(num2_box.Text);
                        if (input.Text == "")
                        {
                            aantalFout++;
                            fout_int.Text = aantalFout + "";
                        }
                        else
                        {
                            if (int.Parse(input.Text) != goedAntwoord)
                            {
                                aantalFout++;
                                fout_int.Text = aantalFout + "";
                            }
                            else
                            {
                                aantalGoed++;
                                goed_int.Text = aantalGoed + "";
                            }
                        }
                    }
                    num1_box.Text = num1 + "";
                    num2_box.Text = num2 + "";
                }
                if (i_int == 10)
                {
                    input.Visibility = Visibility.Hidden;
                    Teken.Text = string.Empty;
                    isTeken.Text = string.Empty;
                    num1_box.Text = string.Empty;
                    num2_box.Text = string.Empty;

                    next.Content = "Klaar";
                }
                if (i_int == 11)
                {
                    MainWindow win = new MainWindow();
                    win.Show();
                    Close();
                }
            }
            if (niveau_box.Text == "Moeilijk")
            {
                if (i_int < 11)
                {
                    Random RDMNum = new Random();

                    int num1 = RDMNum.Next(1, 10);
                    int num2 = RDMNum.Next(2, 20);

                    if (i_int > 0)
                    {
                        int goedAntwoord = int.Parse(num1_box.Text) * int.Parse(num2_box.Text);
                        if (input.Text == "")
                        {
                            aantalFout++;
                            fout_int.Text = aantalFout + "";
                        }
                        else
                        {
                            if (int.Parse(input.Text) != goedAntwoord)
                            {
                                aantalFout++;
                                fout_int.Text = aantalFout + "";
                            }
                            else
                            {
                                aantalGoed++;
                                goed_int.Text = aantalGoed + "";
                            }
                        }
                    }
                    num1_box.Text = num1 + "";
                    num2_box.Text = num2 + "";
                }
                if (i_int == 10)
                {
                    input.Visibility = Visibility.Hidden;
                    Teken.Text = string.Empty;
                    isTeken.Text = string.Empty;
                    num1_box.Text = string.Empty;
                    num2_box.Text = string.Empty;

                    next.Content = "Klaar";
                }
                if (i_int == 11)
                {
                    MainWindow win = new MainWindow();
                    win.Show();
                    Close();
                }
            }
        }
    }
}