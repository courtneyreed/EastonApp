using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AllAboutEaston.Models;

namespace AllAboutEaston.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public Item Item { get; set; }

        public WelcomePage()
        {
            InitializeComponent();

            Item = new Item
            {
                Text = "Item name",
                Description = "This is the home page."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopModalAsync();
        }
    }
}