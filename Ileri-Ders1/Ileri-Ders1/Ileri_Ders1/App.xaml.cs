using Plugin.ScreenSize;

using Xamarin.Forms;

namespace Ileri_Ders1
{
    public partial class App : Application
    {
        public App()
        {
            var result = CrossScreenSize.Current.GetScreenSize();

            var content = new ContentPage
            {
                Title = "İleri Xamarin - Ders 1",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        new Label
                        {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Width: " + result.ScreenWidth
                        },
                        new Label
                        {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Height: " + result.ScreenHeight
                        },
                        new Label
                        {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Platfrom Name: " + result.PlatformName
                        }
                    }
                }
            };

            InitializeComponent();
            MainPage = new NavigationPage(content);
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
