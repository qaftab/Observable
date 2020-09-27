using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;

namespace Observable
{
    public class City : BindableBase
    {
        public string Name { set; get; }
        /*
               public int Temperature { set; get; }

               public int TEMPERATURE
               {
                   get { return Temperature; }
                   set
                   {
                       Temperature = value;
                       OnPropertyChanged("TEMPERATURE");
                   }
               }*/
        public int Temperature;
        public int TEMPERATURE
        {
            get => Temperature;
            set => SetProperty(ref Temperature, value);
            
        }

    }
}

