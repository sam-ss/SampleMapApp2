using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LiveMapApp2.ViewModels
{
    public class SearchViewModel : BaseViewModel
    {
        private bool _isSearchBoxVisable;
        public bool IsSearchBoxVisable
        {
            get => _isSearchBoxVisable;

            set => SetProperty(ref _isSearchBoxVisable, value);
        }

        private string _searchBoxText;
        public string SearchBoxText
        {
            get => _searchBoxText;

            set => SetProperty(ref _searchBoxText, value);
        }

        public SearchViewModel()
        {
        }



        private ICommand _searchTextCommand;
        public ICommand SearchTextCommand
        {
            get
            {
                return _searchTextCommand ?? (_searchTextCommand = new Command(() =>
                {
                    IsSearchBoxVisable = true;
                    if (!string.IsNullOrEmpty(SearchBoxText))
                    {
                        //DisplayAlert(null, SearchText, "OK");
                    }
                    //object keyword = selectedItem as object;

                }));
            }
        }




        #region Properties

        private string _SearchText;
        public string SearchText
        {
            get => _SearchText; 
            set => SetProperty(ref _SearchText, value);
        }

        #endregion
         
        #region Commands

        public ICommand SearchCommand => new Command(SearchAction);
      
        #endregion


        #region Methods 
        void SearchAction()
        {
            Debug.WriteLine("SearchAction");
        }

        void FilterTappedAction()
        {
            Debug.WriteLine("FilterTappedAction");
        }

        #endregion


        private ICommand _searchTextChangeCommand;
        public ICommand SearchTextChangeCommand
        {
            get
            {
                return _searchTextChangeCommand ?? (_searchTextChangeCommand = new Command<object>((selectedItem) =>
                {
                    object keyword = selectedItem as object;

                }));
            }
        }

    }
}
