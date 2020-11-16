﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WingtipToys.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}