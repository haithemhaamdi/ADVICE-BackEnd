using PersonnelASPnetCore.Data.Permissions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Data.ViewModels
{
    public class PermissionViewModel
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }


        public static explicit operator PermissionViewModel(ApplicationPermission permission)
        {
            return new PermissionViewModel
            {
                Name = permission.Name,
                Value = permission.Value,
                GroupName = permission.GroupName,
                Description = permission.Description
            };
        }
    }
}
