using Ders4.Helper;
using SQLite.Net;
using SQLite.Net.Platform.XamarinIOS;
using Ders4.iOS.ConnectionHelper;

[assembly: Xamarin.Forms.Dependency(typeof(GetIOSConnection))]
namespace Ders4.iOS.ConnectionHelper
{
    public class GetIOSConnection : ISQLiteConnection
    {
        public SQLiteConnection GetConnection()
        {
            var _documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var _path = System.IO.Path.Combine(_documentPath, App.DBName);
            var _platform = new SQLitePlatformIOS();
            var _connection = new SQLiteConnection(_platform, _path);
            return _connection;
        }
    }
}
