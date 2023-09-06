﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User.Queries.LoginUser
{
    public sealed record LoginUserDto
    {
        public string Token { get; set; } = string.Empty;
    }
}
