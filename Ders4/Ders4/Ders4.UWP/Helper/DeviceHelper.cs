using Ders4.Helper;
using Ders4.UWP.Helper;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceHelper))]
namespace Ders4.UWP.Helper
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetDeviceName()
        {
            return "Ders4.UWP Çalıştırıldı";
        }
    }
}
