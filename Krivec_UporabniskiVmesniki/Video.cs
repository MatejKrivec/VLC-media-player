using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Krivec_UporabniskiVmesniki
{
    public class Video : INotifyPropertyChanged
    {
        private int ID;
        private string NAME;
        private string ZANR;
        private string LENGHTH;
        private string IMAGE;
        private string POT;

        public Video()
        {

        }
        public Video(int value, string value1, string value2, string value3, string value4, string value5)
        {
            this.ID = value;
            this.NAME = value1;
            this.ZANR = value2;
            this.LENGHTH = value3;
            this.IMAGE = value4;
            this.POT = value5;
        }

        public int id { get { return ID; } set { ID = value; OnPropertyChanged1(); } }
        public string Name { get { return NAME; } set { NAME = value; OnPropertyChanged2(); } }
        public string Zanr { get { return ZANR; } set { ZANR = value; OnPropertyChanged3(); } }
        public string Lenghth { get { return LENGHTH; } set { LENGHTH = value; OnPropertyChanged4(); } }
        public string Image { get { return IMAGE; } set { IMAGE = value; OnPropertyChanged5(); } }

        public string Pot { get { return POT; } set { POT = value; OnPropertyChanged6(); } }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged1([CallerMemberName] string ID = null )
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(ID));
        }
        protected void OnPropertyChanged2( [CallerMemberName] string NAME = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(NAME));
        }
        protected void OnPropertyChanged3( [CallerMemberName] string ZANR = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(ZANR));
        }
        protected void OnPropertyChanged4( [CallerMemberName] string LENGHTH = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(LENGHTH));
        }
        protected void OnPropertyChanged5( [CallerMemberName] string IMAGE = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(IMAGE));
        }
        protected void OnPropertyChanged6( [CallerMemberName] string POT = null)
        {
           
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(POT));
        }
    }

   
}
