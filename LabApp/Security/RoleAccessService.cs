using LabApp.TBD_But;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabApp.Security
{
    public static class RoleAccessService
    {
        public static bool Check(UserModel user, ResourceModel resource, string action)
        {

            var roleRule = DbDataAccess.LoadRoleAccessRules()
                .FirstOrDefault(r => r.RoleId == user.RoleId && r.ResourceId == resource.Id);

            if (roleRule == null) return false;

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
    }
}
