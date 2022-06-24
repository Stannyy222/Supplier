﻿using System.ComponentModel.DataAnnotations;

namespace Supplier.App.Models
{
    public class productVM
    {
        public int ProductID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Qty { get; set; }
        public string Unit { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime DateModified { get; set; } = DateTime.Now;
    }
}
