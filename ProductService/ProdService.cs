using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService
{
    public partial class ProdService
    {
        private readonly CommerceObjectContext objectContext;

        public ProdService()
        {
            this.objectContext = new CommerceObjectContext();
        }

        public IEnumerable<Product> GetFeaturedProducts(
        bool isCustomerPreferred)
        {
            var discount = isCustomerPreferred ? .95m : 1;
            var products = (from p in this.objectContext
            .Products
                            where p.IsFeatured
                            select p).AsEnumerable();
            return from p in products
                   select new Product
                   {
                       ProductId = p.ProductId,
                       Name = p.Name,
                       Description = p.Description,
                       IsFeatured = p.IsFeatured,
                       UnitPrice = p.UnitPrice * discount
                   };
        }
    }
}
