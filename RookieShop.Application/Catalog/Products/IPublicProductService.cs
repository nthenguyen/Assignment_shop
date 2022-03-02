using RookieShop.Application.Catalog.Products.Dtos;
using RookieShop.Application.Catalog.Products.Dtos.Public;
using RookieShop.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookieShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagedRequest request);
    }
}
