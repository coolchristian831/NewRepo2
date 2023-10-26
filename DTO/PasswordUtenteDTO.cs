using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EsercizioWebAPI.DTO
{
    public class PasswordUtenteDTO
    {
        [Required][PasswordPropertyText] public string? Password { get; set; }
    }
}
