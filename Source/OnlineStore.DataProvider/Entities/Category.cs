﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public string PageDescription { get; set; }

        public string PageKeywords { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
