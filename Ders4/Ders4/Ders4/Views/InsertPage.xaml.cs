using Ders4.Helper;
using Ders4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ders4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsertPage : ContentPage
    {
        public InsertPage()
        {
            InitializeComponent();
        }

        private void btn_ekle_Clicked(object sender, EventArgs e)
        {
            SQLiteManager manager = new SQLiteManager();
            Student _student = new Student();
            _student.Name = txt_Name.Text;
            _student.Surname = txt_Surname.Text;
            _student.RegisterDate = DateTime.Now;

            int isInserted = manager.Insert(_student);
            if (isInserted > 0)
            {
                DisplayAlert("Eklendi", _student.Name + " eklendi", "OK");
            }
            else
                DisplayAlert("Eklenemedi", _student.Name + " eklenemedi", "OK");
        }
    }
}
