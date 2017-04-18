using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ders2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThemePage : ContentPage
    {
        public ThemePage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.Resources["DefaultTitle"] =
                Application.Current.Resources["NewTitle"];

            Application.Current.Resources["DefaultButton"] =
                Application.Current.Resources["NewButton"];

            Application.Current.Resources["DefaultStackLayout"] =
                Application.Current.Resources["NewStackLayout"];

            Application.Current.Resources["DefaultContent"] =
                Application.Current.Resources["NewContent"];
        }
    }
}
