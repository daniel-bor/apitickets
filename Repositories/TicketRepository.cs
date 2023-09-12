using Dapper;
using DesafioDotNET.Data;
using DesafioDotNET.Models;
using System.Data.SqlClient;

namespace DesafioDotNET.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        public readonly SQLServerConfiguration _connectionString;

        public TicketRepository(SQLServerConfiguration connectionString) 
        {
            this._connectionString = connectionString;
        }

        public SqlConnection dbConnection()
        {
            return new SqlConnection(_connectionString.SQLConnectionString);
        }

        public async Task<Ticket> GetTicketAsync(int TicketId)
        {
            var db = dbConnection();

            var sql = @"SELECT id AS IdTicket, created_at AS FechaCreacion, user_id AS IdUsuario, status_id AS Estado FROM Tickets WHERE id = @id";

            return await db.QueryFirstOrDefaultAsync<Ticket>(sql, new { id = TicketId });
        }

        public async Task<IEnumerable<Ticket>> GetTicketsAsync()
        {
            var db = dbConnection();

            var sql = @"SELECT id AS IdTicket, created_at AS FechaCreacion, user_id AS IdUsuario, status_id AS Estado FROM Tickets";

            return await db.QueryAsync<Ticket>(sql, new { });
        }

        public async Task<bool> InsertTicketAsync(List<Ticket> tickets)
        {
            var db = dbConnection();

            var sql = @"INSERT INTO Tickets(id, created_At, user_id, status_id)
                        VALUES (@id, @created_At, @user_id, @status_id)";

            var results = 0;

            foreach (var ticket in tickets)
            {
                var result = await db.ExecuteAsync(sql, new {
                    id = ticket.IdTicket,
                    created_at = ticket.FechaCreacion,
                    user_id = ticket.IdUsuario,
                    status_id = ticket.Estado
                });

                results += result;
            }

            return results > 0;
        }
    }
}
