﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphql.Entities
{
    public class Comment
    {
        public string Url { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
    }
}
