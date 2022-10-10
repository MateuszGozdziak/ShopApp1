using ShopApp1.Entities;

namespace ShopApp1.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);


    }
}
