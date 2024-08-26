using GameStoreShop_2.Data;

namespace GameStoreShop_2.Models
{
    public class IndexViewModel
    {/*
        public IEnumerable<Games> Games { get; }
        public PageViewModel PageViewModel { get; }
        public IndexViewModel(IEnumerable<Games> games, PageViewModel viewModel)
        {
            Games = games;
            PageViewModel = viewModel;
        }*/
        public IEnumerable<Games> Items { get; set; } // Данные для отображения
        public PageInfo PageInfo { get; set; } // Информация о пагинации
    }
}
