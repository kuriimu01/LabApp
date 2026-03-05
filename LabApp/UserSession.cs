using LabApp.TBD_But;

namespace LabApp
{
    public static class UserSession
    {
        public static UserModel CurrentUser { get; private set; }

        public static void Login(UserModel user)
        {
            CurrentUser = user;
        }

        public static void Logout() {
            CurrentUser = null;
        }

        public static bool IsAuthenticated()
        {
            return CurrentUser != null;
        }
    }
}
