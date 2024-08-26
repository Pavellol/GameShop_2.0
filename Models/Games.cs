using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStoreShop_2.Models
{
    [Table("games")]
    public class Games
    {
        [Key]
        public int gameid  { get; set; } 
        public string name { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public int price { get; set; }
    }
}
