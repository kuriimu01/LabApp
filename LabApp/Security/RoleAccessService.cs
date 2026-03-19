using LabApp.TBD_But;
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace LabApp.Security
{
    public static class RoleAccessService
    {
        public static bool Check(UserModel user, ResourceModel resource, string action)
        {
            var roleRule = DbDataAccess.LoadRoleAccessRules()
                .FirstOrDefault(r => r.RoleId == user.RoleId && r.ResourceId == resource.Id);

            if (roleRule == null) return false;

            if (!string.IsNullOrWhiteSpace(roleRule.IpRestrict))
            {
                string localIp = GetLocalIpAddress();
                if (localIp != roleRule.IpRestrict) return false;
            }

            if (!string.IsNullOrWhiteSpace(roleRule.TimeStart) && !string.IsNullOrWhiteSpace(roleRule.TimeEnd))
            {
                if (ParseTime(roleRule.TimeStart, out TimeSpan start) && ParseTime(roleRule.TimeEnd, out TimeSpan end))
                {
                    TimeSpan now = DateTime.Now.TimeOfDay;

                    if (start <= end)
                    {
                        if (now < start || now > end) return false;
                    }
                    else
                    {
                        if (now < start && now > end) return false;
                    }
                }
            }

            switch (action)
            {
                case "read":
                    return roleRule.CanRead == 1;
                case "write":
                    return roleRule.CanWrite == 1;
                case "execute":
                    return roleRule.CanExecute == 1;
                default:
                    return false;
            }
        }

        private static bool ParseTime(string timeStr, out TimeSpan time)
        {
            if (TimeSpan.TryParse(timeStr, out time))
            {
                if (time.Days > 0 && !timeStr.Contains(":"))
                {
                    time = TimeSpan.FromHours(time.Days);
                }
                return true;
            }
            return false;
        }

        private static string GetLocalIpAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
    }
}