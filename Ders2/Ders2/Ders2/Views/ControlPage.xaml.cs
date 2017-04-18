using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ders2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlPage : ContentPage
    {
        public ControlPage()
        {
            InitializeComponent();
            myDatePicker.MinimumDate = DateTime.Now.AddYears(-1);
            myDatePicker.MaximumDate = DateTime.Now.AddYears(+1);
            myDatePicker.Date = DateTime.Now;
            myDatePicker.Format = "yyyy-MM-dd";

            /*Label header = new Label
            {
                Text = "WebView",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            WebView wView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://www.acikakademi.com"
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    wView
                }
            };*/
        }

        int i = 0;
        private void btn_click_Clicked(object sender, EventArgs e)
        {
            processBar.ProgressTo(.7, 1250, Easing.BounceIn);
            if(i % 2 == 0) activity.IsRunning = true;
            else activity.IsRunning = false;

            i++;
        }

        private void onPicker_Changed(object sender, EventArgs e)
        {
            Picker pckr = (Picker)sender;
            string selected = pckr.Items[pckr.SelectedIndex];
            DisplayAlert("Picker", selected, "OK", "Cancel");
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lbl_stepper.Text = e.NewValue.ToString();
        }

        private async void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            //DisplayAlert async bir fonksiyondur.
            //Await kullanarak bu fonksiyonun sonuc olarak ne dondurdugunu görebiliriz.
            bool isOk = await DisplayAlert("Switch", e.Value.ToString(), "OK", "Cancel");
            if (isOk)
            {
                //OK
            }
            else
            {
                //Cancel
            }
        }
    }
}
