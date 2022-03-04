using RookieShop.ViewModels.Catalog.Products;
using RookieShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookieShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagedRequest request);

        Task<List<ProductViewModel>> GetAll();

    }
}
