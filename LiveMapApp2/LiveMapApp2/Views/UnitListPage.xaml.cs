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
	public partial class UnitListPage : ContentPage
	{
        UnitListViewModel viewModel;
		public UnitListPage ()
		{
			InitializeComponent ();
            viewModel = BindingContext as UnitListViewModel;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            //List<UnitModelSelector> UnitModelSelectors = new List<UnitModelSelector>();
            //UnitModelSelectors.Add(new UnitModelSelector() { IsUnitGroup = false });
            //UnitModelSelectors.Add(new UnitModelSelector() { IsUnitGroup = false });
            //UnitModelSelectors.Add(new UnitModelSelector() { IsUnitGroup = false });
            //UnitModelSelectors.Add(new UnitModelSelector() { IsUnitGroup = true, UnitList = new List<string> { "unit1", "unit2","Unit3" } });
            //UnitModelSelectors.Add(new UnitModelSelector() { IsUnitGroup = true, UnitList = new List<string> { "unit1", "unit2", "Unit3" } });
            //UnitModelSelectors.Add(new UnitModelSelector() { IsUnitGroup = false });

            //UnitListView.ItemsSource = UnitModelSelectors;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
           // var collection = (((ListView)sender).ItemsSource);
            //var lastItem = ((ObservableCollection<WallModel>)collection).Last();

            //if (e.Item.Equals(lastItem))
            //{
            //    var command = FetchWallDataCommand;
            //    if (command != null && command.CanExecute(null))
            //    {
            //        command.Execute(null);
            //    }
            //}
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

            toggleButton.Text = toggleButton.Text.Equals("+") ?  "-" :  "+";

           // var test = (TappedEventArgs)e; //as TappedEventArgs.Parameter as UnitModelSelector;
           // var selected =test.Parameter as UnitModelSelector;
           // selected.UnitListVisiblity = true;
           // //selected
           //ContentSubStack.IsVisable = true;
        }
    }
}