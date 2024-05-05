﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    /// <summary>
    /// Class cấu hình sender - người gửi mail qua giao thức SMTP
    /// </summary>
    public class EmailConfiguration
    {
        public string? From { get; set; } = null!;
        public string? SmtpServer { get; set; } = null!;
        public int Port{ get; set; }
        public string? UserName { get; set; } = null!;
        public string? Password { get; set; } = null!;

        public string? SenderName { get; set; }
    }
}