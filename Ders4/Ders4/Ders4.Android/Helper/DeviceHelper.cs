using Ders4.Helper;
using Ders4.Droid.Helper;

//Assembly yazýlmak zorundaydý cunku Portable tarafýnda app()'de dependency service'i kullanýyoruz 
[assembly: Xamarin.Forms.Dependency(typeof(DeviceHelper))]
namespace Ders4.Droid.Helper
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetDeviceName()
        {
            return "Ders4.Droid Çalýþtýrýldý";
        }
    }
}