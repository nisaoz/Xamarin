using Ders5.Models;
using Ders5.Provider;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ders5.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Insert : ContentPage
    {
        public Insert()
        {
            InitializeComponent();
        }

        private async void btn_save_Clicked(object sender, EventArgs e)
        {
            StudentModel model = new StudentModel
            {
                Name = txt_name.Text,
                Surname = txt_surname.Text,
                About = txt_about.Text,
                BirthDate = datepckr_birthData.Date
            };

            ServiceManager manager = new ServiceManager();
            MobileResult result =await manager.Insert(model);
            if (result.Result)
            {
                await DisplayAlert("Process", result.Message, "OK", "İptal");
                //PopModalAsync acılan en son sayfanın kapanmasını saglar
                await Navigation.PopModalAsync();
            }
            else await DisplayAlert("Error", result.Message, "OK");
        }
    }
}