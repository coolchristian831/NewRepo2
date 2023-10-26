using System.ComponentModel.DataAnnotations;

namespace EsercizioWebAPI.Entities
{
    public class Prodotto
    {
        [Key] public int IdProdotto { get; set; }
        [MinLength(4)] public string? Name { get; set; }
        
        public decimal Price { get; set; }
        public int Giacenza { get; set; }



    }
}
