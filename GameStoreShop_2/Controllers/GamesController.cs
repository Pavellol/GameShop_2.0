using GameStoreShop_2.Data;
using GameStoreShop_2.Models;
using GameStoreShop_2.Repository;
using GameStoreShop_2.TagHelpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace GameStoreShop_2.Controllers
{

    public class GamesController : Controller
    {        
        public int pageSize = 4;
                      
        EFDbContext db;
        public GamesController(EFDbContext context)
        {
            db = context;

        }

        public IActionResult Index(int page = 1)
        {
            // Используем ToList() для получения списка игр
         
            int pageSize = 2; // Задайте количество игр на странице
            var totalItems = db.Games.Count();
            var games = db.Games.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            var viewModel = new IndexViewModel
            {
                Items = games,
                PageInfo = new PageInfo
                {
                    TotalItems = totalItems,
                    CurrentPage = page,
                    PageSize = pageSize
                }
            };

            return View(viewModel); // Передаем объект YourViewModel в представление

            /*int pageSize = 3; // количество элементов на странице
            var totalItems = db.Games.Count();

            var items = db.Games
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var viewModel = new IndexViewModel
            {
                Items = items,
                PageInfo = new PageInfo
                {
                    TotalItems = totalItems,
                    CurrentPage = page,
                    ItemsPerPage = pageSize
                }
            };

            return View(viewModel);*/

            /*return View(db.Games
                .OrderBy(game => game.gameid)
                .Skip((page - 1) * pageSize)
                .Take(pageSize));*/
        }       
    }
}
