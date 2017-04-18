using Ders3.Data;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ders3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SanalSiniflar : ContentPage
    {
        public SanalSiniflar()
        {
            InitializeComponent();
            lstMC.BindingContext = MContent.BindingWithGrouping();

            lstMC.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async (t) =>
                {
                    await lstMC.ScaleTo(0.95, 100, Easing.CubicOut);
                    await lstMC.ScaleTo(1, 50, Easing.CubicIn);
                    await lstMC.RotateYTo(360, 1500, Easing.SpringIn);
                })
            }); //sağa, sola kaydırma, dokunma işlemleri icin
        }

        private async void lstMC_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            ListView lv = (ListView)sender;
            var selectedMC = (MContent.MC)e.SelectedItem;
            //DisplayAlert(selectedMC.PublishDate.ToString("yyyy-MM-dd")
            //    +" " + selectedMC.Title, selectedMC.Description, "OK" );

            bool isOK = await DisplayAlert(selectedMC.PublishDate.ToString("yyyy-MM-dd")
                +" " + selectedMC.Title, selectedMC.Description, "Detay", "Vazgeç");

            if (isOK)
            {
                Navigation.PushAsync(new Detail(selectedMC));
                //Navigation.PushModalAsync(new Detail(selectedMC));
            }

            lv.SelectedItem = null;
        }

        private void lstMC_Refreshing(object sender, System.EventArgs e)
        {
            MContent.RefreshCount++;
            lstMC.BindingContext = MContent.BindingWithGrouping();
            lstMC.IsRefreshing = false;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(e.NewTextValue.Length > 2)
            {
                lstMC.BindingContext = MContent.BindingWithGrouping(e.NewTextValue);
            }
            else if(string.IsNullOrEmpty(e.NewTextValue))
            {
                lstMC.BindingContext = MContent.BindingWithGrouping();
            }
        }

        private void MenuItem_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Güncelle", "Menu Item", "OK", "İptal");
        }
    }
}
