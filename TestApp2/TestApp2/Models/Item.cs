using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace TestApp2.Models
{
    public class Item : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int tapped = 0;
        public int lengthMinimum = 24;
        public int lengthMaximum = 144;
        GridLength gridLength = new GridLength(40, GridUnitType.Star);
        int intLength = 24;
        public bool lengthIncrementing = false;
        public int GridLength
        {
            get { return intLength; }
            set { gridLength = new GridLength(value, GridUnitType.Star); intLength = value; OnPropertyChanged("GridLength"); }
        }

        int frameHeight = 56;
        public int FrameHeight
        {
            get { return frameHeight; }
            set { frameHeight = value; OnPropertyChanged("FrameHeight"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}