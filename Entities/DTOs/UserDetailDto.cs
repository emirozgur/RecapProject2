﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class UserDetailDto
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
    }
}
