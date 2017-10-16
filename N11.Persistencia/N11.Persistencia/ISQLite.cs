using SQLite.Net;

namespace N11.Persistencia
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
