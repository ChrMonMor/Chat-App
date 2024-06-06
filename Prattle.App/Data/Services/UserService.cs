using Prattle.App.Data.Interfaces;
using Prattle.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prattle.App.Data.Services
{
    public class UserService : IUserService
    {
        public Task<UserDTO> CreateProduct(UserDTO product)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> DeleteProduct(string guid)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDTO>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDTO>> GetProducts(string guid)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> UpdateProduct(UserDTO product)
        {
            throw new NotImplementedException();
        }
    }
}
