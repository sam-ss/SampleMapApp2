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
    public partial class MapMainPage : ContentPage
    {
        public MapMainPage()
        {
            InitializeComponent();
            map.MoveToRegion(MapSpan.FromCenterAndRadius(
           new Position(18.536885, 73.871298), Distance.FromMiles(3)));
            var position = new Position(18.536885, 73.871298);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Sai Radhe",
                Address = "Pune Station"
            };
            map.Pins.Add(pin);
        }
    }
}