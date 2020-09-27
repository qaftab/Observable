using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Observable
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private static Thread DataUpdates;
        ObservableCollection<Country> Countries_code_collection;
        public MainPage()
        {
            this.InitializeComponent();
            ObservableCollection<City> CanadaCityCollection = new ObservableCollection<City>();
            CanadaCityCollection.Add(new City { Name = "Toronto", TEMPERATURE = 24 });
            CanadaCityCollection.Add(new City { Name = "Windsor", TEMPERATURE = 30 });

            ObservableCollection<City> USACityCollection = new ObservableCollection<City>();
            USACityCollection.Add(new City { Name = "New York", TEMPERATURE = 27 });
            USACityCollection.Add(new City { Name = "Boston", TEMPERATURE = 29 });
            USACityCollection.Add(new City { Name = "Chicago", TEMPERATURE = 35 });


            ObservableCollection<City> UKCityCollection = new ObservableCollection<City>();
            UKCityCollection.Add(new City { Name = "London", TEMPERATURE = 24 });
            UKCityCollection.Add(new City { Name = "Scotland", TEMPERATURE = 30 });

            var CountriesResource = Application.Current.Resources["CountriesResource"] as ObservableCollection<Country>;
         
            CountriesResource.Add(new Country { CountryName = "Canada", CITIES = CanadaCityCollection });
            CountriesResource.Add(new Country { CountryName = "USA", CITIES = USACityCollection });
            CountriesResource.Add(new Country { CountryName = "UK", CITIES = UKCityCollection });

            Countries_code_collection = new ObservableCollection<Country>();
            Countries_code_collection.Add(new Country { CountryName = "Canada", CITIES = CanadaCityCollection });
            Countries_code_collection.Add(new Country { CountryName = "USA", CITIES = USACityCollection });
            Countries_code_collection.Add(new Country { CountryName = "UK", CITIES = UKCityCollection });

            //GridViewCountries.ItemsSource = Countries_code_collection;
            //GridViewCities.ItemsSource = CountriesResource[0].CitiesInCountry;
            GridViewCities.ItemsSource = CountriesResource[0].CITIES;
            //added Sept 25 2020
            DataUpdates = new Thread(new ThreadStart(DataUpdateFunctions.Initialize().Wait));
            DataUpdates.Start();
        }
    }
}
