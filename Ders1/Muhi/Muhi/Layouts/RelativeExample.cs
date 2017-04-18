using Xamarin.Forms;

namespace Muhi
{
    class RelativeExample : ContentPage
    {
        public RelativeExample()
        {
            RelativeLayout layout = new RelativeLayout();

            BoxView blue = new BoxView();
            blue.BackgroundColor = Color.Blue;
            layout.Children.Add(blue, Constraint.Constant(50), Constraint.Constant(50));

            BoxView red = new BoxView();
            red.BackgroundColor = Color.Red;
            red.Opacity = 0.6;

            /*
            parent => relative layout'u gosteriyor
            toView(istenilen isim verilebilir) => kullanmak istenilen blue box'ı gösterir
            Hem parent'ın hem de blue box'ın X ve Y değerlerine erişebiliriz.*/
            layout.Children.Add(red, Constraint.RelativeToParent((Parent) =>
            {
                return Parent.X + 70;
            }), Constraint.RelativeToView(blue, (Parent, toView) =>
            {
                return toView.Y;
            }));

            /*Children'ın X degerini parent'dan alıp Y değerini el ile girdik
            layout.Children.Add(red, Constraint.RelativeToParent((Parent) => {
                return Parent.X + 70;
            }), Constraint.Constant(70));*/

            /*childen'a manuel değer verme
            layout.Children.Add(red, Constraint.Constant(70), Constraint.Constant(70));*/

            Content = layout;
        }
    }
}
