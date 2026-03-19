using LabApp.TBD_But;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabApp.Security
{
    public static class AccessManager
    {
        public static bool CheckAccess(UserModel user, ResourceModel resource, string action)
        {
            switch (SecuritySettings.CurrentModel)
            {
                case AccessModel.Mandatory:
                    return MandatoryAccessService.Check(user, resource, action);

                case AccessModel.Discretionary:
                    return DiscretionaryAccessService.Check(user, resource, action);

                case AccessModel.RoleBased:
                    return RoleAccessService.Check(user, resource, action);

                default:
                    return false;
            }
        }
    }
}
