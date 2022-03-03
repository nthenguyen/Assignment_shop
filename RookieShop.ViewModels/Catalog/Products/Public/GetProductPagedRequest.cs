
using RookieShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookieShop.ViewModels.Catalog.Products.Public
{
    public class GetProductPagedRequest : PagedRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
