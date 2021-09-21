using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp2.Models;
using TestApp2.ViewModels;
using Xamarin.Forms;

namespace TestApp2
{
    public partial class MainPage : ContentPage
    {
        MainViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            viewModel = BindingContext as MainViewModel;
        }
        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () => {
                Item item = e.Item as Item;
                item.tapped++;
                int thisTap = item.tapped;
                item.lengthIncrementing = !item.lengthIncrementing;
                if (item.lengthIncrementing)
                {
                    while (item.GridLength < item.lengthMaximum && thisTap == item.tapped)
                    {
                        item.GridLength = item.GridLength + 4;
                        await Task.Delay(5);
                    }
                }
                else
                {
                    while (item.GridLength > item.lengthMinimum && thisTap == item.tapped)
                    {
                        item.GridLength = item.GridLength - 4;
                        await Task.Delay(5);
                    }
                }
            });
        }
    }
}
