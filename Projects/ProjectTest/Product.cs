﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProdName { get; set; }

        public override string ToString()
        {
            return ProdName;
        }
    }
}