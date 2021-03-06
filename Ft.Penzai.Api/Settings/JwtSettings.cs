﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ft.Penzai.Api.Settings
{
    public class JwtSettings
    {
        public string SecretKey { get; set; }

        public string Issuer { get; set; }

        public string Audience { get; set; }

        public int ExpireInDays { get; set; }

    }
}
