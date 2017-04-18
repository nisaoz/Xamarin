using Ders4.Helper;
using Ders4.Views;
using Xamarin.Forms;

namespace Ders4
{
    public partial class App : Application
    {
        public static string DBName { get; set; } = "Ders4.db3";
        public App()
        {
            //Butun helper'lar idevicehelper interface'inden geldigi icin onu yazdık
            string _deviceName = DependencyService.Get<IDeviceHelper>().GetDeviceName();
            //MainPage = new FirstPage(_deviceName);
            MainPage = new NavigationPage(new ListPage());
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
