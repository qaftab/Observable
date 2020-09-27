using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable
{
    public class Country:BindableBase
    {
        //public string CountryName { get; set; }
        private string countryName;
        public string CountryName
        {
            get => countryName;
            set => SetProperty(ref countryName, value);
        }



        // public ObservableCollection<City> CitiesInCountry = new ObservableCollection<City>();
        private ObservableCollection<City> CitiesInCountry = new ObservableCollection<City>();
        public ObservableCollection<City> CITIES
        {
            get => CitiesInCountry;
            set => SetProperty(ref CitiesInCountry, value);
        }


    }
}
