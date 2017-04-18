using Ders3.Data;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ders3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : ContentPage
    {
        public Detail(MContent.MC selected)
        {
            InitializeComponent();

            lbl_Title.Text = selected.Title;
            lbl_Description.Text = selected.Description;
        }
    }
}
