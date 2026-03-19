using LabApp.TBD_But;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabApp.Security
{
    public static class MandatoryAccessService
    {
        public static bool Check(UserModel user, ResourceModel resource, string action)
        {
            bool hasLevelAccess = (int)user.SecurityLevel >= (int)resource.SecurityLevel;

            if (!hasLevelAccess) return false;

            switch (action)
            {
                case "read":
                case "write":
                case "execute":
                    return true;
                default:
                    return false;
            }
        }
    }
}
