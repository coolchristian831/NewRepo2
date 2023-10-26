using EsercizioWebAPI.DataSource;
using EsercizioWebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace EsercizioWebAPI.Services
{
    public class ProdottoService : IProdottoService
    {
        private CommerceContext _commerce;
        public ProdottoService(CommerceContext commerce)
        {
            _commerce = commerce;
        }
        public async Task<int> InserisciProdotto(Prodotto p)
        {
            _commerce.Entry(p).State = EntityState.Added;
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
