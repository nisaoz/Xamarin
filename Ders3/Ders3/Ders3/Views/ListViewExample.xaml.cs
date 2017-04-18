using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ders3.Views
{
    public class Deneme
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewExample : ContentPage
    {
        public ListViewExample()
        {
            InitializeComponent();

            List<Deneme> deneme = new List<Deneme>();
            deneme.Add(new Deneme { ID = 1, Name = "Nisa", ImageURL = "icon2.png" });
            deneme.Add(new Deneme { ID = 2, Name = "Umut", ImageURL = "icon2.png" });
            deneme.Add(new Deneme { ID = 3, Name = "Tolga", ImageURL = "icon2.png" });

            lstView.ItemsSource = deneme;
        }

        private void lstView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            Deneme selected = (Deneme)e.SelectedItem; //Gelen item'ın Deneme turunde olacagını biliyorduk bu yüzden cast yaptık
            DisplayAlert("Deneme ", selected.Name, "OK");

            //item'ın selected kalmaması icin
            ListView lstview = (ListView)sender;
            lstview.SelectedItem = null;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            DisplayAlert("Button", "Clicked", "OK");
        }
    }
}
