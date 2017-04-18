using Ders4.CustomControls;
using Ders4.UWP.CustomRenderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace Ders4.UWP.CustomRenderer
{
    class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
            {
                Control.PlaceholderText = "Xamarin Windows";
                Control.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(100,200,100,150));

                Control.GotFocus += Control_GotFocus;
                Control.LostFocus += Control_LostFocus;
            }
        }

        private void Control_LostFocus(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Control_GotFocus(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
