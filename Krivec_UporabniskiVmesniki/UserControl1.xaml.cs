using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
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
using static System.Net.WebRequestMethods;

namespace Krivec_UporabniskiVmesniki
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        /* public string stopIkona
         {
             get { return @"C:\Users\Uporabnik\Desktop\UV\Krivec_UporabniskiVmesniki\Ikone\bb.png"; }
         }*/
       // public string stopIkona;
        public UserControl1()
        {
            InitializeComponent();
            /*  string workingDirectory = Environment.CurrentDirectory;
              string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
              string[] fileEntries = Directory.GetFiles(projectDirectory + @"\Ikone");*/

            //stopIkona = fileEntries[0];

            Loaded += PageLoaded;
        }
        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            

            string[] slike = Directory.GetFiles(projectDirectory + @"\Ikone");

            //PREVIUS.Source = @"C:\Users\Uporabnik\Desktop\corrupted\UV\Krivec_UporabniskiVmesniki\Ikone\prv.png";
            PREVIUS.Source = new BitmapImage(new Uri(slike[3]));
            PAUSE.Source = new BitmapImage(new Uri(slike[2]));
            PLAY.Source = new BitmapImage(new Uri(slike[4]));
            stopIkonaa.Source = new BitmapImage(new Uri(slike[0]));
            NEXT.Source = new BitmapImage(new Uri(slike[1]));

        }
        public event RoutedEventHandler playy;
        public event RoutedEventHandler pausee;
        public event RoutedEventHandler stop;
        public event RoutedEventHandler next;
        public event RoutedEventHandler previous;

        private void predvajaj(object sender, RoutedEventArgs e)
        {
            if (playy != null)
            {
                playy(this, e);
            }
        }

        private void pavza(object sender, RoutedEventArgs e)
        {
            if (pausee != null)
            {
                pausee(this, e);
            }
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            if (stop != null)
            {
                stop(this, e);
            }
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            if (next != null)
            {
                next(this, e);
            }
        }
        private void previous_Click(object sender, RoutedEventArgs e)
        {
            if (previous != null)
            {
                previous(this, e);
            }
        }

        /*   private void predvajaj(object sender, RoutedEventArgs e)
           {
               //   a = Video.SelectedIndex;
               //   MediaElement.Source = new Uri(fileEntries[a]);

               // MediaElement.Source = new Uri(pot); 
               MediaElement.Play();
               InitializePropertyValues();
           }

           private void pavza(object sender, RoutedEventArgs e)
           {
               MediaElement.Pause();
           }
           private void stop_Click(object sender, RoutedEventArgs e)
           {
               MediaElement.Stop();
           }

           private void next_Click(object sender, RoutedEventArgs e)
           {

               try
               {
                   Video.SelectedIndex = Video.SelectedIndex + 1;
                   MediaElement.Source = (Uri)Video.SelectedItem;
               }
               catch
               {
                   // MessageBox.Show("No more media", "Error");
               }

           }

           private void previous_Click(object sender, RoutedEventArgs e)
           {

               try
               {
                   Video.SelectedIndex = Video.SelectedIndex - 1;
                   MediaElement.Source = (Uri)Video.SelectedItem;
               }
               catch
               {
                   // MessageBox.Show("No more media", "Error");
               }

           }*/
    }
}
