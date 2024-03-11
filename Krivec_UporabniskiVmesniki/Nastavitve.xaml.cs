using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

namespace Krivec_UporabniskiVmesniki
{
    /// <summary>
    /// Interaction logic for Nastavitve.xaml
    /// </summary>
    public partial class Nastavitve : Window
    {
        public Nastavitve()
        {
            InitializeComponent();

            Loaded += NastavitveLoaded;
        }
        private void NastavitveLoaded(object sender, EventArgs e)
        {
            // List<string> list = new List<string>();
            StringCollection Zanri = new StringCollection();
            //   Zanri = Properties.Settings.Default.ZanrValue;
            /* string[] zanri;
             zanri = Properties.Settings.Default.ZanrValue.Cast<string>().ToArray();*/
            foreach (string s in Zanri)
            {
                comboBox.Items.Add(s);
            }
            /* foreach(string zanr in Properties.Settings.Default.ZanrValue) 
             {
               list.Add(zanr);
             }*/


        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {


            string novZanr = VnosnoPolje.Text;

            // Properties.Settings.Default.ZanrValue.Add(novZanr);

            //  Properties.Settings.Default.DodajZanr(novZanr);

            Properties.Settings.Default.Save();

            /*  if(VnosnoPolje.Text.Length > 0)
              {
                  Properties.Settings.Default.ZanrValue.Add(novZanr);


                  Properties.Settings.Default.Save();
              }
              else
              {
                  MessageBox.Show("Nic niste vnesli", "Error");
              }*/


        }

        private void Brisi_Click(object sender, RoutedEventArgs e)
        {
            /* string novZanr = VnosnoPolje.Text;
             foreach (string zanr in Properties.Settings.Default.ZanrValue)
             {
                 if(novZanr == zanr)
                 {
                     Properties.Settings.Default.ZanrValue.Remove(novZanr);
                 }
             }*/
        }

        private void Uredi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem typeItem = (ComboBoxItem)comboBox.SelectedItem;
            VnosnoPolje.Text = typeItem.Content.ToString();
        }
    }
}
