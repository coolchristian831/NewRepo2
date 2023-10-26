using EsercizioWebAPI.DTO;
using EsercizioWebAPI.Entities;

namespace EsercizioWebAPI.Services
{
    public interface IUtenteService
    {
        Task<List<Utente>> GetAllUtenti();
        Task<Utente> GetUtente(int id); // qua ci va il DTO
        Task ModifyPasswordUtente(int id, PasswordUtenteDTO pass); // qua pure


    }
}
