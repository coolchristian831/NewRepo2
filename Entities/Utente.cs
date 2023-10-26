using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace EsercizioWebAPI.Entities
{
    public class Utente
    {
        [Key] public int IdCliente { get; set; }
        [Required][MinLength(4)] public string? Name { get; set; }
        [Required][MinLength(4)] public string? Surname { get; set; }
        [Required][Range(typeof(DateTime), "1900-01-01", "2005-12-31", ErrorMessage = "Devi avere almeno 18 anni")] 
        public DateTime BirthDate { get; set; }
        [Required][EmailAddress] public string? Email { get; set; }
        [Required][PasswordPropertyText] public string? Password { get; set; }

        public virtual Carrello ?Carrelli {  get; set; }


    }
}
