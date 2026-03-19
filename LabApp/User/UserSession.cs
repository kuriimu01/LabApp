using LabApp.TBD_But;

namespace LabApp
{
    public static class UserSession
    {
        public static UserModel CurrentUser { get; private set; }

        public static bool IsAuthenticated => CurrentUser != null;

        public static bool IsAdmin => CurrentUser?.IsAdmin == 1;

        public static string Role => ((UserRole)CurrentUser.RoleId).ToString();
        public static void Login(UserModel user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
