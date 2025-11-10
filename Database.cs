using MySql.Data.MySqlClient;

namespace ExaminationSystem
{
    public static class Database
    {

        private const string Server = "localhost";
        private const string Port = "3306";
        private const string UserId = "jmbalang";
        private const string Password = "dt117";
        private const string DatabaseName = "examdb";
        private const string _connectionString =
            $"Server={Server};Port={Port};Database={DatabaseName};Uid={UserId};Pwd={Password};";

        public static MySqlConnection GetConnection()
        {
            
            return new MySqlConnection(_connectionString);
        }
    }
}