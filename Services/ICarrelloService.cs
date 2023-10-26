using EsercizioWebAPI.Entities;

namespace EsercizioWebAPI.Services
{
    public interface ICarrelloService
    {
        Task<Carrello> GetCarrelloAsync(int carrelloId);
        Task<int> InsertCarrelloAsync(Carrello carrello);
    }
}
