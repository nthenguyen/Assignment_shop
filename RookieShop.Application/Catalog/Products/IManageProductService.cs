using Microsoft.AspNetCore.Http;
using RookieShop.ViewModels.Catalog.Products;
using RookieShop.ViewModels.Catalog.Products.Manage;
using RookieShop.ViewModels.Common;

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

        Task<int> AddImages(int productId, List<IFormFile> files);

        Task<int> UpdateImages(int imageId, string Caption, bool isDefault);

        Task<int> RemoveImages(int imageId);

        Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
