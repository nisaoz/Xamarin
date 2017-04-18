using Ders4.Helper;
using Ders4.Droid.Helper;

//Assembly yazılmak zorundaydı cunku Portable tarafında app()'de dependency service'i kullanıyoruz 
[assembly: Xamarin.Forms.Dependency(typeof(DeviceHelper))]
namespace Ders4.Droid.Helper
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetDeviceName()
        {
            return "Ders4.Droid Çalıştırıldı";
        }
    }
}