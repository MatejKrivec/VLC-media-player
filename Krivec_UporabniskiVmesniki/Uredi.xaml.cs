using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

namespace Krivec_UporabniskiVmesniki
{
    /// <summary>
    /// Interaction logic for Uredi.xaml
    /// </summary>
    public partial class Uredi : Window, INotifyPropertyChanged
    {
        public static Uredi instance;

        public TextBox ID;
        public TextBox IME;
        public ComboBox ZANR;
        public TextBox IMAGE;
        public TextBox LENGHTH;
        public TextBox POT;
        public string naslov;
       

        public Uredi()
        {
            InitializeComponent();
            DataContext = this;
            

            instance = this;

            ID = Id;
            IME = Name;
            ZANR = comboBox;
            IMAGE = Image;
            LENGHTH = Lenghth;
            POT = Pot;
            naslov = Name.ToString();

            Loaded += PageLoaded;


            this.Title = naslov;
           // this.Title = IME.Text;
        }
       
        private void PageLoaded(object sender, RoutedEventArgs e)
        {
          /*  if(Name!= null)
            {
                //string naslov = IME.Text;
                this.Title = naslov;
            }*/
              
            // if()
            this.Title = naslov;
        }
        public string potDO_Slike;
        private void UREDI_Click(object sender, RoutedEventArgs e)
        {

            // MainWindow glavnoOkno = new MainWindow();

            
           // MainWindow.Instance.IMEE.Text = Name.Text;
            MainWindow.Instance.ID = int.Parse(Id.Text);
              MainWindow.Instance.IME = Name.Text;

            MainWindow.Instance.ZANR = comboBox.SelectedItem.ToString();
              MainWindow.Instance.LENGHTH = Lenghth.Text;
              if (potDO_Slike == null)
              {
                  MainWindow.Instance.IMAGE = Image.Text;
              }
              else MainWindow.Instance.IMAGE = potDO_Slike;
              MainWindow.Instance.POT = Pot.Text;

            this.Close();


        }

        private ImageSource slikaSOURCE;

        public ImageSource Slika {get { return slikaSOURCE; }   set {slikaSOURCE = value; OnPropertyChanged("Slika");} }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string Source;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "JPG datoteke (*.jpg)|*.jpg|PNG datoteke (*.png)|*.png";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                Uri SlikaUri = new Uri(openFileDialog.FileName);
                //Source = fileUri.ToString();
                //this.MyImageSource = fileUri;
                Slika = new BitmapImage(SlikaUri);
                // MyImageSource = new BitmapImage(fileUri);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string slika)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(slika));
        }

       
    }
}
