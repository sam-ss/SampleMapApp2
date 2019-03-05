using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace LiveMapApp2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PinPage : ContentPage
	{
        public PinPage()
        {
            InitializeComponent();

            map.MoveToRegion(MapSpan.FromCenterAndRadius(
            new Position(18.536885, 73.871298), Distance.FromMiles(3))); // Santa Cruz golf course

            var position = new Position(18.536885, 73.871298); // Latitude, Longitude
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Santa Cruz",
                Address = "custom detail info"
            };
            map.Pins.Add(pin);


            // create buttons
            var morePins = new Button { Text = "Add more pins" };
            morePins.Clicked += (sender, e) => {
                map.Pins.Add(new Pin
                {
                    Position = new Position(18.535915, 73.871496),
                    Label = "Boardwalk"
                });
                map.Pins.Add(new Pin
                {
                    Position = new Position(18.535183, 73.87097),
                    Label = "Wharf"
                });
                map.MoveToRegion(MapSpan.FromCenterAndRadius(
                    new Position(18.536885, 73.871298), Distance.FromMiles(1.5)));

            };
            var reLocate = new Button { Text = "Re-center" };
            reLocate.Clicked += (sender, e) => {
                map.MoveToRegion(MapSpan.FromCenterAndRadius(
                    new Position(18.536885, 73.871298), Distance.FromMiles(3)));
            };
            var buttons = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = {
                    morePins, reLocate
                }
            };
            MainStack.Children.Add(buttons);
        }
    }
}