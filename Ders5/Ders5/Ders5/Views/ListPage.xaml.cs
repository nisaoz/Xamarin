using Ders5.Models;
using Ders5.Provider;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ders5.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        readonly ServiceManager manager = new ServiceManager();
        readonly IList<StudentModel> model = new ObservableCollection<StudentModel>();

        public ListPage()
        {
            BindingContext = model;
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            IsBusy = true;
            try
            {
                model.Clear();
                await Task.Delay(2000);
                var collection = await manager.GetAll();
                foreach (StudentModel item in collection)
                    model.Add(item);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private void onNew_Clicked(object sender, EventArgs e)
        {
            //PushModalAsync ile insert() sayfasını acıyoruz
            Navigation.PushModalAsync(new Insert());
        }

        private void onRefresh_Clicked(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lstStudents_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListView lstView = (ListView)sender;
            if(e.SelectedItem != null)
            { 
                var selectedStudent = (StudentModel)e.SelectedItem;
                Navigation.PushAsync(new DetailPage(selectedStudent));
            }

            lstView.SelectedItem = null;
        }

        private async void sil_Clicked(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var selectedStudent = (StudentModel)menuItem.CommandParameter;
            var isOk = await DisplayAlert("", "Emin misiniz?", "OK", "İptal");
            if (isOk)
            {
                await manager.Delete(selectedStudent);
                model.Remove(selectedStudent);
            }
        }
    }
}
