﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.BLL.DTOs
{
   public class CategoriesDTOs
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
    public class ProductsDTO
    {
        public int ProductsId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
