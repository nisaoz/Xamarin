using Ders5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ders5.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(StudentModel model)
        {
            InitializeComponent();
            lblName.Text = model.Name;
            lblSurname.Text = model.Surname;
            lblBirthD.Text = model.BirthDate.ToString("dd-MM-yyyy");
            lblAbout.Text = model.About;
        }
    }
}
