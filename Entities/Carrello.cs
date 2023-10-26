using System.ComponentModel.DataAnnotations;

namespace EsercizioWebAPI.Entities
{
    public class Carrello
    {
        [Key] public int IdCarrello { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public virtual Utente ?Utenti { get; set; }
        public  IEnumerable<Prodotto> ?Prodotti { get; set; }
        //public List<Prodotto> Products { get; set; }
    }
}
