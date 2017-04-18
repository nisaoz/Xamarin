using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ders4.CustomControls
{
    public class CustomDatePicker : DatePicker
    {
        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create<CustomDatePicker, Color>( p => p.TextColor, Color.Red);

        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }
    }
}
