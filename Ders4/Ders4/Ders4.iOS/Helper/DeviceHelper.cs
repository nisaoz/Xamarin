using Ders4.Helper;
using Ders4.iOS.Helper;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceHelper))]
namespace Ders4.iOS.Helper
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetDeviceName()
        {
            return "Ders4.IOS Çalıştırıldı";
        }
    }
}
