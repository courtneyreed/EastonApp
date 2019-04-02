using AllAboutEaston.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AllAboutEaston.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ThingsToDo : ContentPage
	{
		public ThingsToDo ()
		{
			InitializeComponent ();

            this.BindingContext = new AboutViewModel();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}