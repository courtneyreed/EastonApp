using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AllAboutEaston.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();



            var website = "https://goo.gl/maps/HgFmNCzoG3jLiGC36";
            Browser.Source = website;
        }
    }
}