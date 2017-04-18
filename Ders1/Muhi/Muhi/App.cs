using Muhi.Layouts;
using Muhi.Views;

using Xamarin.Forms;

namespace Muhi
{
    public class App : Application
    {
        public App()
        {
            MainPage = new AbsoluteExample();
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
