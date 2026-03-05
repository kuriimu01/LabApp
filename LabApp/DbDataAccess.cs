using Dapper;
using LabApp.TBD_But;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Data.SQLite;

namespace LabApp
{
    public static class DbDataAccess
    {
        public static UserModel LoadUser(string username) {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                return con.Query<UserModel>(
                    "SELECT * FROM Users WHERE Username = @Username",
                    new { Username = username }
                ).FirstOrDefault();
             }
        }

        public static void SaveUser(UserModel user) {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("INSERT INTO Users (Username, PasswordHash, UseStrongPassword) VALUES (@Username, @PasswordHash, @UseStrongPassword)", user);
            }
        }
        public static void UpdateUser(UserModel user)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("UPDATE Users SET PasswordHash = @PasswordHash, UseStrongPassword = @UseStrongPassword WHERE Id = @Id", user);
            }
        }
        public static void DeleteUser(int userId)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("DELETE FROM Users WHERE Id = @Id", new { Id = userId });
            }
        }
        private static string LoadConnectionString(string id = "Default") {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
