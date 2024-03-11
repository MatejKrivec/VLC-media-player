using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Krivec_UporabniskiVmesniki
{
    public class Ikone : INotifyPropertyChanged
    {
        private string IKONA;
        

        public Ikone()
        {

        }
        public Ikone( string value4 )
        {
            
            this.IKONA = value4;
            
        }

       
        public string ikona { get { return IKONA; } set { IKONA = value; OnPropertyChanged5(); } }

        

        public event PropertyChangedEventHandler? PropertyChanged;

        
        protected void OnPropertyChanged5([CallerMemberName] string IMAGE = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(IMAGE));
        }
       
        
    }
}
