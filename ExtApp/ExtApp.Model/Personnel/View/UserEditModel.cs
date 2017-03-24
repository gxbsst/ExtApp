﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtApp.Model
{
    /// <summary>
    /// 编辑用户模型
    /// </summary>
    public class UserEditModel
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int? Sex { get; set; }
        public int? DeptID { get; set; }
        public int? RoleID { get; set; }
        public string Duty { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
        public int? Sort { get; set; }
        public string Comment { get; set; }
        public int? Status { get; set; }
    }
}
