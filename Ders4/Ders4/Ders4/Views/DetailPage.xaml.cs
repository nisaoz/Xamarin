using Ders4.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ders4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Student _student)
        {
            InitializeComponent();
            lbl_Name.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            lbl_Surname.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));

            lbl_Name.Text = _student.Name;
            lbl_Surname.Text = _student.Surname;
        }
    }
}
