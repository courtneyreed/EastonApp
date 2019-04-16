using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace AllAboutEaston.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://www.easton-pa.com/history.html")));
            OpenHotelOne = new Command(() => Device.OpenUri(new Uri("https://grandeastoniansuiteshotel.com/")));
            OpenHotelTwo = new Command(() => Device.OpenUri(new Uri("https://www.lafayetteinn.com/")));
            OpenHotelThree = new Command(() => Device.OpenUri(new Uri("https://www.choicehotels.com/pennsylvania/easton/quality-inn-hotels/pa374?mc=smgogousqil&cid=Search%7CQuality_Inn%7CUS%7CPennsylvania%7CExact%7CCPC%7CDesktop%7CEN%7CB_G&ag=US%7CPA%7CEaston&pmf=GOOGLE&kw=quality%20inn%20easton%20pa&gclid=CjwKCAjwvuzkBRAhEiwA9E3FUpq0FQZajWdOALRfNxXAUPehSe2RFms8oVGA2v2EMAnteQSIYguuPBoCDQIQAvD_BwE&gclsrc=aw.ds")));
            OpenHotelFour = new Command(() => Device.OpenUri(new Uri("https://www.google.com/travel/hotels/Easton/entity/CgsIkZGqwJ2E9JOKARAB?g2lb=4207876%2C4208993%2C4223281%2C4240601%2C4242081%2C4242836%2C4242898%2C4243604%2C4248641%2C4244079%2C4244566&hl=en&gl=us&un=0&q=places%20to%20stay%20in%20easton%20pa&rp=OAFAAEgC&ictx=1&ved=2ahUKEwjWnsG5yqLhAhVF1lkKHRLrBRgQvS4wA3oECAoQOw&hrf=CgUIrwEQACIDVVNEKhYKBwjjDxAEGAQSBwjjDxAEGAUYASgAqgEKCgIIFBICCFIYAZIBAiAB&tcfs=EhoaGAoKMjAxOS0wNC0wNBIKMjAxOS0wNC0wNVIA")));
            OpenCrayola = new Command(() => Device.OpenUri(new Uri("https://www.crayolaexperience.com/")));
            OpenCanal = new Command(() => Device.OpenUri(new Uri("https://canals.org/")));
            OpenTrain = new Command(() => Device.OpenUri(new Uri("http://877trainride.com/")));
            OpenSignal = new Command(() => Device.OpenUri(new Uri("https://sigalmuseum.org/")));
            OpenSquare = new Command(() => Device.OpenUri(new Uri("https://delawareriver.natgeotourism.com/content/eastons-historic-centre-square-easton-pa/del69cb6ea51b1f0f57b")));
            OpenPark = new Command(() => Device.OpenUri(new Uri("https://bushkillpark.com/")));
            
        }

        public ICommand OpenWebCommand { get; }
        public Command OpenHotelOne { get; }
        public Command OpenHotelTwo { get; }
        public Command OpenHotelThree { get; }
        public Command OpenHotelFour { get; }
        public Command OpenCrayola { get; }
        public Command OpenCanal { get; }
        public Command OpenTrain { get; }
        public Command OpenSignal { get; }
        public Command OpenSquare { get; }
        public Command OpenPark { get; }
    }
}