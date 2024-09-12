using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Models
{
    public class Store
    {
        public int StoreId { get; set; }

        public string Name { get; set; }

        public List<Sale> sales { get; set; }



    }
}
