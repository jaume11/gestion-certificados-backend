﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*
 * Author Evarist J.
 */

namespace ApiGTT.Models
{
    public class Jira
    {
        public long id { get; set; }
        public long user_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string url { get; set; }
        public string project { get; set; }
        public string component { get; set; }
        public string issueType { get; set; }
        public string description { get; set; }

    }
}
