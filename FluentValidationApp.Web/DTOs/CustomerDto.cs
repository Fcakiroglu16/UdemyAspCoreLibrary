﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        public int Age { get; set; }
    }
}