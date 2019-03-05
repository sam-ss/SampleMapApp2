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
	public partial class SearchPage : ContentPage
	{
        private SearchViewModel viewModel;

        public SearchPage ()
		{
			InitializeComponent ();
            viewModel = BindingContext as SearchViewModel;
           
        }
    }
}