using EsercizioWebAPI.Entities;

namespace EsercizioWebAPI.Services
{
    public interface IProdottoService
    {
        Task<int> InserisciProdotto(Prodotto p);
    }
}
