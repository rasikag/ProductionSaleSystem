using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductService.Models;

namespace ProductService
{
    public class CommerceObjectContext
    {
        // extend the EF DB context class in here
        public List<Product> Products { get; set; }
    }
}
