using RookieShop.Application.Catalog.Products.Dtos;
using RookieShop.Application.Catalog.Products.Dtos.Manage;
using RookieShop.Application.Dtos;

namespace RookieShop.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addQuantity);

        Task AddViewCount(int productId);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagedRequest request);
    }
}
