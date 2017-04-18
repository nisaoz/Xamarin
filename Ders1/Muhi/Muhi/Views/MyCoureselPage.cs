using Muhi.TabbedPages;
using Xamarin.Forms;

namespace Muhi.Views
{
    //CarouselPage: Swipe ile sayfalar arası gecisler saglar

    public class MyCoureselPage : CarouselPage
    {
        public MyCoureselPage()
        {
            Children.Add(new Tab1());
            Children.Add(new Tab2());
        }
    }
}
