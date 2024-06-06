using Prattle.App.Models;

namespace Prattle.App.Data.Interfaces
{
    internal interface IUserService
    {
        Task<List<UserDTO>> GetProducts();
        Task<List<UserDTO>> GetProducts(string guid);
        Task<UserDTO> CreateProduct(UserDTO product);
        Task<UserDTO> UpdateProduct(UserDTO product);
        Task<UserDTO> DeleteProduct(string guid);
    }
}
