using Ders3.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Ders3.Data
{
    public class MContent
    {
        public class MC
        {
            public string Title { get; set; }
            public string ImageURL { get; set; }
            public string Description { get; set; }
            public DateTime PublishDate { get; set; }
        }

        public static IList<MC> MData { get; set; }
        public static IList<MC> MDataWithGrouping { get; set; }

        public static int RefreshCount { get; set; } = 0;

        static MContent()
        {
            MData = new ObservableCollection<MC>
            {
                new MC
                {
                    Title = "Ders 1",
                    Description = "Xamarin Ders 1",
                    PublishDate = new DateTime(2015, 11, 28),
                    ImageURL = "icon2.png"
                },
                new MC
                {
                    Title = "Ders 2",
                    Description = "Xamarin Ders 2",
                    PublishDate = new DateTime(2016, 10, 20),
                    ImageURL = "grass_PNG4930.png"
                },
                new MC
                {
                    Title = "Anlatım 1",
                    Description = "Xamarin Anlatım 1",
                    PublishDate = new DateTime(2016, 10, 22),
                    ImageURL = "grass_PNG4930.png"
                }
            };
        }

        public static ObservableCollection<Grouping<string, MC>>
            BindingWithGrouping(string searchedText = "")
        {
            var result = MData;
            if (!string.IsNullOrEmpty(searchedText) && searchedText.Length > 2)
            {
                result = result.Where
                    (x => x.Title.ToLower().StartsWith(searchedText.ToLower())).ToList();
            }
            var list = new ObservableCollection<Grouping<string, MC>>
                (result.OrderBy
                (c => RefreshCount % 2 == 0 ? c.PublishDate.ToString() : c.Title)
                .GroupBy(c => c.Title[0].ToString())
                .Select(k => new Grouping<string, MC>(k.Key, k)));
            return list;
        }
    }
}
