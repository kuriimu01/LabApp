using Dapper;
using LabApp.TBD_But;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

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
        public static List<UserModel> LoadUsers()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                return con.Query<UserModel>("SELECT * FROM Users").ToList();
            }
        }

        public static void SaveUser(UserModel user) {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute(
                    @"INSERT INTO Users 
                    (Username, PasswordHash, UseStrongPassword, SecurityLevel, IsAdmin) 
                    VALUES (@Username, @PasswordHash, @UseStrongPassword, @SecurityLevel, @IsAdmin)",
                    user
                );
            }
        }
        public static void UpdateUser(UserModel user)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute(
                    @"UPDATE Users 
                      SET PasswordHash = @PasswordHash,
                          UseStrongPassword = @UseStrongPassword,
                          SecurityLevel = @SecurityLevel,
                          IsAdmin = @IsAdmin
                      WHERE Id = @Id",
                    user
                );
            }
        }
        public static void UpdateUserLevel(int userId, int level)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute(
                    "UPDATE Users SET SecurityLevel = @Level WHERE Id = @Id",
                    new { Id = userId, Level = level }
                );
            }
        }
        public static void DeleteUser(int userId)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("DELETE FROM Users WHERE Id = @Id", new { Id = userId });
            }
        }



        // RESOURCE 

        public static List<ResourceModel> LoadResources()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                return con.Query<ResourceModel>("SELECT * FROM Resources").ToList();
            }
        }

        public static void AddResource(ResourceModel resource)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute(
                    @"INSERT INTO Resources 
                    (FileName, FilePath, SecurityLevel)
                    VALUES (@FileName, @FilePath, @SecurityLevel)",
                    resource
                );
            }
        }

        public static void UpdateResourceLevel(int resourceId, int level)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute(
                    "UPDATE Resources SET SecurityLevel = @Level WHERE Id = @Id",
                    new { Id = resourceId, Level = level }
                );
            }
        }

        public static void DeleteResource(int resourceId)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute(
                    "DELETE FROM Resources WHERE Id = @Id",
                    new { Id = resourceId }
                );
            }
        }

        public static void UpdateResource(ResourceModel resource)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"
            UPDATE Resources
            SET FileName = @FileName,
                FilePath = @FilePath,
                SecurityLevel = @SecurityLevel
            WHERE Id = @Id
        ";

                con.Execute(sql, resource);
            }
        }

        private static string LoadConnectionString(string id = "Default") {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
