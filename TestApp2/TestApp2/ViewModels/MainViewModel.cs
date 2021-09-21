using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using TestApp2.Models;
using Xamarin.Forms;

namespace TestApp2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        ObservableCollection<Item> items = new ObservableCollection<Item>();
        public ObservableCollection<Item> Items { get { return items; } set { items = value; } }
        public string Test { get; set; }

        public MainViewModel()
        {
            Test = "TEST";
            Items.Add(new Item { Id = Items.Count, Name = "Item", Description = "TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION " });
            Items.Add(new Item { Id = Items.Count, Name = "Item", Description = "TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION " });
            Items.Add(new Item { Id = Items.Count, Name = "Item", Description = "TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION " });
            Items.Add(new Item { Id = Items.Count, Name = "Item", Description = "TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION " });
            Items.Add(new Item { Id = Items.Count, Name = "Item", Description = "TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION TEST DESCRIPTION " });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
