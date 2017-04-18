using Muhi.TabbedPages;
using Xamarin.Forms;

namespace Muhi.Views
{
    //TabbedPage: Yukarıda tablar olusturarak bu tablar arasında gecisler saglar
     
    public class MyTabbedPage : TabbedPage
    {
        public MyTabbedPage()
        {
            Children.Add(new Tab1());
            Children.Add(new Tab2());
        }
    }
}
