using System.Data;
using System.Data.SqlClient;

namespace Agenda
{
    internal static class ContextDB
    {
        private const string connectionServer = "WINAPJCNZBCAGFY\\SQLEXPRESS";

        internal static SqlConnection CreateConnection(string db) => new(BuildConnectionString(db));
        private static string BuildConnectionString(string db) =>
            $"Server={connectionServer};Database={db};Trusted_Connection=True;";

    }
}
