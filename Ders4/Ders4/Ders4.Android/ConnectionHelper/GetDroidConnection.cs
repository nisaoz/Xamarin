using System;
using Ders4.Helper;
using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;
using Ders4.Droid.ConnectionHelper;

[assembly: Xamarin.Forms.Dependency(typeof(GetDroidConnection))]
namespace Ders4.Droid.ConnectionHelper
{
    class GetDroidConnection : ISQLiteConnection
    {
        public SQLiteConnection GetConnection()
        {
            string _documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var _path = System.IO.Path.Combine(_documentPath, App.DBName);
            var platform = new SQLitePlatformAndroid();
            var connection = new SQLiteConnection(platform, _path);

            return connection;
        }
    }
}