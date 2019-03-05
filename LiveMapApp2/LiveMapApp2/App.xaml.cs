
using LiveMapApp2.ViewModels;
using LiveMapApp2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace LiveMapApp2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new PinPage();
            // MainPage = new MapMainPage();
            //   MainPage = new Hotels(new HotelsGroupViewModel());
            //  MainPage = new UnitListPage();


         
            MainPage = new NavigationPage(new SearchPage());
            //MainPage = new NavigationPage(new UnitGroupList());
            //MainPage = new NavigationPage(new SampleLoading());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
