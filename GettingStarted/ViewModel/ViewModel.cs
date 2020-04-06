//using Newtonsoft.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GettingStarted
{
    public class ViewModel : INotifyPropertyChanged
    {

        public const string jsonData = "[{\"OrderID\":1,\"EmployeeID\":100,\"FirstName\":'Gina',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":2,\"EmployeeID\":200,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                     "{\"OrderID\":3,\"EmployeeID\":300,\"FirstName\":'Frank',\"LastName\":'Gable'},]";

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<dynamic> DynamicCollection { get; set; }
        public List<ExpandoObject> DynamicJsonCollection { get; set; }

        public ViewModel()
        {
            DynamicJsonCollection = JsonConvert.DeserializeObject<List<ExpandoObject>>(jsonData);
            DynamicCollection = PopulateData();
        }

        private ObservableCollection<dynamic> PopulateData()
        {
            var data = new ObservableCollection<dynamic>();
            foreach (var item in DynamicJsonCollection)
            {
                data.Add(item);
            }
            return data;
        }
    }
}
