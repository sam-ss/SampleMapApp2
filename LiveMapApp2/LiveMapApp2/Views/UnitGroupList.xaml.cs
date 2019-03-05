using LiveMapApp2.Selectro;
using LiveMapApp2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LiveMapApp2.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UnitGroupList : ContentPage
    {
        UnitListViewModel viewModel;
        public UnitGroupList()
        {
            InitializeComponent();
            this.Title = "OTIS";
            viewModel = BindingContext as UnitListViewModel;
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;

        }

        private void ListView_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {

        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

            Button toggleButton = sender as Button;

            toggleButton.Text = toggleButton.Text.Equals("+") ? "-" : "+";

            // var test = (TappedEventArgs)e; //as TappedEventArgs.Parameter as UnitModelSelector;
            // var selected =test.Parameter as UnitModelSelector;
            // selected.UnitListVisiblity = true;
            // //selected
            //ContentSubStack.IsVisable = true;
        }

        async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            StackLayout UnitStack = sender as StackLayout;
            UnitStack.BackgroundColor = Color.FromHex("#f65275");
            await UnitStack.ScaleTo(0.99, 150);
            await UnitStack.ScaleTo(1, 150);
            UnitStack.BackgroundColor = Color.White;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var btn= sender as Button;
            DisplayAlert(null, btn.Text, "OK");
        }
    }
}
