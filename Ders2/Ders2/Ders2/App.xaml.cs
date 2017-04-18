using Ders2.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ders2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ThemePage();
        }
    }
}
