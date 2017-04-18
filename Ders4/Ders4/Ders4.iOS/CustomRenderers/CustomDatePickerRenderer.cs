using Ders4.CustomControls;
using Ders4.iOS.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomDatePicker),typeof(CustomDatePickerRenderer))]
namespace Ders4.iOS.CustomRenderers
{
    public class CustomDatePickerRenderer : DatePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);

            CustomDatePicker picker = (CustomDatePicker)Element;
            if(picker != null)
            {
                Control.TextColor = picker.TextColor.ToUIColor();
            }
        }
    }
}
