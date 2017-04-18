using Ders5.Models;
using Ders5.Provider;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ders5.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Update : ContentPage
    {
        public Update(StudentModel model)
        {
            InitializeComponent();
            txt_name.Text = model.Name;
            txt_surname.Text = model.Surname;
            txt_about.Text = model.About;
            datepckr_birthData.Date = model.BirthDate;
        }

        private async void btn_update_Clicked(object sender, EventArgs e)
        {
            StudentModel model = new StudentModel
            {
                Name = txt_name.Text,
                Surname = txt_surname.Text,
                About = txt_about.Text,
                BirthDate = datepckr_birthData.Date
            };

            ServiceManager manager = new ServiceManager();
            MobileResult result = await manager.Update(model);
            if (result.Result)
            {
                await DisplayAlert("Success", result.Message, "OK", "İptal");
                await Navigation.PopAsync();
            }
        }
    }
}
