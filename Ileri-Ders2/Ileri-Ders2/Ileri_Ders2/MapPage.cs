using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Ileri_Ders2
{
    public class MapPage : ContentPage
    {
        public MapPage()
        {
            CreateMap();
        }

        void CreateMap()
        {
            Map currentMap = new Map
            {
                HasScrollEnabled = true,
                HasZoomEnabled = true,
                MapType = MapType.Hybrid
            };

            Content = currentMap;
        }
    }
}
