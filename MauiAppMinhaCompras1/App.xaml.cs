using MauiAppMinhaCompras123.Helpers;
using SQLite;

namespace MauiAppMinhaCompras1
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper _db;

        public static SQLiteDatabaseHelper Db
        {
            get
            {
                if (_db == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData),
                        "banco_sqlite_compras.db");

                    _db = new SQLiteDatabaseHelper(path);
                }

                return _db;
            }
        }
    }
}