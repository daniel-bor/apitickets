namespace DesafioDotNET.Models
{
    public class Report
    {
        public List<TicketReport> Tickets { get; set; }
        public int NoTicketEstado1 { get; set; }
        public int NoTicketEstado2 { get; set; }
        public int NoTickets { get; set; }

        public Report(List<Ticket> tickets) 
        {
            Tickets = tickets.Select(t => new TicketReport
            {
                MesCreacion = t.FechaCreacionDateTime.Month,
                IdUsuario = t.IdUsuario
            }).ToList();

            NoTicketEstado1 = tickets.Count(ticket => ticket.Estado == 1);
            NoTicketEstado2 = tickets.Count(ticket => ticket.Estado == 2);
            NoTickets = tickets.Count;
        }
    }
}
