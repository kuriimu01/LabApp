using LabApp.TBD_But;
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace LabApp.Security
{
    public static class DiscretionaryAccessService
    {
        public static bool Check(UserModel user, ResourceModel resource, string action)
        {
            var rule = DbDataAccess.LoadAccessRules()
                .FirstOrDefault(r => r.UserId == user.Id && r.ResourceId == resource.Id);

            if (rule == null) return false;

            if (!string.IsNullOrWhiteSpace(rule.IpRestrict))
            {
                string localIp = GetLocalIpAddress();
                if (localIp != rule.IpRestrict) return false;
            }

            if (!string.IsNullOrWhiteSpace(rule.TimeStart) && !string.IsNullOrWhiteSpace(rule.TimeEnd))
            {
                if (ParseTime(rule.TimeStart, out TimeSpan start) && ParseTime(rule.TimeEnd, out TimeSpan end))
                {
                    TimeSpan now = DateTime.Now.TimeOfDay;
                    if (now < start || now > end) return false;
                }
            }

            switch (action)
            {
                case "read": return rule.CanRead == 1;
                case "write": return rule.CanWrite == 1;
                case "execute": return rule.CanExecute == 1;
                default: return false;
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