using DesafioIbid.Models;

namespace DesafioIbid.Repositories.interfaces
{
    public interface IProduct
    {
        Task<List<ProductModel>> GetAll();
        Task<ProductModel> GetById(int id);
        Task<ProductModel> GetByName(string name);
        Task<ProductModel> CreateProduct(ProductModel product);
        Task<ProductModel> UpdateProduct(ProductModel product, int id);
        Task<bool> DeleteProduct(int id);
    }
}
