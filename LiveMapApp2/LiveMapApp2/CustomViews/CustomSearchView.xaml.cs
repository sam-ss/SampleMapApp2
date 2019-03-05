using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LiveMapApp2.CustomViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomSearchView : ContentView
    {
        public CustomSearchView()
        {
            InitializeComponent();
        }

        #region Placeholder 

        public static BindableProperty PlaceholderProperty =
           BindableProperty.Create(
               nameof(Placeholder),
               typeof(string),
               typeof(CustomSearchView),
               defaultValue: default(string),
               defaultBindingMode: BindingMode.OneWay
           );

        public string Placeholder
        {
            get { return (string)GetValue(PlaceholderProperty); }
            set { SetValue(PlaceholderProperty, value); }
        }

        #endregion

        #region BorderColor 

        public static BindableProperty BorderColorProperty =
           BindableProperty.Create(
               nameof(BorderColor),
               typeof(Color),
               typeof(Frame),
               defaultValue: default(Color),
               defaultBindingMode: BindingMode.TwoWay
           );

        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }
        #endregion

        #region TextColor 

        public static BindableProperty TextColorProperty =
           BindableProperty.Create(
               nameof(TextColor),
               typeof(Color),
               typeof(Entry),
               defaultValue: default(Color),
               defaultBindingMode: BindingMode.TwoWay
           );

        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }
        #endregion

        #region EntryStyle  
        public static BindableProperty EntryStyleProperty =
           BindableProperty.Create(
               nameof(EntryStyle),
               typeof(Style),
               typeof(Entry),
               defaultValue: default(Style),
               defaultBindingMode: BindingMode.TwoWay
           );
        public Style EntryStyle
        {
            get { return (Style)GetValue(EntryStyleProperty); }
            set { SetValue(EntryStyleProperty, value); }
        }
        #endregion

        #region Text 

        public static BindableProperty TextProperty =
           BindableProperty.Create(
               nameof(Text),
               typeof(string),
               typeof(SearchBar),
               defaultValue: default(string),
               defaultBindingMode: BindingMode.TwoWay
           );


        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        #endregion

        #region IsSearchbarVisible 

        bool _isSearchbarVisible;

        public bool IsSearchbarVisible
        {
            get { return _isSearchbarVisible; }
            set
            {
                _isSearchbarVisible = value;
                EntryFrame.IsVisible = value;
            }
        }
        #endregion

        #region Source  
        public static BindableProperty SourceProperty =
           BindableProperty.Create(
               nameof(Source),
               typeof(ImageSource),
               typeof(Image),
               defaultValue: default(ImageSource),
               defaultBindingMode: BindingMode.OneWay
           );
        /// <summary>
        /// Search Image Source
        /// </summary>
        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }
        #endregion 

        #region SearchTextChangeCommand
        public static BindableProperty SearchTextChangeCommandProperty =
            BindableProperty.Create(
                nameof(SearchTextChangeCommand),
                typeof(ICommand),
                typeof(Entry),
                defaultValue: null,
                defaultBindingMode: BindingMode.OneWay
            );

        public ICommand SearchTextChangeCommand
        {
            get { return (ICommand)GetValue(SearchTextChangeCommandProperty); }
            set { SetValue(SearchTextChangeCommandProperty, value); }
        }
        #endregion 

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (IsSearchbarVisible == true)
            {
                return;
            }
            if (EntryFrame.IsVisible == true)
            {
                EntryFrame.IsVisible = false;
            }
            else
            {
                EntryFrame.IsVisible = true;
                int transY = 0; //Good for Android
                //if (Device.RuntimePlatform == Device.iOS)
                //    transY = 0; //Good for iOS

                if (EntryFrame.TranslationY != transY)
                    EntryFrame.TranslateTo(0,transY , 100);
               // EntryFrame.TranslateTo(0, 0);
                Text = string.Empty;
            }
        }

        private void SearchEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Text))
            {
                if (SearchTextChangeCommand?.CanExecute(Text) ?? false)
                    SearchTextChangeCommand?.Execute(Text);
            }
        }
    }
}