using Ders4.Models;
using SQLite.Net;
using System.Linq;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Ders4.Helper
{
    class SQLiteManager
    {
        SQLiteConnection _sqlConnection;

        public SQLiteManager()
        {
            _sqlConnection = DependencyService.Get<ISQLiteConnection>().GetConnection();
            _sqlConnection.CreateTable<Student>();
        }

        //Create, read, update, delete
        #region CRUD
        public int Insert(Student s)
        {
            return _sqlConnection.Insert(s);
        }

        public int Update(Student s)
        {
            return _sqlConnection.Update(s);
        }

        public int Delete(int id)
        {
            return _sqlConnection.Delete<Student>(id);
        }

        public List<Student> GetAll()
        {
            return _sqlConnection.Table<Student>().ToList();
        }
        
        public Student Get(int id)
        {
            return _sqlConnection.Table<Student>().Where(x => x.ID == id).FirstOrDefault();
        }

        public void Dispose()
        {
            _sqlConnection.Dispose();
        }
        #endregion
    }
}
