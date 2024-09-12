using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }  = null!;
        public int Quantity { get; set; } 
        public decimal Price { get; set; }
        public string Description { get; set; }

        public List<Sale> sales { get; set; }

    }
}
