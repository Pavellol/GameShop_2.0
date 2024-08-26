using GameStoreShop_2.Models;

namespace GameStoreShop_2.Abstract
{
    public interface IGamesRepository
    {
        IEnumerable<string> GetAllProducts();
    }
}
