using Ders4.Helper;
using Ders4.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ders4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        SQLiteManager manager;
        public ListPage()
        {
            InitializeComponent();

            List<Student> studentList = new List<Student>();
            manager = new SQLiteManager();
            studentList = manager.GetAll();
            lstStudents.BindingContext = studentList;
        }

        private void Ekle_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertPage());
        }

        private void Yenile_Activated(object sender, EventArgs e)
        {
            List<Student> studentList = new List<Student>();
            studentList = manager.GetAll();
            lstStudents.BindingContext = studentList;
        }

        private async void btn_sil_Clicked(object sender, EventArgs e)
        {
            var selectedMenuItem = (MenuItem)sender;
            var selectedStudent = manager.Get(Convert.ToInt32
               (selectedMenuItem.CommandParameter.ToString()));

            bool isOK = await DisplayAlert("UYARI", selectedStudent.Name + " silinecek", "OK", "İptal");
            if (isOK)
            {
                int isDeleted = manager.Delete(Convert.ToInt32
                    (selectedMenuItem.CommandParameter.ToString()));

                if (isDeleted > 0) DisplayAlert("Başarılı", "Silindi", "OK");
                else DisplayAlert("Başarısız", "Silinemedi", "OK");
            }
        }

        private void btn_detay_Clicked(object sender, EventArgs e)
        {
            var selectedMenuItem = (MenuItem)sender;
            var selectedStudent = manager.Get(Convert.ToInt32
                (selectedMenuItem.CommandParameter.ToString()));
            Navigation.PushAsync(new DetailPage(selectedStudent));
        }
    }
}
