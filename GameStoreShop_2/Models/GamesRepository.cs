using System.Numerics;
using System;
using GameStoreShop_2.Data;
using Microsoft.EntityFrameworkCore;
using GameStoreShop_2.Repository;

namespace GameStoreShop_2.Models
{
    public class GamesRepository : IGamesRepository
    {
        private readonly EFDbContext _context;

        public GamesRepository(EFDbContext context)
        {
            _context = context;
        }

        public IEnumerable<string> GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
