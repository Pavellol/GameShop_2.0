using GameStoreShop_2.Data;

namespace GameStoreShop_2.Models
{
    public class GameListViewModel
    {
        public IEnumerable<Games> Games { get; set; }
        public PageInfo PagingInfo { get; set; }
    }
}
