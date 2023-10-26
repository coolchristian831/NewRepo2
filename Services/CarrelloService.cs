using EsercizioWebAPI.DataSource;
using EsercizioWebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace EsercizioWebAPI.Services
{
    public class CarrelloService : ICarrelloService
    {
        private CommerceContext _commerce;
        public CarrelloService(CommerceContext commerce)
        {
            _commerce = commerce;
        }

        public async Task<Carrello> GetCarrelloAsync(int carrelloId)
        {
            try
            {
                Carrello? carrello = await _commerce.Carrelli.FindAsync(carrelloId);
                if (carrello == null)
                {
                    string errorMessage = "product to modify not found";
                    throw new Exception(errorMessage);
                }
                return carrello;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> InsertCarrelloAsync(Carrello carrello)
        {
            _commerce.Entry(carrello).State = EntityState.Added;
            try
            {
                int numeroRecordsInseriti = await _commerce.SaveChangesAsync();
                if (numeroRecordsInseriti != 1)
                {
                    string messaggioErrore = "Operazione di inerimento non effettuata";
                    throw new Exception(messaggioErrore);
                    
                }

                return numeroRecordsInseriti;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }   
    }
}
