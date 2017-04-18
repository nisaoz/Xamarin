using Muhi.MasterPages;
using Xamarin.Forms;

namespace Muhi.Views
{
    class MyMasterPage : MasterDetailPage
    {
        public MyMasterPage()
        {
            Padding = new Thickness(0, 20,0,0);
            Master = new MyMenu(); //Sol tarafta da master
            Detail = new MyMenu(); //İlk acıldıgında detail sayfası acılacak
        }
    }
}
