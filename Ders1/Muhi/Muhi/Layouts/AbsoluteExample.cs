using Xamarin.Forms;

namespace Muhi.Layouts
{
    class AbsoluteExample : ContentPage
    {
        public AbsoluteExample()
        {
            AbsoluteLayout absolute = new AbsoluteLayout();

            BoxView blue = new BoxView();
            blue.BackgroundColor = Color.Blue;
            absolute.Children.Add(blue);

            BoxView red = new BoxView();
            red.BackgroundColor = Color.Red;
            absolute.Children.Add(red, new Rectangle(50, 50, 100, 150));

            Content = absolute;
        }
    }
}
