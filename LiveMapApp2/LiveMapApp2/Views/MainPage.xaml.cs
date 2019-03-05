using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace LiveMapApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MyMap = new Map(MapSpan.FromCenterAndRadius(new Position(37, -122), Distance.FromMiles(0.3)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand,
                MapType = MapType.Street,

            };
            MyMap.MoveToRegion(
                              MapSpan.FromCenterAndRadius(
                              new Position(18.988009, -287.189060), Distance.FromMiles(1)));

            var testpin1 = new Position(18.989216, -287.189113);
            var testpin2 = new Position(18.989104, -287.187708);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = testpin1,
                Label = "custom pin",
                Address = "custom detail info"
            };
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = testpin2,
                Label = "custom pin",
                Address = "custom detail info"
            };

            MyMap.Pins.Add(pin);
            MyMap.Pins.Add(pin2);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            //var slider = new Slider(1, 18, 1);
            //slider.ValueChanged += (sender, e) =>
            //{
            //    var zoomLevel = e.NewValue;
            //    var latlongdegrees = 360 / (Math.Pow(2, zoomLevel));
            //    MyMap.MoveToRegion(new MapSpan(MyMap.VisibleRegion.Center, latlongdegrees, latlongdegrees));
            //}; 

        }
    }
}
