﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Testing
{
    public class Class1 : Controller
    {
        public Task SomeAsync()
        {
            return Task.CompletedTask;
        }
    }
}
