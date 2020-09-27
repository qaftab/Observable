using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Observable
{

    class DataUpdateFunctions
    {
        public static async Task Initialize()
        {
            await UpdateDataCountries();
        }

        public static async Task UpdateDataCountries()
        {
            int i = 0;
            while (true)
            {
                await Task.Delay(500); 
                //Debug.WriteLine("inside UpdateDataCANTrace");
                i++;
                var Countries_temp = Application.Current.Resources["CountriesResource"] as ObservableCollection<Country>;
                Countries_temp[0].CountryName = "Hello"+ i;
                Countries_temp[0].CITIES[0].TEMPERATURE = Countries_temp[0].CITIES[0].TEMPERATURE + 1;
                Debug.WriteLine(Countries_temp[0].CITIES[0].TEMPERATURE);
            }

        }
    }
}
