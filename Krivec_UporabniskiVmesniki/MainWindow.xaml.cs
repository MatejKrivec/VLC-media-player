using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml;
using System.Xml.Serialization;
using Path = System.IO.Path;

namespace Krivec_UporabniskiVmesniki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private bool userIsDraggingSlider = false;

        public static MainWindow Instance;

        public int ID;
        public string IME;
        public string ZANR;
        public string IMAGE;
        public string LENGHTH;
        public string POT;
        public TextBox IMEE;

        public int ID2;
        public string IME2;
        public string ZANR2;
        public string IMAGE2;
        public string LENGHTH2;
        public string POT2;

        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            Loaded += PageLoaded;
            MediaElement.MediaOpened += MediaElement_MediaOpened;

            Instance= this;

            ID = ID2;
            IME = IME2;
            ZANR = ZANR2;
            IMAGE = IMAGE2;
            LENGHTH = LENGHTH2;
            POT = POT2;

            UporabniskiGradnik.playy += predvajaj;
            UporabniskiGradnik.pausee += pavza;
            UporabniskiGradnik.stop += stop_Click;
            UporabniskiGradnik.next += next_Click;
            UporabniskiGradnik.previous += previous_Click;

        }
        private void Zapiranje_aplikacije(object sender, RoutedEventArgs e)
        {

            Environment.Exit(0); //Zapiranje aplikacije
        }

        private void MediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            // Cas.Text = MediaElement.NaturalDuration.TimeSpan.TotalSeconds.ToString(@"hh\:mm\:ss");
            CasPredvajanja.Maximum = MediaElement.NaturalDuration.TimeSpan.TotalSeconds;            //Celoten cas Media elementa
            Cas.Text = TimeSpan.FromSeconds(CasPredvajanja.Maximum).ToString(@"hh\:mm\:ss");
        }

        ObservableCollection<Video> files = new ObservableCollection<Video>();
        public List<string> strings = new List<string>();

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string[] fileEntries = Directory.GetFiles(projectDirectory + @"\Videi");

            string[] slike = Directory.GetFiles(projectDirectory + @"\Slike");
            strings.AddRange(fileEntries);

            files.Add(new Video() { id = 1, Image = slike[0], Lenghth = "00:00:55", Name = "crowning", Pot = fileEntries[0], Zanr = "Drama" });
            files.Add(new Video() { id = 2, Image = slike[1], Lenghth = "00:01:37", Name = "kosilo", Pot = fileEntries[1], Zanr = "Drama" });
            files.Add(new Video() { id = 3, Image = slike[3], Lenghth = "00:02:43", Name = "sparta", Pot = fileEntries[2], Zanr = "Fighting" });
            files.Add(new Video() { id = 4, Image = slike[2], Lenghth = "00:00:41", Name = "Pesem", Pot = fileEntries[3], Zanr = "Song" });
            files.Add(new Video() { id = 5, Image = slike[4], Lenghth = "00:02:47", Name = "witcher", Pot = fileEntries[4], Zanr = "Fighting" });
            
            int ID = 1;

        
            Video.ItemsSource = files; //drugacen source

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if ((MediaElement.Source != null) && (MediaElement.NaturalDuration.HasTimeSpan) && (!userIsDraggingSlider))
            {
                CasPredvajanja.Minimum = 0;
                CasPredvajanja.Maximum = MediaElement.NaturalDuration.TimeSpan.TotalSeconds;
                CasPredvajanja.Value = MediaElement.Position.TotalSeconds;

            }
        }

        public int a ;
       // string pot = "";
       
        private void Nivo_volumna(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            MediaElement.Volume = (double)volumen.Value;
        }
        private void CasPredvajanja_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            userIsDraggingSlider = true;
        }

        private void CasPredvajanja_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            userIsDraggingSlider = false;
            MediaElement.Position = TimeSpan.FromSeconds(CasPredvajanja.Value);
        }
        private void MediaOpened(object sender, RoutedEventArgs e)
        {
            CasPredvajanja.Maximum = MediaElement.NaturalDuration.TimeSpan.TotalMilliseconds;
        }

        private void CasPredvajanja_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            /* int vrednost = (int)CasPredvajanja.Value;

             // Overloaded constructor takes the arguments days, hours, minutes, seconds, milliseconds.
             // Create a TimeSpan with miliseconds equal to the slider value.
             TimeSpan cas = new TimeSpan(0, 0, 0, 0, vrednost);
             MediaElement.Position = cas;*/

            casovnik.Text = TimeSpan.FromSeconds(CasPredvajanja.Value).ToString(@"hh\:mm\:ss");

        }

        void InitializePropertyValues()
        {
            // Set the media's starting Volume and SpeedRatio to the current value of the
            // their respective slider controls.
            MediaElement.Volume = (double)volumen.Value;
        }

        /*   private void listView_MouseDoubleClick(object sender, EventArgs e)
           {
               MessageBox.Show(Video.SelectedItems[0].ToString(), "Playlist");   //Izpis imena datoteke

           }*/

        
        public void predvajaj(object sender, RoutedEventArgs e)
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

        }

        private void Shuffle_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            List<string> list = new List<string>();

            string[] MyRandomArray = list.OrderBy(x => rnd.Next()).ToArray();
        }

        private void Odstrani_Click(object sender, RoutedEventArgs e)
        {
            int index = 0;
            index = Video.SelectedIndex;
            files.RemoveAt(index);
            strings.RemoveAt(index);
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
           
            string pot;
            string ime;
            int id = 1;
            foreach(var str in files)
            {
                id++;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "mp4 documents (.mp4)|*.mp4|mp3 documents (.mp3)|*.mp3";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //openFileDialog.CustomPlaces.Add("C:\\MyCustomPlace");
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames)
                {
                    pot = Path.GetFullPath(filename);
                    ime= Path.GetFileName(filename);
                    files.Add(new Video() { id=id,Name = ime,Pot = pot });
                    strings.Add(pot);
                }

            }
            

        }
        public bool selected { get; set; }
        private void klik(object sender, SelectionChangedEventArgs e)
        {
            // List<string> strings= new List<string>();


            try
            {
                a = Video.SelectedIndex;
                MediaElement.Source = new Uri(strings[a]);         //tole zakomentiri ko removas item
                selected = true;
            }
            catch
            {

            }
            


        }

        private void Uredi_Click(object sender, RoutedEventArgs e)
        {

            int i = Video.SelectedIndex;
            if (Video.SelectedIndex > -1)
            {
                Uredi uredi = new Uredi();
                uredi.Show();

                Video SelectedItem = (Video)Video.SelectedItem;

                Uredi.instance.ID.Text = SelectedItem.id.ToString();
                Uredi.instance.IME.Text= SelectedItem.Name;
                Uredi.instance.ZANR.Text = SelectedItem.Zanr;
                Uredi.instance.IMAGE.Text = SelectedItem.Image;
                Uredi.instance.LENGHTH.Text = SelectedItem.Lenghth;
                Uredi.instance.POT.Text = SelectedItem.Pot;

                Uredi.instance.naslov = SelectedItem.Name;


             if (uredi.Name.Text.Length > 0)
             {
                    /*  ID = SelectedItem.id;
                      IME = SelectedItem.Name;
                      ZANR = SelectedItem.Zanr;
                      IMAGE = SelectedItem.Image;
                      LENGHTH = SelectedItem.Lenghth;
                      POT = SelectedItem.Pot;*/


                    files.Add(new Video { id = int.Parse(uredi.Id.Text), Name = uredi.Name.Text , Zanr = uredi.comboBox.SelectedItem.ToString(), Image = uredi.Image.Text, Lenghth = uredi.Lenghth.Text, Pot = uredi.Pot.Text, });
                    files.Add(new Video { id = ID2, Name = IME2 , Zanr = ZANR2, Image = IMAGE2, Lenghth = LENGHTH2, Pot = POT2 });


                }
            }
           
            else
            {
                MessageBox.Show("Niste izbrali nobene datoteke", "Error");
                return;
            }
        }

        private void Video_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            a = Video.SelectedIndex;

            
            MediaElement.Source = new Uri(strings[a]);

            MediaElement.Play();
            InitializePropertyValues();
        }

        private void Uvozi_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";
            //string[] struktura;
            if (openFileDialog.ShowDialog() == true)
            {
                var deserializacija = new XmlSerializer(typeof(Video));

                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    var video = (Video)deserializacija.Deserialize(reader);
                    files.Add(video);
                }
            }
        }

       
        private void Izvozi_Click(object sender, RoutedEventArgs e)
        {
            int index = Video.SelectedIndex;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            
            if (saveFileDialog.ShowDialog() == true)
            {
                // File.WriteAllText(saveFileDialog.FileName, txtEditor.Text); 

                var serealizacija = new XmlSerializer(typeof(Video)); ///type of observable collectaion

                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    serealizacija.Serialize(writer, files[index]);
                }
            }

           


        }
        private void Nastavitve_Click(object sender, RoutedEventArgs e)
        {
            Nastavitve nastavitve = new Nastavitve();
            nastavitve.Show();
        }
    }


}
