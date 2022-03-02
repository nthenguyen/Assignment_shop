using RookieShop.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookieShop.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagedRequest : PagedRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
