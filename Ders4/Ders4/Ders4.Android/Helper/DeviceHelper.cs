using Ders4.Helper;
using Ders4.Droid.Helper;

//Assembly yaz�lmak zorundayd� cunku Portable taraf�nda app()'de dependency service'i kullan�yoruz 
[assembly: Xamarin.Forms.Dependency(typeof(DeviceHelper))]
namespace Ders4.Droid.Helper
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetDeviceName()
        {
            return "Ders4.Droid �al��t�r�ld�";
        }
    }
}