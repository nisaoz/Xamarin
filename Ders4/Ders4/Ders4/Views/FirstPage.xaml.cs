using Ders4.CustomControls;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ders4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage(string deviceName)
        {
            InitializeComponent();
            txt_DeviceName.Text = deviceName;

            CustomEntry newEntry = new CustomEntry();

            //normalde datepicker'ın bir textcolor propertysi yok 
            //biz bu ozelligi saglamak icin custom bir date picker olurturduk
            CustomDatePicker datepicker = new CustomDatePicker();
            datepicker.TextColor = Device.OnPlatform(Color.Blue, Color.Fuchsia, Color.Purple);
            //datepicker.TextColor = Color.Fuchsia;
 
            Content = new StackLayout
            {
                Children =
                {
                    txt_DeviceName,
                    newEntry,
                    datepicker
                } 
            };
        }
    }
}
