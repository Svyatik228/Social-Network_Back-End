﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Neo4J.Entities
{
    public class Neo4JUser : Neo4jEntity
    {
        public string UserId { get; set; }
        public Neo4JUser()
        {
            Label = "User";
        }
    }
}
