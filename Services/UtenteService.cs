using EsercizioWebAPI.DataSource;
using EsercizioWebAPI.DTO;
using EsercizioWebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace EsercizioWebAPI.Services
{
    public class UtenteService : IUtenteService
    {
        private CommerceContext _commerce;

        public UtenteService(CommerceContext commerce)
        => (_commerce) = (commerce);
        public async Task<List<Utente>> GetAllUtenti()
        {

            var listaUtenti = await _commerce.Utenti.ToListAsync();
            return listaUtenti;
        }

        public async Task<Utente> GetUtente(int id)
        {
            var utente = await _commerce.Utenti.FindAsync(id);
            return utente;
        }

        public async Task ModifyPasswordUtente(int id, PasswordUtenteDTO pass)
        {
            Utente ut = new Utente();
            ut.Password = pass.Password;
            Utente? utente = await GetUtente(id);
            if (utente == null)
            {
                string errorMessage = "utente to modify not found";
                throw new Exception(errorMessage);
            }
            _commerce.Entry(ut).State = EntityState.Modified;
            
           await _commerce.SaveChangesAsync();
            
        }
    }
}
