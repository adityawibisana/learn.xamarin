using LearnXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnXamarin.ViewModels { 

    public class SimpleSamplePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Fruit> FruitList { get; set; }

        public SimpleSamplePageViewModel()
        {
            FruitList = new ObservableCollection<Fruit>();
            FruitList.Add(new Fruit() { EnglishName = "Apple", LatinName = "Malus domestica" });
            FruitList.Add(new Fruit() { EnglishName = "Banana", LatinName = "Musa" });

            OnPropertyChanged("FruitList");
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
