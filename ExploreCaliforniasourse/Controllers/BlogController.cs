﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCaliforniasourse.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return new ContentResult { Content="Blog Posts"};
        }

        public IActionResult Post(string id)
        {
            return new ContentResult { Content=id};
        }
    }
}