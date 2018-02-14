﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace DesignPattern.Repo.Model
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
    }
}
