using HotelListing5._0.Models;
using System.Threading.Tasks;

namespace HotelListing5._0.Services
{
    public interface IAuthManager
    {

        Task<bool> ValidateUser(LoginUserDTO userDTO);

        Task<string> CreateToken();
    }
}
