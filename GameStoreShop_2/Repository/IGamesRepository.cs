using GameStoreShop_2.Models;
using System.Numerics;

namespace GameStoreShop_2.Repository
{
    public interface IGamesRepository
    {
        IEnumerable<string> GetAllProducts();
    }
}
