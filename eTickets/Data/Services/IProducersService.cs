using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IProducersService
    {
        Task <IEnumerable<Producer>> GetAll();

        Producer GetById(int id);

        void Add(Producer producer);    

        Producer Update(int id, Producer producer); 

        void Delete(int id);
    }
}
