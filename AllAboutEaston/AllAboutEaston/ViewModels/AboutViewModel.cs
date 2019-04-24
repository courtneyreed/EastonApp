using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace AllAboutEaston.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Map";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://www.easton-pa.com/history.html")));
            
        }

        public ICommand OpenWebCommand { get; }
    }
}