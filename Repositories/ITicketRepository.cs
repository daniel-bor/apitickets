using DesafioDotNET.Models;

namespace DesafioDotNET.Repositories
{
    public interface ITicketRepository
    {
        Task<IEnumerable<Ticket>> GetTicketsAsync();
        Task<Ticket> GetTicketAsync(int TicketId);
        Task<bool> InsertTicketAsync(List<Ticket> tickets);
    }
}
