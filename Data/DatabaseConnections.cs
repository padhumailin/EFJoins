
namespace API.Data
{
    /// <summary>
    /// Class for managing the sql db connection strings
    /// </summary>
    public static class DatabaseConnections
    {
        /// <summary>
        /// Read only DB connecting string
        /// </summary>
        private static string readOnlyDbConnectionString = string.Empty;

        /// <summary>
        /// Read - Write only DB connecting string
        /// </summary>
        private static string readWriteDbConnectionString = string.Empty;

        /// <summary>
        /// Public variable to handle the connection string for read-only db
        /// </summary>
        public static string ReadOnlyDBConnectionString
        {
            get
            {
                // Update Local sql database connection string here
                return "Data Source=xxxxxx;Initial Catalog=xxxxxxxxx;Persist Security Info=True;User ID=xxxxxxxxxxxxxxxxxxxx;Password=xxxxxxxxxxxxxxxx;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;";
            }
        }

    }
}
